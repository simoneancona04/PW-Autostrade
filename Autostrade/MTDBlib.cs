using System.Net.Sockets;
using System.Text;

namespace CSmtdb
{
    public class MTDBHandler
    {
        private TcpClient tcpClient;
        private NetworkStream stream;
        private byte[] sendBuf;
        private byte[] recvBuf;
        const int MAX_STR_LEN = 128;
        const int MAX_BUF_LEN = 8192;
        private void VersionCheck()
        {
            byte[] version = new byte[1];
            version[0] = 0x01;
            stream.Write(version, 0, 1);

            byte[] response = new byte[10];
            stream.Read(response, 0, 10);

            string str = Encoding.ASCII.GetString(response);
            str = str.Replace("\0", "");
            if (str != "mtdb 1") throw new IncompatibleVersionException();
        }

        public MTDBHandler(string ip, int port)
        {
            if (ip == "localhost") ip = "127.0.0.1";
            tcpClient = new TcpClient(ip, port);

            stream = tcpClient.GetStream();
            VersionCheck();
        }

        public bool IsEmpty()
        {
            sendBuf = new byte[1];
            sendBuf[0] = 0x00;
            recvBuf = new byte[1];

            stream.Write(sendBuf, 0, sendBuf.Length);
            stream.Read(recvBuf, 0, recvBuf.Length);

            if (recvBuf[0] == 0xFF) return true;
            return false;
        }

        public string GetTableName()
        {
            sendBuf = new byte[1];
            sendBuf[0] = 0x01;
            recvBuf = new byte[MAX_STR_LEN];

            stream.Write(sendBuf, 0, sendBuf.Length);
            stream.Read(recvBuf, 0, MAX_STR_LEN);

            return Encoding.ASCII.GetString(recvBuf).Replace("\0", "");
        }

        public int GetVersion()
        {
            sendBuf = new byte[1];
            sendBuf[0] = 0x01;
            recvBuf = new byte[1];

            stream.Write(sendBuf, 0, sendBuf.Length);
            stream.Read(recvBuf, 0, MAX_STR_LEN);

            return recvBuf[0];

        }

        public DataBaseObject Get(int id)
        {
            sendBuf = new byte[5];
            sendBuf[0] = 0x02;
            var num = Number.FromInt(id);
            for (int i = 0; i < num.Length; i++)
            {
                sendBuf[i + 1] = num[i];
            }
            recvBuf = new byte[MAX_BUF_LEN];

            stream.Write(sendBuf, 0, sendBuf.Length);
            stream.Read(recvBuf, 0, MAX_BUF_LEN);

            return new DataBaseObject(recvBuf);
        }

        public List<object> GetColumn(string columnName, DBtype type)
        {
            sendBuf = new byte[MAX_STR_LEN + 2];
            sendBuf[0] = 0x03;
            var name = ByteArray.Resize(128, Encoding.ASCII.GetBytes(columnName));
            for (int i = 0; i < name.Length; i++)
            {
                sendBuf[i + 1] = name[i];
            }
            sendBuf[MAX_STR_LEN + 1] = (byte)type;
            recvBuf = new byte[MAX_BUF_LEN];

            stream.Write(sendBuf, 0, sendBuf.Length);
            stream.Read(recvBuf, 0, MAX_BUF_LEN);

            List<object> list = new List<object>();

            if (type == DBtype.STRING128)
            {
                for (int i = 0, pos = 1; i < recvBuf[0]; i++, pos += MAX_STR_LEN)
                {
                    list.Add(
                        Encoding.ASCII.GetString(
                            ByteArray.SubByteArray(
                                recvBuf, pos, pos + MAX_STR_LEN
                            )
                        ).Replace("\0", "")
                    );
                }
            }
            else if (type == DBtype.INTEGER)
            {
                for (int i = 0, pos = 1; i < recvBuf[0]; i++, pos += 4)
                {
                    list.Add(
                        Number.ToInt(
                            ByteArray.SubByteArray(
                                recvBuf, pos, pos + 4
                            )
                        )
                    );
                }
            }
            else
            {
                for (int i = 0, pos = 1; i < recvBuf[0]; i++, pos += 4)
                {
                    list.Add(
                        Number.ToReal(
                            ByteArray.SubByteArray(
                                recvBuf, pos, pos + 4
                            )
                        )
                    );
                }
            }
            return list;
        }

