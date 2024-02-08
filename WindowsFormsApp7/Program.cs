using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    static class Data
    {
        public static string Glob_connection_string  = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Дэмо Экзамен\source\repos\WindowsFormsApp7\WindowsFormsApp7\VTkilinika.mdf';Integrated Security=True";
    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}
