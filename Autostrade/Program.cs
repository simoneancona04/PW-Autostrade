using System.Diagnostics;

namespace Autostrade
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 

        const string cFile = "db/44000";
        const string uFile = "db/44001";
        const string cFile1 = "db/44002";
        const string cFile2 = "db/44003";

        [STAThread]
        static void Main()
        {
            var cars = new Process();
            var users = new Process();

            cars.StartInfo.FileName = cFile + "/mtdb.exe";
            cars.StartInfo.WorkingDirectory = cFile;
            cars.StartInfo.CreateNoWindow = true;
            cars.Start();

            users.StartInfo.FileName = uFile + "/mtdb.exe";
            users.StartInfo.WorkingDirectory = uFile;
            users.StartInfo.CreateNoWindow = true;
            users.Start();

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            
        }
    }
}