        public void Clear()
        {
            sendBuf = new byte[1];
            sendBuf[0] = 0x0C;

            stream.Write(sendBuf, 0, 1);
        }

        public bool Remove(int id)
        {
            sendBuf = new byte[5];
            sendBuf[0] = 0x09;
            recvBuf = new byte[1];
            var num = Number.FromInt(id);
            for (int i = 0; i < 4; i++)
            {
                sendBuf[i + 1] = num[i];
            }

            stream.Write(sendBuf, 0, sendBuf.Length);
            stream.Read(recvBuf, 0, 1);

            if (recvBuf[0] == 0xFF) return true;
            return false;
        }

        public List<DataBaseObject> GetIfContains(string column, string stringToSearch)
        {
            sendBuf = new byte[MAX_BUF_LEN];
            sendBuf[0] = 0x04;
            var temp = new byte[MAX_BUF_LEN];
            var name = ByteArray.Resize(128, Encoding.ASCII.GetBytes(column));
            var str = ByteArray.Resize(128, Encoding.ASCII.GetBytes(stringToSearch));

            for (int i = 0; i < 128; i++)
            {
                sendBuf[i + 1] = name[i];
            }

            for (int i = 0; i < 128; i++)
            {
                sendBuf[i + 128] = str[i];
            }

            stream.Write(sendBuf, 0, sendBuf.Length);
            stream.Read(temp, 0, MAX_BUF_LEN);

            var list = new List<DataBaseObject>();

            for (int i = 0, pos = 1; i < temp[0]; i++, pos += 4)
            {
                list.Add(
                    Get(
                        Number.ToInt(
                            ByteArray.SubByteArray(temp, pos, pos + 4)
                        )
                    )
                );
            }

            return list;
        }


        public List<DataBaseObject> GetIfEqu(string column, DBtype type, object value)
        {
            sendBuf = new byte[MAX_BUF_LEN];
            sendBuf[0] = 0x05;
            var temp = new byte[MAX_BUF_LEN];
            var name = ByteArray.Resize(128, Encoding.ASCII.GetBytes(column));
            byte[] obj;

            if(type == DBtype.INTEGER)
            {
                obj = Number.FromInt((int)value);
            } else if(type == DBtype.REAL)
            {
                obj = Number.FromFloat((float)value);

            }
            else
            {
                obj = ByteArray.Resize(128, Encoding.ASCII.GetBytes((string)value));

            }

            for (int i = 0; i < 128; i++)
            {
                sendBuf[i + 1] = name[i];
            }

            sendBuf[128] = (byte)type;

            for (int i = 0; i < obj.Length; i++)
            {
                sendBuf[i + 129] = obj[i];
            }

            stream.Write(sendBuf, 0, sendBuf.Length);
            stream.Read(temp, 0, MAX_BUF_LEN);

            var list = new List<DataBaseObject>();

            for (int i = 0, pos = 1; i < temp[0]; i++, pos += 4)
            {
                list.Add(
                    Get(
                        Number.ToInt(
                            ByteArray.SubByteArray(temp, pos, pos + 4)
                        )
                    )
                );
            }

            return list;
        }

        public List<DataBaseObject> GetIfGrater(string column, DBtype type, object value)
        {
            sendBuf = new byte[MAX_BUF_LEN];
            sendBuf[0] = 0x06;
            var temp = new byte[MAX_BUF_LEN];
            var name = ByteArray.Resize(128, Encoding.ASCII.GetBytes(column));
            byte[] obj;

            if (type == DBtype.INTEGER)
            {
                obj = Number.FromInt((int)value);
            }
            else if (type == DBtype.REAL)
            {
                obj = Number.FromFloat((float)value);

            }
            else
            {
                obj = ByteArray.Resize(128, Encoding.ASCII.GetBytes((string)value));

            }

            for (int i = 0; i < 128; i++)
            {
                sendBuf[i + 1] = name[i];
            }

            sendBuf[128] = (byte)type;

            for (int i = 0; i < obj.Length; i++)
            {
                sendBuf[i + 129] = obj[i];
            }

            stream.Write(sendBuf, 0, sendBuf.Length);
            stream.Read(temp, 0, MAX_BUF_LEN);

            var list = new List<DataBaseObject>();

            for (int i = 0, pos = 1; i < temp[0]; i++, pos += 4)
            {
                list.Add(
                    Get(
                        Number.ToInt(
                            ByteArray.SubByteArray(temp, pos, pos + 4)
                        )
                    )
                );
            }

            return list;
        }

