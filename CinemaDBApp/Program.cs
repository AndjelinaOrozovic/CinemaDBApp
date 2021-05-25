using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaDBApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            var language1 = ConfigurationManager.AppSettings["language1"];
            Thread.CurrentThread.CurrentCulture = new CultureInfo(language1);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language1);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormLogIn f = new FormLogIn();
            Application.Run(f);
        }
    }
}
