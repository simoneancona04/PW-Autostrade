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

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            
        }
    }
}