        public List<DataBaseObject> GetIfLess(string column, DBtype type, object value)
        {
            sendBuf = new byte[MAX_BUF_LEN];
            sendBuf[0] = 0x06;
            var temp = new byte[MAX_BUF_LEN];
            var name = ByteArray.Resize(128, Encoding.ASCII.GetBytes(column));
            byte[] obj;

            if (type == DBtype.INTEGER)
            {
                obj = Number.FromInt((int)value);
            }
            else if (type == DBtype.REAL)
            {
                obj = Number.FromFloat((float)value);

            }
            else
            {
                obj = ByteArray.Resize(128, Encoding.ASCII.GetBytes((string)value));

            }

            for (int i = 0; i < 128; i++)
            {
                sendBuf[i + 1] = name[i];
            }

            sendBuf[128] = (byte)type;

            for (int i = 0; i < obj.Length; i++)
            {
                sendBuf[i + 129] = obj[i];
            }

            stream.Write(sendBuf, 0, sendBuf.Length);
            stream.Read(temp, 0, MAX_BUF_LEN);

            var list = new List<DataBaseObject>();

            for (int i = 0, pos = 1; i < temp[0]; i++, pos += 4)
            {
                list.Add(
                    Get(
                        Number.ToInt(
                            ByteArray.SubByteArray(temp, pos, pos + 4)
                        )
                    )
                );
            }

            return list;
        }

        public bool SafeDefineTable(TableDescriptor td)
        {
            byte[] tdBytes = td.ToBytes();
            sendBuf = new byte[] { 0x0A };
            sendBuf = sendBuf.Concat(tdBytes).ToArray();
            recvBuf = new byte[1];

            stream.Write(sendBuf, 0, sendBuf.Length);
            stream.Read(recvBuf, 0, 1);

            if (recvBuf[0] == 0xFF) return true;
            return false;
        }

        public Int32 Insert(DataBaseObject dbo)
        {
            byte[] dboBytes = dbo.ToBytes();
            sendBuf = new byte[] { 0x08 };
            sendBuf = sendBuf.Concat(dboBytes).ToArray();
            recvBuf = new byte[4];

            stream.Write(sendBuf, 0, sendBuf.Length);
            stream.Read(recvBuf, 0, recvBuf.Length);

            return Number.ToInt(recvBuf);
        }
        public void Close()
        {
            sendBuf = new byte[1];
            sendBuf[0] = 0xFF;

            stream.Write(sendBuf, 0, sendBuf.Length);
        }

        public string GetCSV()
        {
            sendBuf = new byte[1];
            sendBuf[0] = 0x0D;
            recvBuf = new byte[MAX_BUF_LEN];

            stream.Write(sendBuf, 0, sendBuf.Length);
            stream.Read(recvBuf, 0, MAX_BUF_LEN);

            return Encoding.ASCII.GetString(recvBuf).Replace("\0", "");
        }


    }

    public enum DBtype
    {
        INTEGER,
        REAL,
        STRING128
    }

    public class DataBaseObject
    {
        private Dictionary<string, Dictionary<DBtype, object>> element;
        const int MAX_STR_LEN = 128;

