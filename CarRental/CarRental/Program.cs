using System;
using System.Data;
using System.Windows.Forms;
using CarRental_BusinessLogicLayer;
namespace CarRental
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
            Application.Run(new Login.frmLogin());

        }
    }
}
