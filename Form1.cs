using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovaiJEY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Hide(); //прятки с форм 1
            Form1 avt = new Form1(); //создаёт  переменную форм 1
            Form2 reg = new Form2(); //создаёт переменную форм 2
            reg.ShowDialog(); // открывается форма2 
            avt.Close(); //открываетсч форм 1
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string loginUser = guna2TextBox1.Text; //Стринговая переменная берёт текстовое значение из поля ТексБокс1
            string passUser = guna2TextBox2.Text;
            DBconnect connection = new DBconnect(); //Подключение к базе данных с помощью файла Program.CS

            DataTable table = new DataTable(); //Создание таблицы

            MySqlDataAdapter adapter = new MySqlDataAdapter(); //Создание адаптера

            MySqlCommand command = new MySqlCommand("SELECT * FROM `ALP` WHERE `login` = @Ul AND `pass` = @Up", connection.GetConnection()); //Создание команды на выборку
            command.Parameters.Add("@Ul", MySqlDbType.VarChar).Value = loginUser; //Заменяем шифр из команды на переменные
            command.Parameters.Add("@Up", MySqlDbType.VarChar).Value = passUser; //зАМЕНЯЕМ ШИФР ИЗ КОМАНДЫ НА переменные

            adapter.SelectCommand = command; // адаптер выберает команду "КОММАНД"
            adapter.Fill(table); // ВЫБОР таблицы , в котором должны быть значения

            if (table.Rows.Count > 0) //Есть значения - выполняется вход
            {
                
                Hide(); //прятки с форм 1
                Form1 avt = new Form1(); //создаёт  переменную форм 1
                Form3 menu = new Form3(); //создаёт переменную форм 3
                menu.ShowDialog(); // открывается форма3 
                avt.Close(); //открываетсч форм 1
            }

            else //Иначе аккаунта нету или данные ведены неверно
            {
                MessageBox.Show("Неверный логин или пароль");
            }    

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e) // работает, когда меняется прочеканность свича
         {
            if (guna2ToggleSwitch1.Checked == true) // если свич активирован, символы скрываются системным символом пароля 
            {
                guna2TextBox2.UseSystemPasswordChar = true;
            }
            else if (guna2ToggleSwitch1.Checked == false) // если не активирован, то всё по дефолту
            {
                guna2TextBox2.UseSystemPasswordChar = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2TextBox2.UseSystemPasswordChar = true; //Загружает для тест бокса при запуске значение 1!)
        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == '!' || e.KeyChar == '.' || e.KeyChar == '(' || e.KeyChar == ')' || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void guna2TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == '!' || e.KeyChar == '.' || e.KeyChar == '(' || e.KeyChar == ')' || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 avt = new Form1(); //создаёт  переменную форм 1
            Form3 menu = new Form3(); //создаёт переменную форм 2
            menu.ShowDialog(); // открывается форма2 
            avt.Close(); //открываетсч форм 1
        }
    }
}
