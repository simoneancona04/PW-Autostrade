using System.Diagnostics;
using CSmtdb;

namespace Autostrade
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        const string cFile = "db/44000";    // vetture
        const string uFile = "db/44001";    // utenti
        const string mFile = "db/44002";    // manutenzioni
        const string lFile = "db/44003";    // patenti

        [STAThread]
        static void Main()
        {
            var cars = new Process();
            var users = new Process();
            var mai = new Process();
            var license = new Process();

            cars.StartInfo.FileName = cFile + "/mtdb.exe";
            cars.StartInfo.WorkingDirectory = cFile;
            cars.StartInfo.CreateNoWindow = true;
            cars.Start();

            users.StartInfo.FileName = uFile + "/mtdb.exe";
            users.StartInfo.WorkingDirectory = uFile;
            users.StartInfo.CreateNoWindow = true;
            users.Start();

            users.StartInfo.FileName = mFile + "/mtdb.exe";
            users.StartInfo.WorkingDirectory = mFile;
            users.StartInfo.CreateNoWindow = true;
            users.Start();

            users.StartInfo.FileName = lFile + "/mtdb.exe";
            users.StartInfo.WorkingDirectory = lFile;
            users.StartInfo.CreateNoWindow = true;
            users.Start();

            var carDatabase = new MTDBHandler("localhost", 44000);
            var userDatabase = new MTDBHandler("localhost", 44001);
            var maintDatabase = new MTDBHandler("localhost", 44002);
            var licenseDatabase = new MTDBHandler("localhost", 44003);

            var carTable = new TableDescriptor("vetture");
            var userTable = new TableDescriptor("utenti");
            var maintTable = new TableDescriptor("manutenzione");
            var licenseTable = new TableDescriptor("patenti");

            carTable.Columns.Add(new ColumnDescriptor("targa", DBtype.STRING128));
            carTable.Columns.Add(new ColumnDescriptor("modello", DBtype.STRING128));
            carTable.Columns.Add(new ColumnDescriptor("marca", DBtype.STRING128));
            carTable.Columns.Add(new ColumnDescriptor("libretto", DBtype.STRING128));
            carTable.Columns.Add(new ColumnDescriptor("anno", DBtype.INTEGER));
            carTable.Columns.Add(new ColumnDescriptor("consumi", DBtype.REAL));

            userTable.Columns.Add(new ColumnDescriptor("nome", DBtype.STRING128));
            userTable.Columns.Add(new ColumnDescriptor("password", DBtype.STRING128));

            carDatabase.SafeDefineTable(carTable);
            userDatabase.SafeDefineTable(userTable);
            var admin = new DataBaseObject();
            admin.AddString("nome", "admin");
            admin.AddString("password", "password");
            userDatabase.Insert(admin);

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(carDatabase, userDatabase));
            
        }
    }
}
