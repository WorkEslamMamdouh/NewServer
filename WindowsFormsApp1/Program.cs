using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        private static void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Check if the user is attempting to close the form
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Prevent the form from closing
                e.Cancel = true;
            }
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
