using Configuration.heplers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Configuration
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var licenseKey = ConfigurationManager.AppSettings["licenseKey"];
            var token = Common.GetDriveSerialNumber().ToGenerateLicenseKey();
            if (licenseKey == token)
                Application.Run(new Form1());
            else
                Application.Run(new Register());
        }
    }
}