        public DataBaseObject()
        {
            element = new Dictionary<string, Dictionary<DBtype, object>>();
        }
        public DataBaseObject(byte[] packedBuffer)
        {
            element = new Dictionary<string, Dictionary<DBtype, object>>();

            if (packedBuffer[0] != 0xFF)
            {
                var nCol = packedBuffer[0];
                var pos = 1;

                for (int i = 0; i < nCol; i++)
                {
                    string tempColumn = Encoding.ASCII.GetString(
                        ByteArray.SubByteArray(packedBuffer, pos, pos + MAX_STR_LEN)
                    ).Replace("\0", "");

                    pos += MAX_STR_LEN;

                    DBtype tempType = (DBtype)packedBuffer[pos];
                    pos += 1;
                    if (tempType == DBtype.STRING128)
                    {
                        element[tempColumn] = new Dictionary<DBtype, object>();
                        element[tempColumn][DBtype.STRING128] = Encoding.ASCII.GetString(
                            ByteArray.SubByteArray(packedBuffer, pos, pos + MAX_STR_LEN)
                        ).Replace("\0", "");
                        pos += MAX_STR_LEN;
                    }
                    else if (tempType == DBtype.INTEGER)
                    {
                        element[tempColumn] = new Dictionary<DBtype, object>();
                        element[tempColumn][DBtype.INTEGER] = Number.ToInt(
                            ByteArray.SubByteArray(packedBuffer, pos, pos + 4)
                        );
                        pos += 4;
                    }
                    else
                    {
                        element[tempColumn] = new Dictionary<DBtype, object>();
                        element[tempColumn][DBtype.REAL] = Number.ToReal(
                            ByteArray.SubByteArray(packedBuffer, pos, pos + 4)
                        );
                        pos += 4;
                    }
                }
            }
        }

        public string GetString(string column)
        {
            element.TryGetValue(column, out var value);
            if (value == null) throw new ElementNotFound();
            value.TryGetValue(DBtype.STRING128, out var str);
            if (str == null) throw new ElementNotFound();

            return (string)str;

        }

        public Int32 GetInteger(string column)
        {
            element.TryGetValue(column, out var value);
            if (value == null) throw new ElementNotFound(); ;
            value.TryGetValue(DBtype.INTEGER, out var num);
            if (num == null) throw new ElementNotFound(); ;

            return (Int32)num;
        }

        public float GetReal(string column)
        {
            element.TryGetValue(column, out var value);
            if (value == null) throw new ElementNotFound(); ;
            value.TryGetValue(DBtype.INTEGER, out var num);
            if (num == null) throw new ElementNotFound(); ;

            return (float)num;
        }

        public void AddString(string column, string str)
        {
            element.Add(column, new Dictionary<DBtype, object>
            {
                [DBtype.STRING128] = str
            });
        }

        public void AddInteger(string column, Int32 number)
        {
            element.Add(column, new Dictionary<DBtype, object>
            {
                [DBtype.INTEGER] = number
            });
        }

        public void AddReal(string column, float number)
        {
            element.Add(column, new Dictionary<DBtype, object>
            {
                [DBtype.REAL] = number
            });
        }

        public byte[] ToBytes()
        {
            List<byte> bytes = new List<byte>();
            var nCol = element.Count();
            bytes.Add((byte)nCol);
            var keys = element.Keys;
            foreach (string str in keys)
            {
                var strBytes = Encoding.ASCII.GetBytes(str);
                strBytes = ByteArray.Resize(MAX_STR_LEN, strBytes);
                foreach (byte b in strBytes) bytes.Add(b);

                Dictionary<DBtype, object> d;
                element.TryGetValue(str, out d);

                bytes.Add((byte)d.Keys.First());

                if (d.Keys.First() == DBtype.STRING128)
                {
                    object o;
                    d.TryGetValue(DBtype.STRING128, out o);
                    var strBytes2 = Encoding.ASCII.GetBytes((string)o);
                    strBytes2 = ByteArray.Resize(MAX_STR_LEN, strBytes2);

                    foreach (byte b in strBytes2) bytes.Add(b);
                }
                else if (d.Keys.First() == DBtype.INTEGER)
                {
                    object o;
                    d.TryGetValue(DBtype.INTEGER, out o);
                    var num = Number.FromInt((Int32)o);
                    foreach (byte b in num) bytes.Add(b);
                }
                else
                {
                    object o;
                    d.TryGetValue(DBtype.REAL, out o);
                    var num = Number.FromFloat((float)o);
                    foreach (byte b in num) bytes.Add(b);
                }
            }
            return bytes.ToArray();
        }

