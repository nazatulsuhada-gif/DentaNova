using System;
using System.Windows.Forms;

namespace DentaNova2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // This runs your main login/dashboard form when the app starts
            Application.Run(new SelectDoctor());
        }
    }
}