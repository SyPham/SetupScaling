using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
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
            if (string.IsNullOrEmpty(licenseKey))
                Application.Run(new Register());
            else
                Application.Run(new Form1());
        }
    }
}