        override public string ToString()
        {
            string str = "{";
            int i = 0;
            foreach (string k in element.Keys)
            {
                str += "\"" + k + "\":";

                Dictionary<DBtype, object> d;
                element.TryGetValue(k, out d);

                if (d.Keys.First() == DBtype.STRING128)
                {
                    object o;
                    d.TryGetValue(DBtype.STRING128, out o);
                    str += "\"" + (string)o + "\"";
                }
                else if (d.Keys.First() == DBtype.INTEGER)
                {
                    object o;
                    d.TryGetValue(DBtype.INTEGER, out o);
                    str += (Int32)o;
                }
                else
                {
                    object o;
                    d.TryGetValue(DBtype.REAL, out o);
                    str += (float)o;
                }
                if (i < element.Count() - 1) str += ",";
                i++;
            }

            return str + "}";
        }
    }

    class ByteArray
    {
        public static byte[] SubByteArray(byte[] array, int start, int finish)
        {
            byte[] res = new byte[finish - start];

            for (int i = start; i < finish; i++)
            {
                res[i - start] = array[i];
            }

            return res;
        }

        public static bool Equals(byte[] b1, byte[] b2)
        {
            if (b1.Length != b2.Length) return false;
            for (int i = 0; i < b1.Length; i++)
            {
                if (b1[i] != b2[i]) return false;
            }

            return true;
        }

        public static byte[] Copy(byte[] bytes)
        {
            var res = new byte[bytes.Length];
            for (int i = 0; i < bytes.Length; i++)
            {
                res[i] = bytes[i];
            }

            return res;
        }

        public static byte[] Resize(int size, byte[] bytes, bool reverse = false)
        {
            var bt = new byte[size];
            var old = Copy(bytes);
            if (reverse)
                Array.Reverse(old);

            for (int i = 0; i < old.Length; i++)
            {
                if (i == bt.Length) return bt;
                bt[i] = old[i];
            }

            return bt;
        }
    }

    public class Number
    {
        public static int ToInt(byte[] bytes)
        {
            var bt = ByteArray.Copy(bytes);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bt);

            return BitConverter.ToInt32(bt, 0);
        }

        public static float ToReal(byte[] bytes)
        {
            var bt = ByteArray.Copy(bytes);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(bt);

            return BitConverter.ToUInt32(bt, 0);
        }

        public static byte[] FromInt(int number)
        {
            byte[] res = BitConverter.GetBytes(number);
            if (BitConverter.IsLittleEndian) Array.Reverse(res);

            return res;
        }

        public static byte[] FromFloat(float number)
        {
            byte[] res = BitConverter.GetBytes(number);
            if (BitConverter.IsLittleEndian) Array.Reverse(res);
            return res;
        }
    }

    public class TableDescriptor
    {
        private string tableName;
        private List<ColumnDescriptor> columns;
        public TableDescriptor(string tableName)
        {
            this.tableName = tableName;
            columns = new List<ColumnDescriptor>();
        }

        public List<ColumnDescriptor> Columns { get => columns; set => columns = value; }

        public byte[] ToBytes()
        {
            List<byte> bytes = new List<byte>();
            var name = ByteArray.Resize(
                    128, Encoding.ASCII.GetBytes(tableName)
                );
            for (int i = 0; i < 128; i++) bytes.Add(name[i]);

            bytes.Add((byte)columns.Count());

            foreach (ColumnDescriptor cd in columns)
            {
                var b = cd.ToBytes();
                foreach (byte b2 in b)
                {
                    bytes.Add(b2);
                }
            }
            return bytes.ToArray();
        }


    }

    public class ColumnDescriptor
    {
        private string columnName;
        private DBtype columnType;

        public ColumnDescriptor(string columnName, DBtype columnType)
        {
            this.columnName = columnName;
            this.columnType = columnType;
        }

        public byte[] ToBytes()
        {
            byte[] bytes;

            bytes = Encoding.ASCII.GetBytes(columnName);
            bytes = ByteArray.Resize(129, bytes);
            bytes[128] = (byte)columnType;

            return bytes;
        }
    }

    public class IncompatibleVersionException : Exception
    {

    }

    public class TypeError : Exception
    {

    }

    public class ElementNotFound : Exception
    {

    }
}