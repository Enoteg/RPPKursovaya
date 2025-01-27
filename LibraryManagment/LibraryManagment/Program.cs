using System;
using System.Windows.Forms;
using LibraryManagement;

namespace LibraryManagment
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Убедитесь, что MainForm существует и правильно настроен
            Application.Run(new MainForm());
        }
    }
}
