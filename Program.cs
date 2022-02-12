
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovaiJEY
{
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
            Application.Run(new Form1());
        }
    }

    public class DBconnect
    {
        MySqlConnection connection = new MySqlConnection("server=caseum.ru;port=33333;user=st_1_5_19;database=st_1_5_19;password=74917110;");
        //Создание подключения
        public void openConnection() //Строка открытия
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection() //Строка закрытия
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection GetConnection() //Возвращает подключение 
        {
            return connection;
        }
    }
    static class ClientData
    {
        
        public static string lvl;

    }
}
