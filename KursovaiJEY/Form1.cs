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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int idAC = 0;
            int lvl = 0;
            string fio = "0";
            string tel = "0";
            string add = "0";
            string dob = "0";
            string inn = "0";
            string loginUser = guna2TextBox1.Text; //Стринговая переменная берёт текстовое значение из поля ТексБокс1
            string passUser = guna2TextBox2.Text;
            DBconnect connection = new DBconnect(); //Подключение к базе данных с помощью файла Program.CS
            
            DataTable table = new DataTable(); //Создание таблицы

            MySqlDataAdapter adapter = new MySqlDataAdapter(); //Создание адаптера
            connection.openConnection();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `ALP` WHERE `login` = @Ul AND `pass` = @Up", connection.GetConnection()); //Создание команды на выборку
            command.Parameters.Add("@Ul", MySqlDbType.VarChar).Value = loginUser; //Заменяем шифр из команды на переменные
            command.Parameters.Add("@Up", MySqlDbType.VarChar).Value = PassHide.Hash(passUser); //зАМЕНЯЕМ ШИФР ИЗ КОМАНДЫ НА переменные
            adapter.SelectCommand = command; // адаптер выберает команду "КОММАНД"
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MySqlDataReader reader000 = command.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader000.Read())
                {
                    lvl = Convert.ToInt32(reader000[3]);
                }
                reader000.Close();
            }
            if (lvl == 1)
            {

                MySqlCommand command1 = new MySqlCommand("SELECT *, Client.FIO, Client.Telephone, Client.Address, Client.idAC, ALP.idAC FROM `Client`,`ALP` WHERE Client.idAC = ALP.idAC", connection.GetConnection());
                adapter.SelectCommand = command; // адаптер выберает команду "КОММАНД"
                adapter.Fill(table); // ВЫБОР таблицы , в котором должны быть значения

                if (table.Rows.Count > 0) //Есть значения - выполняется вход
                {
                    MySqlDataReader reader1 = command.ExecuteReader();
                    while (reader1.Read())
                    {
                        idAC = Convert.ToInt32(reader1[0]);
                        loginUser = reader1[1].ToString();
                        passUser = reader1[2].ToString();
                        lvl = Convert.ToInt32(reader1[3]); //возможно ошибки
                    }
                    reader1.Close();

                    SaveData.IDC = idAC;
                    SaveData.LOGINC = loginUser;
                    SaveData.PASSWORDC = passUser;
                    SaveData.LVLC = lvl;
                    MySqlDataReader reader2 = command1.ExecuteReader();
                    while (reader2.Read())
                    {
                        fio = reader2[2].ToString();
                        tel = reader2[3].ToString();
                        add = reader2[4].ToString();
                    }
                    reader2.Close();
                    SaveData.FIOC = fio;
                    SaveData.TELEPHONEC = tel;
                    SaveData.ADDRESSC = add;
                    Hide(); //прятки с форм 1
                    Form1 avt = new Form1(); //создаёт  переменную форм 1
                    Form3 menu = new Form3(); //создаёт переменную форм 2
                    menu.ShowDialog(); // открывается форма3 
                    avt.Close(); //закрывается форм 1
                }
            }
            if (lvl == 2)
            {
                MySqlCommand command2 = new MySqlCommand("SELECT Employee.idAC, Employee.FIO, Employee.Telephone, Employee.Address, Employee.DoB, Employee.INN FROM `Employee`,`ALP` WHERE Employee.idAC = ALP.idAC", connection.GetConnection());
                adapter.SelectCommand = command; // адаптер выберает команду "КОММАНД"
                adapter.Fill(table); // ВЫБОР таблицы , в котором должны быть значения

                if (table.Rows.Count > 0) //Есть значения - выполняется вход
                {
                    MySqlDataReader reader3 = command.ExecuteReader();
                    while (reader3.Read())
                    {
                        idAC = Convert.ToInt32(reader3[0]);
                        loginUser = reader3[1].ToString();
                        lvl = Convert.ToInt32(reader3[3]); //возможно ошибки
                    }
                    reader3.Close();

                    SaveData.IDe = idAC;
                    SaveData.LOGINe = loginUser;
                    SaveData.LVLe = lvl;
                    MySqlDataReader reader4 = command2.ExecuteReader();
                    while (reader4.Read())
                    {
                        fio = reader4[1].ToString();
                        tel = reader4[2].ToString();
                        add = reader4[3].ToString();
                        dob = reader4[4].ToString();
                        inn = reader4[5].ToString();
                    }
                    reader4.Close();
                    SaveData.FIOe = fio;
                    SaveData.TELEPHONEe = tel;
                    SaveData.ADDRESSe = add;
                    SaveData.DoBe = dob;
                    SaveData.INNe = inn;
                    Hide(); //прятки с форм 1
                    Form1 avt = new Form1(); //создаёт  переменную форм 1
                    Form3 menu = new Form3(); //создаёт переменную форм 2
                    menu.ShowDialog(); // открывается форма3 
                    avt.Close(); //закрывается форм 1
                }
            }
            if (lvl == 3)
            {

                MySqlCommand command1 = new MySqlCommand("SELECT *, Client.FIO, Client.Telephone, Client.Address, Client.idAC, ALP.idAC FROM `Client`,`ALP` WHERE Client.idAC = ALP.idAC", connection.GetConnection());
                adapter.SelectCommand = command; // адаптер выберает команду "КОММАНД"
                adapter.Fill(table); // ВЫБОР таблицы , в котором должны быть значения

                if (table.Rows.Count > 0) //Есть значения - выполняется вход
                {
                    MySqlDataReader reader1 = command.ExecuteReader();
                    while (reader1.Read())
                    {
                        idAC = Convert.ToInt32(reader1[0]);
                        loginUser = reader1[1].ToString();
                        passUser = reader1[2].ToString();
                        lvl = Convert.ToInt32(reader1[3]); //возможно ошибки
                    }
                    reader1.Close();

                    SaveData.IDe = idAC;
                    SaveData.LOGINe = loginUser;
                    SaveData.PASSWORDe = passUser;
                    SaveData.LVLe = lvl;
                    MySqlDataReader reader2 = command1.ExecuteReader();
                    while (reader2.Read())
                    {
                        fio = reader2[2].ToString();
                        tel = reader2[3].ToString();
                        add = reader2[4].ToString();
                    }
                    reader2.Close();
                    SaveData.FIOe = fio;
                    SaveData.TELEPHONEe = tel;
                    SaveData.ADDRESSe = add;
                    Hide(); //прятки с форм 1
                    Form1 avt = new Form1(); //создаёт  переменную форм 1
                    Form3 menu = new Form3(); //создаёт переменную форм 2
                    menu.ShowDialog(); // открывается форма3 
                    avt.Close(); //закрывается форм 1
                }
            }

            else //Иначе аккаунта нету или данные ведены неверно
            {
                if (listBox1.Items.Contains("Неверный логин или пароль") == false) 
                {
                    listBox1.Items.Add("Неверный логин или пароль");
                }


            }
            connection.closeConnection();
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
                else  // если не активирован, то всё по дефолту
                {
                    guna2TextBox2.UseSystemPasswordChar = false;
                }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2TextBox2.UseSystemPasswordChar = true; //Загружает для тест бокса при запуске значение 1!)
            guna2ToggleSwitch1.Visible = false;

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

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox2.Text != "")
            {
                guna2ToggleSwitch1.Visible = true;
            }
            else if (guna2TextBox2.Text == "")
            {
                guna2ToggleSwitch1.Visible = false;
                guna2ToggleSwitch1.Checked = true;
            }
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            Hide(); //прятки с форм 1
            Form1 avt = new Form1(); //создаёт  переменную форм 1
            Form2 reg = new Form2(); //создаёт переменную форм 2
            reg.ShowDialog(); // открывается форма2 
            avt.Close(); //открываетсч форм 1
        }
    }
}
