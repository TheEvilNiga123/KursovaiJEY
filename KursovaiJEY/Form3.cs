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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }


        private void guna2ControlBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (monthCalendar1.Visible == false)
            {
                monthCalendar1.Visible = true;
            }

            else
            {
                monthCalendar1.Visible = false;
            }

        }

        private void guna2Button5_Click(object sender, EventArgs e) //Кнопка отвечает за ГунаПикчурБокс 2 выводящий график работы
        {
            if (guna2PictureBox2.Visible == false)
            {
                listBox1.Visible = false;
                guna2PictureBox3.Visible = false;
                guna2PictureBox2.Visible = true;
            }

            else
            {
                guna2PictureBox2.Visible = true;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e) //Кнопка отвечает за ЛистБокс 1 выводящий главную страницу
        {
            if (listBox1.Visible == false)
            {
                guna2PictureBox2.Visible = false;
                guna2PictureBox3.Visible = false;
                listBox2.Visible = false;
                guna2Button7.Visible = false;
                guna2Button8.Visible = false;
                guna2Button9.Visible = false;
                guna2Button10.Visible = false;
                guna2Button11.Visible = false;
                guna2DataGridView1.Visible = false;
                guna2Panel4.Visible = false;
                listBox1.Visible = true;

            }
            else
            {
                listBox1.Visible = true;
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e) //Кнопка отвечает за ГунаПикчерБокс 3 выводящий Аварийные номера
        {
            if (guna2PictureBox3.Visible == false)
            {

                listBox1.Visible = false;
                guna2PictureBox2.Visible = false;
                listBox2.Visible = false;
                guna2Button7.Visible = false;
                guna2Button8.Visible = false;
                guna2Button9.Visible = false;
                guna2Button10.Visible = false;
                guna2Button11.Visible = false;
                guna2DataGridView1.Visible = false;
                guna2Panel4.Visible = false;
                guna2PictureBox3.Visible = true;
            }

            else
            {
                guna2PictureBox3.Visible = true;
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/theevilniga");
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (listBox2.Visible == false && guna2Button7.Visible == false)
            {
                listBox1.Visible = false;
                guna2PictureBox2.Visible = false;
                guna2PictureBox3.Visible = false;
                guna2Button8.Visible = false;
                guna2Button9.Visible = false;
                guna2Button10.Visible = false;
                guna2Button11.Visible = false;
                guna2DataGridView1.Visible = false;
                guna2Panel4.Visible = false;
                listBox2.Visible = true;
                guna2Button7.Visible = true;

            }

            else
            {
                listBox2.Visible = true;
                guna2Button7.Visible = true;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (guna2Button8.Visible == false && guna2Button9.Visible == false)
            {
                listBox1.Visible = false;
                guna2PictureBox2.Visible = false;
                guna2PictureBox3.Visible = false;
                listBox2.Visible = false;
                guna2Button7.Visible = false;
                guna2DataGridView1.Visible = false;
                guna2Panel4.Visible = false;
                guna2Button8.Visible = true;
                guna2Button9.Visible = true;

            }

            else
            {
                guna2Button8.Visible = true;
                guna2Button9.Visible = true;
            }
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            if (guna2Panel4.Visible == false)
            {
                listBox1.Visible = false;
                guna2PictureBox2.Visible = false;
                guna2PictureBox3.Visible = false;
                listBox2.Visible = false;
                guna2Button7.Visible = false;
                guna2DataGridView1.Visible = false;
                guna2Button8.Visible = true;
                guna2Button9.Visible = true;
                guna2Panel4.Visible = true;
            }

            else
            {
                guna2Panel4.Visible = true;
            }
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.Visible == false)
            {
                listBox1.Visible = false;
                guna2PictureBox2.Visible = false;
                guna2PictureBox3.Visible = false;
                listBox2.Visible = false;
                guna2Button7.Visible = false;
                guna2Panel4.Visible = false;
                guna2Button8.Visible = true;
                guna2Button9.Visible = true;
                guna2DataGridView1.Visible = true;
            }

            else
            {
                guna2DataGridView1.Visible = true;
            }
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text == "")
            {
                guna2TextBox1.PlaceholderText = "Введите фио пользователя";
                guna2TextBox1.PlaceholderForeColor = Color.Red;
                return;
            }
            if (guna2TextBox2.Text == "")
            {
                guna2TextBox2.PlaceholderText = "Описание к вашей жалобе";
                guna2TextBox2.PlaceholderForeColor = Color.Red;
                return;
            }
            if (guna2TextBox4.Text == "")
            {
                guna2TextBox4.PlaceholderText = "Введите номер телефона";
                guna2TextBox4.PlaceholderForeColor = Color.Red;
                return;
            }
            if (guna2TextBox4.TextLength < 11)

                if (listBox3.Items.Contains("Длина телефона меньше допустимой. Минимальная длина 11 символов.") == false)
                {
                    listBox3.Items.Clear();
                    listBox3.Items.Add("Длина телефона меньше 11 символов.");
                    return;
                }

            if (guna2TextBox5.Text == "")
            {
                guna2TextBox5.PlaceholderText = "Введите адресс";
                guna2TextBox5.PlaceholderForeColor = Color.Red;
                return;
            }

            DBconnect connection = new DBconnect();
            connection.openConnection();

            MySqlCommand command = new MySqlCommand("INSERT INTO `Claim` (`IDC`, `FIO`, `Telephone`, `AddressIncidents`, `DoI`, `DataReport`) VALUES (@I, @F, @T, @A, @D, @DR)", connection.GetConnection());

            command.Parameters.Add("@DoI", MySqlDbType.VarChar).Value = guna2TextBox2.Text;
            command.Parameters.Add("@DR", MySqlDbType.VarChar).Value = DateTime.Now;
           
        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != ' ')
            {
                e.Handled = true;
            }
        }

        private void guna2TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            listBox3.Items.Add("Режим подсказок включен");
            if (guna2TextBox1.PlaceholderText == "ФИО")
            {
                guna2TextBox1.PlaceholderText = "Иванов Иван Иванович";
            }
            if (guna2TextBox2.PlaceholderText == "Текст обращения")
            {
                guna2TextBox2.PlaceholderText = "С 3 часов дня в ванной комнате с крана бежит мутная вода";
            }
            if (guna2TextBox4.PlaceholderText == "Номер телефона")
            {
                guna2TextBox4.PlaceholderText = "89123456789";
            }
            if (guna2TextBox5.PlaceholderText == "Адрес")
            {
                guna2TextBox5.PlaceholderText = "Двинская 3";
            }
            else
            {
                listBox3.Items.Clear();
                listBox3.Items.Add("Режим подсказок выключен");
                guna2TextBox1.PlaceholderText = "ФИО";
                guna2TextBox2.PlaceholderText = "Номер телефона";
                guna2TextBox4.PlaceholderText = "Адрес";
                guna2TextBox5.PlaceholderText = "Текст обращения";
            }

        }
    }
}