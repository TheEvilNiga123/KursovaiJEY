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
using System.Security.Cryptography;

namespace KursovaiJEY
{
    public partial class Form2 : Form
    {
        

        public Form2()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)

        {
            if (guna2TextBox1.Text == "")
            {
                guna2TextBox1.PlaceholderText = "Введите фио пользователя";
                guna2TextBox1.PlaceholderForeColor = Color.Red;
                return;
            }
            if (guna2TextBox4.Text == "")
            {
                guna2TextBox4.PlaceholderText = "Введите номер телефона";
                guna2TextBox4.PlaceholderForeColor = Color.Red;
                return;
            }
            if (guna2TextBox4.TextLength < 11)
            {
                if (listBox1.Items.Contains("Длина телефона меньше допустимой. Минимальная длина 11 символов.") == false)
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add("Длина телефона меньше 11 символов.");
                    return;
                }

            }
            if (guna2TextBox5.Text == "")
            {
                guna2TextBox5.PlaceholderText = "Введите адресс";
                guna2TextBox5.PlaceholderForeColor = Color.Red;
                return;
            }

            if (guna2TextBox6.Text == "")
            {
                guna2TextBox6.PlaceholderText = "Введите логин пользователя";
                guna2TextBox6.PlaceholderForeColor = Color.Red;
                return;
            }
            if (guna2TextBox6.TextLength < 3)
            {
                if (listBox1.Items.Contains("Длина логина меньше допустимой. Минимальная длина 3 символов.") == false)
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add("Длина логина меньше 3 символов.");
                    return;
                }

            }
            if (guna2TextBox2.Text == "")
            {
                guna2TextBox2.PlaceholderText = "Введите пароль";
                guna2TextBox2.PlaceholderForeColor = Color.Red;
                return;
            }
            if (guna2TextBox2.TextLength < 6)
            {
                if (listBox1.Items.Contains("Длина пароля меньше допустимой. Минимальная длина 6 символов.") == false)
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add("Длина пароля меньше 6 символов.");
                    return;
                }

            }
            else if (guna2TextBox3.Text == "")
            {
                guna2TextBox3.PlaceholderText = "Введите повторный пароль";
                guna2TextBox3.PlaceholderForeColor = Color.Red;
                return;
            }
            if (guna2TextBox3.TextLength < 6)
            {
                if (listBox1.Items.Contains("Длина повторного пароля меньше допустимой. Минимальная длина 6 символов.") == false)
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add("Длина повторного пароля меньше 6 символов.");
                    return;
                }

            }

            if (checkUser())
                return;

            DBconnect connection = new DBconnect();
            connection.openConnection();

            MySqlCommand command = new MySqlCommand("INSERT INTO `ALP` (`login`, `pass`, `lvl`) VALUES (@uL, @uP, @uLV)", connection.GetConnection());


              command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = guna2TextBox6.Text;
              command.Parameters.Add("@uLV", MySqlDbType.VarChar).Value = 1;
            if (guna2TextBox2.Text == guna2TextBox6.Text)
            {
                if (listBox1.Items.Contains("Пароль и логин не могут быть одинаковыми") == false)
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add("Пароль и логин не могут быть одинаковыми");
                }
                 return;

            }
            else if (guna2TextBox2.Text == guna2TextBox3.Text)
            {
                command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = PassHide.Hash(guna2TextBox2.Text);
            }
            else
            {
                if (listBox1.Items.Contains("Ведённые пароли не совпадают") == false)
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add("Ведённые пароли не совпадают");
                }
               
                  return;
            }
            if (command.ExecuteNonQuery() == 1) 
            {
                MySqlCommand command3 = new MySqlCommand("SELECT MAX(`idAC`) FROM `ALP`", connection.GetConnection());
                string test = command3.ExecuteScalar().ToString();
                
                MySqlCommand command2 = new MySqlCommand("INSERT INTO Client (idAC, FIO, Telephone, Address) VALUES (@1, @2, @3, @4)", connection.GetConnection());
                command2.Parameters.Add("@1", MySqlDbType.VarChar).Value = test;

                if(guna2TextBox1.Text == "" ^ guna2TextBox1.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Ваше имя не должно содержать цифр или любых других знаков!");
                    return;
                }
                else
                {
                    command2.Parameters.Add("@2", MySqlDbType.VarChar).Value = guna2TextBox1.Text;
                }

                command2.Parameters.Add("@3", MySqlDbType.VarChar).Value = guna2TextBox4.Text;
                command2.Parameters.Add("@4", MySqlDbType.VarChar).Value = guna2TextBox5.Text;
                command2.ExecuteNonQuery();

            }  
            else
            {
              listBox1.Items.Clear();
              listBox1.Items.Add("Логин и пароль не ушли");
              return;
            }

            connection.closeConnection();

            Hide(); //прятки с форм 2
            Form2 reg = new Form2(); //создаёт  переменную форм 2
            Form1 avt = new Form1(); //создаёт переменную форм 1
            avt.ShowDialog(); // открывается форма2 
            reg.Close(); //открываетсч форм 1
        }
        public Boolean checkUser()
        {
            DBconnect connection = new DBconnect(); //Подключение к базе данных с помощью файла Program.CS

            DataTable table = new DataTable(); //Создание таблицы

            MySqlDataAdapter adapter = new MySqlDataAdapter(); //Создание адаптера

            MySqlCommand command5 = new MySqlCommand("SELECT * FROM `ALP` WHERE `login` = @Ul", connection.GetConnection()); //Создание команды на выборку
            command5.Parameters.Add("@Ul", MySqlDbType.VarChar).Value = guna2TextBox6.Text; //Заменяем шифр из команды на переменные

            adapter.SelectCommand = command5; // адаптер выберает команду "КОММАНД"
            adapter.Fill(table); // ВЫБОР таблицы , в котором должны быть значения

            if (table.Rows.Count > 0) //Есть значения - выполняется вход
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Логин уже занят");
                return true;
            }

            else //аккаунт создан
                return false;

        }
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked == true) // если свич активирован, символы скрываются системным символом пароля 
            {
                guna2TextBox2.UseSystemPasswordChar = true;
            }
            else if (guna2ToggleSwitch1.Checked == false) // если не активирован, то всё по дефолту
            {
                guna2TextBox2.UseSystemPasswordChar = false;
            }
            if (guna2ToggleSwitch1.Checked == true) // если свич активирован, символы скрываются системным символом пароля 
            {
                guna2TextBox3.UseSystemPasswordChar = true;
            }
            else if (guna2ToggleSwitch1.Checked == false) // если не активирован, то всё по дефолту
            {
                guna2TextBox3.UseSystemPasswordChar = false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            guna2TextBox2.UseSystemPasswordChar = true; //Загружает для тест бокса при запуске значение 1!)
            guna2TextBox3.UseSystemPasswordChar = true; //Загружает для тест бокса при запуске значение 1!)
            guna2ToggleSwitch1.Visible = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Hide(); //прятки с форм 2
            Form2 reg = new Form2(); //создаёт  переменную форм 2
            Form1 avt = new Form1(); //создаёт переменную форм 1
            avt.ShowDialog(); // открывается форма2 
            reg.Close(); //открываетсч форм 1
        }
        private void guna2TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != ' ')
            {
                e.Handled = true;
            }
        }

        private void guna2TextBox6_KeyPress(object sender, KeyPressEventArgs e) 
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == '!' || e.KeyChar == '.' || e.KeyChar == '(' || e.KeyChar == ')' ||  e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Режим подсказок включен");
            if (guna2TextBox1.PlaceholderText == "ФИО")
            {
                guna2TextBox1.PlaceholderText = "Иванов Иван Иванович";
            }
            if (guna2TextBox4.PlaceholderText == "Номер телефона")
            {
                guna2TextBox4.PlaceholderText = "89123456789";
            }
            if (guna2TextBox5.PlaceholderText == "Адрес проживания")
            {
                guna2TextBox5.PlaceholderText = "Двинская 3";
            }
            if (guna2TextBox6.PlaceholderText == "Логин")
            {
                guna2TextBox6.PlaceholderText = "Login123_!.()";
            }
            if (guna2TextBox2.PlaceholderText == "Пароль")
            {
                guna2TextBox2.PlaceholderText = "Pass123_!.()";
            }
            if (guna2TextBox3.PlaceholderText == "Повторите пароль")
            {
                guna2TextBox3.PlaceholderText = "Pass123_!.()";
            }
            else 
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Режим подсказок выключен");
                guna2TextBox1.PlaceholderText = "ФИО";
                guna2TextBox4.PlaceholderText = "Номер телефона";
                guna2TextBox5.PlaceholderText = "Адресс проживания";
                guna2TextBox6.PlaceholderText = "Логин";
                guna2TextBox2.PlaceholderText = "Пароль";
                guna2TextBox3.PlaceholderText = "Повторите пароль";
                 
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

        private void guna2TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == '!' || e.KeyChar == '.' || e.KeyChar == '(' || e.KeyChar == ')' || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox2.Text != "" )
            {
                guna2ToggleSwitch1.Visible = true;
            }
            else if (guna2TextBox2.Text == "")
            {
                guna2ToggleSwitch1.Visible = false;
                guna2ToggleSwitch1.Checked = true;
            }
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox3.Text != "")
            {
                guna2ToggleSwitch1.Visible = true;
            }
            else if (guna2TextBox3.Text == "")
            {
                guna2ToggleSwitch1.Visible = false;
                guna2ToggleSwitch1.Checked = true;
            }
        }


    }
}
