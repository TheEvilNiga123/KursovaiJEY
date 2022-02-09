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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)

        {

            if (guna2TextBox6.Text == "")
            {
                MessageBox.Show("Введите логин пользователя");
                return;
            }
            if (guna2TextBox2.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            else if (guna2TextBox3.Text == "")
            {
                MessageBox.Show("Введите повторный пароль");
                return;
            }
            if (guna2TextBox1.Text == "")
            {
                MessageBox.Show("Введите фио пользователя");
                return;
            }
            if (guna2TextBox4.Text == "")
            {
                MessageBox.Show("Введите номер телефона ");
                return;
            }
            if (guna2TextBox5.Text == "")
            {
                MessageBox.Show("Введите адресс");
                return;
            }
            DBconnect connection = new DBconnect();
            connection.openConnection();

            MySqlCommand command = new MySqlCommand("INSERT INTO `ALP` (`login`, `pass`) VALUES (@uL, @uP)", connection.GetConnection());
              command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = guna2TextBox6.Text;

              if (guna2TextBox2.Text == guna2TextBox3.Text)
              {
                  command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = guna2TextBox2.Text;
              }
              else
              {
                  MessageBox.Show("Ведённые пароли не совпадают");
                  return;
              }

              if (command.ExecuteNonQuery() == 1)
                  MessageBox.Show("Логин и пароль введены");

              else
                  MessageBox.Show("Логин и пароль не ушли");
              

            MySqlCommand command2 = new MySqlCommand("INSERT INTO Client (FIO, Telephone, Address) VALUES (1, 2, 3)", connection.GetConnection());
            command2.Parameters.Add("1", MySqlDbType.VarChar).Value = guna2TextBox1.Text;
            command2.Parameters.Add("2", MySqlDbType.VarChar).Value = guna2TextBox4.Text;
            command2.Parameters.Add("3", MySqlDbType.VarChar).Value = guna2TextBox5.Text;

            connection.closeConnection();



                            Hide(); //прятки с форм 2
                            Form2 reg = new Form2(); //создаёт  переменную форм 2
                            Form1 avt = new Form1(); //создаёт переменную форм 1
                            avt.ShowDialog(); // открывается форма2 
                            reg.Close(); //открываетсч форм 1   
        
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
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Hide(); //прятки с форм 2
            Form2 reg = new Form2(); //создаёт  переменную форм 2
            Form1 avt = new Form1(); //создаёт переменную форм 1
            avt.ShowDialog(); // открывается форма2 
            reg.Close(); //открываетсч форм 1
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            
            DBconnect connection = new DBconnect();
            connection.openConnection();
            MySqlCommand command2 = new MySqlCommand("SELECT MAX(`idAC`) FROM `ALP`", connection.GetConnection());
            string test = command2.ExecuteScalar().ToString();
            MessageBox.Show(test);
            connection.closeConnection();
        }
    }
}
