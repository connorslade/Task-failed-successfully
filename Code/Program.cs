using System;
using System.Windows.Forms;

namespace WinXP2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// Created by Sigma76 AKA Basicprogrammer10
        /// Github: https://github.com/Basicprogrammer10/Task-failed-successfully
        /// </summary>
        [STAThread]
        private static void Main()
        {
            MessageBox.Show("Task failed successfully", "Windows XP", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}