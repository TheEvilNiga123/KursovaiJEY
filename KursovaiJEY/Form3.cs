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
    public partial class Form3 : Form
    {
        int viemlvl = 0;
        string id_selected_rows = "0";
        string id_selected_rows2 = "0";
        string id_selected_rows3 = "0";
        string id_selected_rows4 = "0";
        public Form3()
        {
            InitializeComponent();

            ClaimTable();
            ClaimTable2();
            ClaimTable3();
            ClaimTable4();
        }

        private void Form3_Load(object sender, EventArgs e)
        {


            string lvl = SaveData.LVLe.ToString();
            label3.Text = lvl;
            if (SaveData.LVLC == 1)
            {
                toolStripButton2.Visible = false;
                toolStripButton8.Visible = false;
                toolStripButton4.Visible = false;
                guna2Button12.Visible = false;
                guna2Button13.Visible = false;
                guna2Button19.Visible = true;
                label1.Text = SaveData.LOGINC;
            }
            if (SaveData.LVLe == 2)
            {
                toolStripButton2.Visible = false;
                guna2Button12.Visible = false;
                guna2Button13.Visible = false;
                guna2Button8.Visible = false;
                label1.Text = SaveData.LOGINe;
            }
            if (SaveData.LVLe == 3)
            {
                guna2Button12.Visible = true;
                guna2Button13.Visible = true;
                label1.Text = SaveData.LOGINe;
            }
            guna2TextBox8.UseSystemPasswordChar = true; //Загружает для тест бокса при запуске значение 1!)
            guna2TextBox9.UseSystemPasswordChar = true; //Загружает для тест бокса при запуске значение 1!)
            guna2ToggleSwitch1.Visible = false;
            guna2TextBox26.UseSystemPasswordChar = true; //Загружает для тест бокса при запуске значение 1!)
            guna2TextBox27.UseSystemPasswordChar = true; //Загружает для тест бокса при запуске значение 1!)
            guna2ToggleSwitch2.Visible = false;
            listBox5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            listBox5.MeasureItem += lst_MeasureItem;
            listBox5.DrawItem += lst_DrawItem;

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
                guna2PictureBox3.Visible = false;
                listBox2.Visible = false;
                guna2Panel7.Visible = false;
                guna2Button7.Visible = false;
                guna2Button8.Visible = false;
                guna2Button9.Visible = false;
                guna2DataGridView1.Visible = false;
                guna2Panel4.Visible = false;
                guna2Panel5.Visible = false;
                listBox1.Visible = false;
                listBox4.Visible = false;
                guna2DataGridView2.Visible = false;
                toolStrip1.Visible = false;
                toolStrip2.Visible = false;
                toolStrip4.Visible = false;
                guna2Panel6.Visible = false;
                guna2DataGridView4.Visible = false;
                guna2DataGridView3.Visible = false;
                toolStrip3.Visible = false;
                guna2Button16.Visible = false;
                listBox4.Visible = false;
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
                guna2DataGridView1.Visible = false;
                guna2Panel4.Visible = false;
                guna2DataGridView2.Visible = false;
                toolStrip1.Visible = false;
                toolStrip2.Visible = false;
                listBox4.Visible = false;
                toolStrip4.Visible = false;
                guna2Panel5.Visible = false;
                guna2DataGridView4.Visible = false;
                guna2DataGridView3.Visible = false;
                toolStrip3.Visible = false;
                guna2Button16.Visible = false;
                guna2Panel6.Visible = false;
                listBox4.Visible = false;
                guna2Panel7.Visible = false;
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
                guna2DataGridView1.Visible = false;
                guna2Panel4.Visible = false;
                guna2Panel5.Visible = false;
                guna2DataGridView2.Visible = false;
                toolStrip1.Visible = false;
                toolStrip2.Visible = false;
                toolStrip4.Visible = false;
                guna2Panel6.Visible = false;
                guna2DataGridView4.Visible = false;
                listBox4.Visible = false;
                guna2DataGridView3.Visible = false;
                toolStrip3.Visible = false;
                guna2Panel7.Visible = false;
                guna2Button16.Visible = false;
                listBox4.Visible = false;
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
                guna2DataGridView1.Visible = false;
                guna2Panel4.Visible = false;
                guna2DataGridView2.Visible = false;
                toolStrip1.Visible = false;
                listBox4.Visible = false;
                guna2Panel5.Visible = false;
                guna2Panel6.Visible = false;
                guna2Button16.Visible = false;
                toolStrip4.Visible = false;
                guna2Panel7.Visible = false;
                guna2DataGridView4.Visible = false;
                guna2DataGridView3.Visible = false;
                toolStrip3.Visible = false;
                toolStrip2.Visible = false;
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
            if (SaveData.LVLC == 1)//клиент
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
                    guna2Panel6.Visible = false;
                    guna2Panel5.Visible = false;
                    guna2DataGridView2.Visible = false;
                    toolStrip1.Visible = false;
                    listBox4.Visible = false;
                    listBox4.Visible = false;
                    toolStrip2.Visible = false;
                    toolStrip4.Visible = false;
                    guna2DataGridView4.Visible = false;
                    guna2DataGridView3.Visible = false;
                    toolStrip3.Visible = false;
                    guna2Panel7.Visible = false;
                    guna2Button8.Visible = true;
                    guna2Button9.Visible = true;
                    guna2Button16.Visible = true;
                }

                else
                {
                    guna2Button16.Visible = true;
                    guna2Button9.Visible = true;
                }
            }
            if (SaveData.LVLe == 2)//сотрудник
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
                    guna2Button8.Visible = false;
                    guna2Panel5.Visible = false;
                    guna2Panel6.Visible = false;
                    guna2DataGridView2.Visible = false;
                    toolStrip1.Visible = false;
                    listBox4.Visible = false;
                    toolStrip2.Visible = false;
                    listBox4.Visible = false;
                    toolStrip4.Visible = false;
                    guna2DataGridView4.Visible = false;
                    guna2DataGridView3.Visible = false;
                    toolStrip3.Visible = false;
                    guna2Button8.Visible = false;
                    guna2Button9.Visible = true;
                    guna2Button16.Visible = true;
                }

                else
                {
                    guna2Button9.Visible = true;
                    guna2Button16.Visible = true;
                }
            }
            if (SaveData.LVLe == 3) //админ
            {
                if (guna2Button8.Visible == false && guna2Button9.Visible == false)
                {
                    listBox1.Visible = false;
                    guna2PictureBox2.Visible = false;
                    guna2PictureBox3.Visible = false;
                    listBox2.Visible = false;
                    guna2Button7.Visible = false;
                    guna2Panel4.Visible = false;
                    toolStrip1.Visible = false;
                    listBox4.Visible = false;
                    guna2Panel5.Visible = false;
                    guna2Panel6.Visible = false;
                    toolStrip4.Visible = false;
                    guna2DataGridView4.Visible = false;
                    guna2DataGridView3.Visible = false;
                    toolStrip3.Visible = false;
                    guna2DataGridView1.Visible = false;
                    toolStrip1.Visible = false;
                    guna2DataGridView2.Visible = false;
                    toolStrip2.Visible = false;
                    guna2Button8.Visible = true;
                    guna2Button9.Visible = true;
                    guna2Button16.Visible = true;
                }

                else
                {
                    guna2Button8.Visible = true;
                    guna2Button9.Visible = true;
                    guna2Button16.Visible = true;

                }
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
                guna2DataGridView2.Visible = false;
                toolStrip1.Visible = false;
                toolStrip2.Visible = false;
                listBox4.Visible = false;
                guna2DataGridView3.Visible = false;
                toolStrip3.Visible = false;
                toolStrip4.Visible = false;
                guna2Panel7.Visible = false;
                guna2DataGridView4.Visible = false;
                guna2Button16.Visible = true;
                guna2Button8.Visible = true;
                guna2Panel4.Visible = true;
                listBox4.Visible = false;
            }

            else
            {
                guna2Panel4.Visible = true;
            }
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView3.Visible == false)
            {
                listBox1.Visible = false;
                guna2PictureBox2.Visible = false;
                guna2PictureBox3.Visible = false;
                listBox2.Visible = false;
                guna2Button7.Visible = false;
                guna2Panel4.Visible = false;
                guna2DataGridView1.Visible = false;
                guna2DataGridView2.Visible = false;
                toolStrip1.Visible = false;
                toolStrip2.Visible = false;
                guna2Panel7.Visible = false;
                guna2DataGridView3.Visible = false;
                toolStrip3.Visible = false;
                toolStrip4.Visible = true;
                guna2DataGridView4.Visible = true;
                listBox4.Visible = true;
            }

            else
            {
                toolStrip4.Visible = true;
                guna2DataGridView4.Visible = true;
                listBox4.Visible = true;
            }
            guna2DataGridView4.Rows.Clear();
            ClaimTable4();
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

            MySqlCommand command = new MySqlCommand("INSERT INTO `Claim` (`idAC`, `FIO`, `Telephone`, `AddressIncidents`, `DoI`, `DataReport`, `RS`) VALUES (@I, @F, @T, @A, @D, @DR, @uRS)", connection.GetConnection());
            string IDK = SaveData.IDC.ToString();
            //string DATA = DateTime.Now.ToString();
            command.Parameters.Add("@I", MySqlDbType.VarChar).Value = IDK;
            command.Parameters.Add("@F", MySqlDbType.VarChar).Value = guna2TextBox1.Text;
            command.Parameters.Add("@T", MySqlDbType.VarChar).Value = guna2TextBox4.Text;
            command.Parameters.Add("@A", MySqlDbType.VarChar).Value = guna2TextBox5.Text;
            command.Parameters.Add("@D", MySqlDbType.VarChar).Value = guna2TextBox2.Text;
            command.Parameters.Add("@DR", MySqlDbType.VarChar).Value = DateTime.Now;
            command.Parameters.Add("@uRS", MySqlDbType.VarChar).Value = "Незавершён";
            if (command.ExecuteNonQuery() == 1)
            {
                listBox3.Items.Clear();
                listBox3.Items.Add("Заявка отправлена на рассмотрение");
            }
            else
            {
                listBox3.Items.Clear();
                listBox3.Items.Add("Ошибка, обратитесь в тех.поддержку");
            }
            connection.closeConnection();
            guna2TextBox1.Text = "";
            guna2TextBox2.Text = "";
            guna2TextBox4.Text = "";
            guna2TextBox5.Text = "";
        }
        private void ClaimTable()
        {
            DBconnect connection = new DBconnect();
            connection.openConnection();

            MySqlCommand command0 = new MySqlCommand("SELECT *, Claim.IDR, Claim.idAC, Claim.FIO, Claim.Telephone, Claim.AddressIncidents, Claim.DoI, Claim.DataReport, Claim.RS FROM Claim", connection.GetConnection());
            MySqlDataReader reader0 = command0.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader0.Read())
            {
                data.Add(new string[8]);

                data[data.Count - 1][0] = reader0[0].ToString();
                data[data.Count - 1][1] = reader0[1].ToString();
                viemlvl = Convert.ToInt32(reader0[1]);
                data[data.Count - 1][2] = reader0[2].ToString();
                data[data.Count - 1][3] = reader0[3].ToString();
                data[data.Count - 1][4] = reader0[4].ToString();
                data[data.Count - 1][5] = reader0[5].ToString();
                data[data.Count - 1][6] = reader0[6].ToString();
                data[data.Count - 1][7] = reader0[7].ToString();
            }
            reader0.Close();
            connection.closeConnection();
            if (SaveData.LVLC == 1)
            {
                if (viemlvl == SaveData.IDC)
                {
                    foreach (string[] s in data)
                        guna2DataGridView2.Rows.Add(s);
                    int rows = guna2DataGridView2.Rows.Count;
                    toolStripLabel2.Text = Convert.ToString(rows);

                    for (int i = 0; i < guna2DataGridView2.RowCount - 1; i++)
                    { // если в таблице больше одной записи (первая - это наименования столбцов)
                        if (guna2DataGridView2.RowCount > 1)
                        {

                            int QuanityValue = Convert.ToInt32(guna2DataGridView2.Rows[i].Cells[1].Value);
                            if (QuanityValue != viemlvl)
                            {
                                guna2DataGridView2.Rows.RemoveAt(i);
                                i--;
                            }
                        }
                    }

                }
            }
            if (SaveData.LVLe > 1)
            {
                foreach (string[] s in data)
                    guna2DataGridView2.Rows.Add(s);
                int rows = guna2DataGridView2.Rows.Count;
                toolStripLabel2.Text = Convert.ToString(rows);
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
            if (guna2TextBox4.PlaceholderText == "Номер телефона")
            {
                guna2TextBox4.PlaceholderText = "89123456789";
            }
            if (guna2TextBox5.PlaceholderText == "Адрес")
            {
                guna2TextBox5.PlaceholderText = "Двинская 3";
            }
            if (guna2TextBox2.PlaceholderText == "Текст обращения")
            {
                guna2TextBox2.PlaceholderText = "Что случилось";
            }
            else
            {
                listBox3.Items.Clear();
                listBox3.Items.Add("Режим подсказок выключен");
                guna2TextBox1.PlaceholderText = "ФИО";
                guna2TextBox4.PlaceholderText = "Номер телефона";
                guna2TextBox5.PlaceholderText = "Адрес";
                guna2TextBox2.PlaceholderText = "Текст обращения";
            }

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {

        }
        private void guna2Button16_Click(object sender, EventArgs e)
        {

            if (guna2DataGridView2.Visible == false && toolStrip1.Visible == false)
            {
                listBox1.Visible = false;
                guna2PictureBox2.Visible = false;
                guna2PictureBox3.Visible = false;
                listBox2.Visible = false;
                guna2Button7.Visible = false;
                guna2DataGridView1.Visible = false;
                guna2Panel4.Visible = false;
                toolStrip2.Visible = false;
                guna2Panel7.Visible = false;
                guna2DataGridView3.Visible = false;
                toolStrip3.Visible = false;
                guna2Button9.Visible = true;
                toolStrip4.Visible = false;
                guna2DataGridView4.Visible = false;
                guna2DataGridView2.Visible = true;
                guna2DataGridView3.Visible = false;
                toolStrip1.Visible = true;
                listBox4.Visible = true;
            }

            else
            {
                guna2DataGridView2.Visible = true;
                toolStrip1.Visible = true;
                listBox4.Visible = true;
                guna2Button9.Visible = true;

            }
            guna2DataGridView2.Rows.Clear();
            ClaimTable();
        }
        //////////////////////////////////////////////////// ДатаГрид отвечающий за список всех заявок
        public void guna2DataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                guna2DataGridView2.CurrentCell = guna2DataGridView2[e.ColumnIndex, e.RowIndex];
            }
            guna2DataGridView2.CurrentRow.Selected = true;
            GetSelectedIDString();
        }
        public void GetSelectedIDString()
        {
            //Переменная для индекс выбранной строки в гриде
            string index_selected_rows;
            index_selected_rows = guna2DataGridView2.SelectedCells[1].RowIndex.ToString();
            id_selected_rows = guna2DataGridView2.Rows[Convert.ToInt32(index_selected_rows)].Cells[1].Value.ToString();
            toolStripLabel6.Text = id_selected_rows;
            SaveData.ID_Client = id_selected_rows;
            //Индекс выбранной строки
            index_selected_rows = guna2DataGridView2.SelectedCells[0].RowIndex.ToString();
            //ID конкретной записи в Базе данных, на основании индекса строки
            id_selected_rows = guna2DataGridView2.Rows[Convert.ToInt32(index_selected_rows)].Cells[0].Value.ToString();
            //Указываем ID выделенной строки в метке
            toolStripLabel3.Text = id_selected_rows;
            SaveData.ID_Claim = id_selected_rows;
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            guna2DataGridView2.Rows.Clear();
            ClaimTable();
            toolStripComboBox1.SelectedIndex = -1;
            listBox4.Items.Clear();
            listBox4.Items.Add("Данные обновлены");
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            DBconnect connection = new DBconnect();
            connection.openConnection();
            MySqlCommand command77 = new MySqlCommand("DELETE FROM Claim WHERE IDR = @uIDR", connection.GetConnection());
            if (SaveData.ID_Claim != null)
            {
                command77.Parameters.Add("@uIDR", MySqlDbType.VarChar).Value = SaveData.ID_Claim;
                command77.ExecuteNonQuery();
                listBox4.Items.Clear();
                listBox4.Items.Add($"Вы удалили заявку клиента под номером - {SaveData.ID_Claim}");
                guna2DataGridView2.Rows.Clear();
                ClaimTable();
            }
            else
            {
                listBox4.Items.Clear();
                listBox4.Items.Add("Выберете какой пункт хотите удалить");
            }
            connection.closeConnection();
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Clear();
            ClaimTable2();
            listBox4.Items.Clear();
            listBox4.Items.Add("Данные обновлены");
        }
        private void ClaimTable2()
        {
            DBconnect connection = new DBconnect();
            connection.openConnection();

            MySqlCommand command1 = new MySqlCommand("SELECT * FROM Client", connection.GetConnection());
            MySqlDataReader reader1 = command1.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader1.Read())
            {
                data.Add(new string[5]);

                data[data.Count - 1][0] = reader1[0].ToString();
                data[data.Count - 1][1] = reader1[1].ToString();
                data[data.Count - 1][2] = reader1[2].ToString();
                data[data.Count - 1][3] = reader1[3].ToString();
                data[data.Count - 1][4] = reader1[4].ToString();
            }
            reader1.Close();
            connection.closeConnection();
            foreach (string[] s in data)
                guna2DataGridView1.Rows.Add(s);
            int rows = guna2DataGridView1.Rows.Count;
            toolStripLabel8.Text = Convert.ToString(rows);
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.Visible == false && toolStrip2.Visible == false)
            {
                listBox1.Visible = false;
                guna2PictureBox2.Visible = false;
                guna2PictureBox3.Visible = false;
                listBox2.Visible = false;
                guna2Button7.Visible = false;
                guna2DataGridView1.Visible = false;
                guna2Panel4.Visible = false;
                guna2DataGridView2.Visible = false;
                guna2DataGridView3.Visible = false;
                toolStrip1.Visible = false;
                guna2Panel5.Visible = false;
                guna2DataGridView3.Visible = false;
                toolStrip3.Visible = false;
                guna2Panel6.Visible = false;
                guna2Button8.Visible = false;
                guna2Button9.Visible = false;
                guna2Button16.Visible = false;
                toolStrip4.Visible = false;
                guna2DataGridView4.Visible = false;
                guna2DataGridView1.Visible = true;
                toolStrip2.Visible = true;
                listBox4.Visible = true;
            }

            else
            {
                guna2DataGridView1.Visible = true;
                toolStrip2.Visible = true;
                listBox4.Visible = true;
            }

        }
        public void GetSelectedIDString1()
        {
            //Переменная для индекс выбранной строки в гриде
            string index_selected_rows2;
            index_selected_rows2 = guna2DataGridView1.SelectedCells[1].RowIndex.ToString();
            id_selected_rows2 = guna2DataGridView1.Rows[Convert.ToInt32(index_selected_rows2)].Cells[1].Value.ToString();
            toolStripLabel10.Text = id_selected_rows2;
            SaveData.ID_idAC = id_selected_rows2;
        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            DBconnect connection = new DBconnect();
            connection.openConnection();
            MySqlCommand command88_1 = new MySqlCommand("DELETE FROM Client WHERE idAC = @uAD", connection.GetConnection());
            MySqlCommand command88_2 = new MySqlCommand("DELETE FROM ALP WHERE idAC = @uAD", connection.GetConnection());
            int idc = Convert.ToInt32(SaveData.IDC);
            if (SaveData.IDC != idc)
            {
                if (SaveData.ID_idAC != null)
                {
                    command88_1.Parameters.Add("@uAD", MySqlDbType.VarChar).Value = SaveData.ID_idAC;
                    command88_2.Parameters.Add("@uAD", MySqlDbType.VarChar).Value = SaveData.ID_idAC;
                    command88_1.ExecuteNonQuery();
                    command88_2.ExecuteNonQuery();
                    listBox4.Items.Clear();
                    listBox4.Items.Add($"Вы удалили учётку клиента под номером айди - {SaveData.ID_idAC}");
                    guna2DataGridView1.Rows.Clear();
                    ClaimTable2();
                }
                else
                {
                    listBox4.Items.Clear();
                    listBox4.Items.Add("Выберете клиента, учётку которого хотите удалить");
                }
            }
            else
            {
                listBox4.Items.Clear();
                listBox4.Items.Add("Вы не можете удалить свою же учётную запись");
            }
            connection.closeConnection();
        }




        private void guna2DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                guna2DataGridView1.CurrentCell = guna2DataGridView1[e.ColumnIndex, e.RowIndex];
            }
            guna2DataGridView1.CurrentRow.Selected = true;
            GetSelectedIDString1();
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView3.Visible == false && toolStrip3.Visible == false)
            {
                listBox1.Visible = false;
                guna2PictureBox2.Visible = false;
                guna2PictureBox3.Visible = false;
                listBox2.Visible = false;
                guna2Button7.Visible = false;
                guna2DataGridView1.Visible = false;
                guna2Panel4.Visible = false;
                guna2DataGridView2.Visible = false;
                toolStrip1.Visible = false;
                guna2Panel5.Visible = false;
                toolStrip2.Visible = false;
                guna2Panel6.Visible = false;
                guna2Button8.Visible = false;
                guna2Button9.Visible = false;
                guna2Button16.Visible = false;
                toolStrip4.Visible = false;
                guna2DataGridView4.Visible = false;
                guna2DataGridView3.Visible = true;
                toolStrip3.Visible = true;
                listBox4.Visible = true;
            }

            else
            {
                guna2DataGridView3.Visible = true;
                toolStrip3.Visible = true;
                listBox4.Visible = true;
            }
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            guna2TextBox10.Text = "";
            guna2TextBox7.Text = "";
            guna2TextBox3.Text = "";
            guna2TextBox12.Text = "";
            guna2TextBox6.Text = "";
            guna2TextBox9.Text = "";
            guna2TextBox8.Text = "";
            guna2TextBox10.PlaceholderText = "ФИО";
            guna2TextBox7.PlaceholderText = "Номер телефона";
            guna2TextBox3.PlaceholderText = "Адресс проживания";
            guna2TextBox12.PlaceholderText = "ИНН";
            guna2TextBox6.PlaceholderText = "Логин";
            guna2TextBox9.PlaceholderText = "Пароль";
            guna2TextBox8.PlaceholderText = "Повторите пароль";
            guna2ComboBox1.SelectedIndex = -1;
            guna2ComboBox2.SelectedIndex = -1;
            guna2ComboBox3.SelectedIndex = -1;
            if (guna2DataGridView3.Visible == true && toolStrip3.Visible == true)
            {
                guna2DataGridView3.Visible = false;
                toolStrip3.Visible = false;
                guna2Panel5.Visible = true;
            }
            else
            {
                guna2DataGridView3.Visible = false;
                toolStrip3.Visible = false;
                guna2Panel5.Visible = true;
            }
        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            if (guna2Panel5.Visible == true)
            {
                guna2Panel5.Visible = false;
                guna2DataGridView3.Visible = true;
                toolStrip3.Visible = true;
            }
            else
            {
                guna2Panel5.Visible = true;
            }
            guna2TextBox10.Text = "";
            guna2TextBox7.Text = "";
            guna2TextBox3.Text = "";
            guna2TextBox12.Text = "";
            guna2TextBox6.Text = "";
            guna2TextBox9.Text = "";
            guna2TextBox8.Text = "";
            guna2TextBox10.PlaceholderText = "ФИО";
            guna2TextBox7.PlaceholderText = "Номер телефона";
            guna2TextBox3.PlaceholderText = "Адресс проживания";
            guna2TextBox12.PlaceholderText = "ИНН";
            guna2TextBox6.PlaceholderText = "Логин";
            guna2TextBox9.PlaceholderText = "Пароль";
            guna2TextBox8.PlaceholderText = "Повторите пароль";
            guna2ComboBox1.SelectedIndex = -1;
            guna2ComboBox2.SelectedIndex = -1;
            guna2ComboBox3.SelectedIndex = -1;
            guna2DataGridView3.Rows.Clear();
            ClaimTable3();
        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {
            if (guna2TextBox10.Text == "")
            {
                guna2TextBox10.PlaceholderText = "Введите фио сотрудника";
                guna2TextBox10.PlaceholderForeColor = Color.Red;
                return;
            }
            if (guna2TextBox7.Text == "")
            {
                guna2TextBox7.PlaceholderText = "Введите номер телефона";
                guna2TextBox7.PlaceholderForeColor = Color.Red;
                return;
            }
            if (guna2TextBox7.TextLength < 11)
            {
                if (listBox4.Items.Contains("Длина телефона меньше допустимой. Минимальная длина 11 символов.") == false)
                {
                    listBox4.Items.Clear();
                    listBox4.Items.Add("Длина телефона меньше 11 символов.");
                    return;
                }
            }
            if (guna2TextBox3.Text == "")
            {
                guna2TextBox3.PlaceholderText = "Введите адресс";
                guna2TextBox3.PlaceholderForeColor = Color.Red;
                return;
            }
            if (guna2ComboBox1.Text == "")
            {
                listBox4.Items.Clear();
                listBox4.Items.Add("Выберите день рождения");
                return;
            }
            else
            {
                if (guna2ComboBox1.Text == "1")
                {
                    SaveData.day = "01";
                }
                if (guna2ComboBox1.Text == "2")
                {
                    SaveData.day = "02";
                }
                if (guna2ComboBox1.Text == "3")
                {
                    SaveData.day = "03";
                }
                if (guna2ComboBox1.Text == "4")
                {
                    SaveData.day = "04";
                }
                if (guna2ComboBox1.Text == "5")
                {
                    SaveData.day = "05";
                }
                if (guna2ComboBox1.Text == "6")
                {
                    SaveData.day = "06";
                }
                if (guna2ComboBox1.Text == "7")
                {
                    SaveData.day = "07";
                }
                if (guna2ComboBox1.Text == "8")
                {
                    SaveData.day = "08";
                }
                if (guna2ComboBox1.Text == "9")
                {
                    SaveData.day = "09";
                }
                if (guna2ComboBox1.Text != "1" && guna2ComboBox1.Text != "2" && guna2ComboBox1.Text != "3" && guna2ComboBox1.Text != "4" && guna2ComboBox1.Text != "5" && guna2ComboBox1.Text != "6" && guna2ComboBox1.Text != "7" && guna2ComboBox1.Text != "8" && guna2ComboBox1.Text != "9")
                {
                    SaveData.day = guna2ComboBox1.Text;
                }
            }
            if (guna2ComboBox2.Text == "")
            {
                listBox4.Items.Clear();
                listBox4.Items.Add("Выберите месяц рождения");
                return;
            }
            else
            {
                if (guna2ComboBox2.Text == "Январь")
                {
                    SaveData.month = "01";
                }
                if (guna2ComboBox2.Text == "Февраль")
                {
                    SaveData.month = "02";
                }
                if (guna2ComboBox2.Text == "Март")
                {
                    SaveData.month = "03";
                }
                if (guna2ComboBox2.Text == "Апрель")
                {
                    SaveData.month = "04";
                }
                if (guna2ComboBox2.Text == "Май")
                {
                    SaveData.month = "05";
                }
                if (guna2ComboBox2.Text == "Июнь")
                {
                    SaveData.month = "06";
                }
                if (guna2ComboBox2.Text == "Июль")
                {
                    SaveData.month = "07";
                }
                if (guna2ComboBox2.Text == "Август")
                {
                    SaveData.month = "08";
                }
                if (guna2ComboBox2.Text == "Сентябрь")
                {
                    SaveData.month = "09";
                }
                if (guna2ComboBox2.Text == "Октябрь")
                {
                    SaveData.month = "10";
                }
                if (guna2ComboBox2.Text == "Ноябрь")
                {
                    SaveData.month = "11";
                }
                if (guna2ComboBox2.Text == "Декабрь")
                {
                    SaveData.month = "12";
                }
            }
            if (guna2ComboBox3.Text == "")
            {
                listBox4.Items.Clear();
                listBox4.Items.Add("Выберите год рождения");
                return;
            }
            if (guna2TextBox12.Text == "")
            {
                guna2TextBox12.PlaceholderText = "Введите ИНН";
                guna2TextBox12.PlaceholderForeColor = Color.Red;
                return;
            }
            if (guna2TextBox12.TextLength < 12)
            {
                if (listBox4.Items.Contains("Длина ИНН меньше допустимой. Минимальная длина 12 символов.") == false)
                {
                    listBox4.Items.Clear();
                    listBox4.Items.Add("Длина ИНН меньше 12 символов.");
                    return;
                }
            }
            if (guna2TextBox6.Text == "")
            {
                guna2TextBox6.PlaceholderText = "Введите логин сотрудника";
                guna2TextBox6.PlaceholderForeColor = Color.Red;
                return;
            }

            if (guna2TextBox9.Text == "")
            {
                guna2TextBox9.PlaceholderText = "Введите пароль";
                guna2TextBox9.PlaceholderForeColor = Color.Red;
                return;
            }
            else if (guna2TextBox8.Text == "")
            {
                guna2TextBox8.PlaceholderText = "Введите повторный пароль";
                guna2TextBox8.PlaceholderForeColor = Color.Red;
                return;
            }

            if (checkUser1())
                return;

            DBconnect connection = new DBconnect();
            connection.openConnection();

            MySqlCommand command = new MySqlCommand("INSERT INTO `ALP` (`login`, `pass`, `lvl`) VALUES (@uL, @uP, @uLV)", connection.GetConnection());


            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = guna2TextBox6.Text;
            command.Parameters.Add("@uLV", MySqlDbType.VarChar).Value = 2;
            if (guna2TextBox9.Text == guna2TextBox6.Text)
            {
                if (listBox4.Items.Contains("Пароль и логин не могут быть одинаковыми") == false)
                {
                    listBox4.Items.Clear();
                    listBox4.Items.Add("Пароль и логин не могут быть одинаковыми");
                }
                return;

            }
            else if (guna2TextBox9.Text == guna2TextBox8.Text)
            {
                command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = guna2TextBox9.Text;
            }
            else
            {
                if (listBox4.Items.Contains("Ведённые пароли не совпадают") == false)
                {
                    listBox4.Items.Clear();
                    listBox4.Items.Add("Ведённые пароли не совпадают");
                }
                return;
            }
            if (command.ExecuteNonQuery() == 1)
            {
                MySqlCommand command3 = new MySqlCommand("SELECT MAX(`idAC`) FROM `ALP`", connection.GetConnection());
                string test = command3.ExecuteScalar().ToString();

                MySqlCommand command2 = new MySqlCommand("INSERT INTO Employee (idAC, FIO, Telephone, Address, DoB, INN) VALUES (@1, @2, @3, @4, @5, @6)", connection.GetConnection());
                command2.Parameters.Add("@1", MySqlDbType.VarChar).Value = test;

                if (guna2TextBox10.Text == "" ^ guna2TextBox10.Text.Any(char.IsDigit))
                {
                    MessageBox.Show("Ваше имя не должно содержать цифр или любых других знаков!");
                    return;
                }
                else
                {
                    command2.Parameters.Add("@2", MySqlDbType.VarChar).Value = guna2TextBox10.Text;
                }

                command2.Parameters.Add("@3", MySqlDbType.VarChar).Value = guna2TextBox7.Text;
                command2.Parameters.Add("@4", MySqlDbType.VarChar).Value = guna2TextBox3.Text;
                string year = guna2ComboBox3.Text;
                year = year.Substring(2);
                string data1 = $"{SaveData.day}.{SaveData.month}.{year}";
                command2.Parameters.Add("@5", MySqlDbType.VarChar).Value = data1;

                command2.Parameters.Add("@6", MySqlDbType.VarChar).Value = guna2TextBox12.Text;
                command2.ExecuteNonQuery();
                listBox4.Items.Clear();
                listBox4.Items.Add("Аккаунт сотрудника создан");
                guna2TextBox10.Text = "";
                guna2TextBox7.Text = "";
                guna2TextBox3.Text = "";
                guna2TextBox12.Text = "";
                guna2TextBox6.Text = "";
                guna2TextBox9.Text = "";
                guna2TextBox8.Text = "";
            }
            else
            {
                listBox4.Items.Clear();
                listBox4.Items.Add("Произошла ошибка сервера");
                return;
            }
            connection.closeConnection();

            guna2TextBox10.PlaceholderText = "ФИО";
            guna2TextBox7.PlaceholderText = "Номер телефона";
            guna2TextBox3.PlaceholderText = "Адресс проживания";
            guna2TextBox12.PlaceholderText = "ИНН";
            guna2TextBox6.PlaceholderText = "Логин";
            guna2TextBox9.PlaceholderText = "Пароль";
            guna2TextBox8.PlaceholderText = "Повторите пароль";
            guna2ComboBox1.SelectedIndex = -1;
            guna2ComboBox2.SelectedIndex = -1;
            guna2ComboBox3.SelectedIndex = -1;
        }
        public Boolean checkUser1()
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
                listBox4.Items.Clear();
                listBox4.Items.Add("Логин уже занят");
                return true;
            }
            else //аккаунт создан
            {
                return false;
            }
        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked == true) // если свич активирован, символы скрываются системным символом пароля 
            {
                guna2TextBox9.UseSystemPasswordChar = true;
            }
            else if (guna2ToggleSwitch1.Checked == false) // если не активирован, то всё по дефолту
            {
                guna2TextBox9.UseSystemPasswordChar = false;
            }
            if (guna2ToggleSwitch1.Checked == true) // если свич активирован, символы скрываются системным символом пароля 
            {
                guna2TextBox8.UseSystemPasswordChar = true;
            }
            else if (guna2ToggleSwitch1.Checked == false) // если не активирован, то всё по дефолту
            {
                guna2TextBox8.UseSystemPasswordChar = false;
            }
        }

        private void guna2TextBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != ' ')
            {
                e.Handled = true;
            }
        }

        private void guna2TextBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void guna2TextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == '!' || e.KeyChar == '.' || e.KeyChar == '(' || e.KeyChar == ')' || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void guna2TextBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == '!' || e.KeyChar == '.' || e.KeyChar == '(' || e.KeyChar == ')' || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void guna2TextBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == '!' || e.KeyChar == '.' || e.KeyChar == '(' || e.KeyChar == ')' || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void guna2TextBox9_TextChanged_1(object sender, EventArgs e)
        {
            if (guna2TextBox9.Text != "")
            {
                guna2ToggleSwitch1.Visible = true;
            }
            else if (guna2TextBox9.Text == "")
            {
                guna2ToggleSwitch1.Visible = false;
                guna2ToggleSwitch1.Checked = true;
            }
        }
        private void guna2TextBox8_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox8.Text != "")
            {
                guna2ToggleSwitch1.Visible = true;
            }
            else if (guna2TextBox8.Text == "")
            {
                guna2ToggleSwitch1.Visible = false;
                guna2ToggleSwitch1.Checked = true;
            }
        }
        private void ClaimTable3()
        {
            DBconnect connection = new DBconnect();
            connection.openConnection();

            MySqlCommand command00 = new MySqlCommand("SELECT * FROM Employee", connection.GetConnection());
            MySqlDataReader reader00 = command00.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader00.Read())
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = reader00[0].ToString();
                data[data.Count - 1][1] = reader00[1].ToString();
                data[data.Count - 1][2] = reader00[2].ToString();
                data[data.Count - 1][3] = reader00[3].ToString();
                data[data.Count - 1][4] = reader00[4].ToString();
                data[data.Count - 1][5] = reader00[5].ToString();
                data[data.Count - 1][6] = reader00[6].ToString();
            }
            reader00.Close();
            connection.closeConnection();
            foreach (string[] s in data)
                guna2DataGridView3.Rows.Add(s);
            int rows = guna2DataGridView3.Rows.Count;
            toolStripLabel12.Text = Convert.ToString(rows);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            guna2DataGridView3.Rows.Clear();
            ClaimTable3();
            listBox4.Items.Clear();
            listBox4.Items.Add("Данные обновлены");
        }

        public void GetSelectedIDString3()
        {
            //Переменная для индекс выбранной строки в гриде
            string index_selected_rows3;
            index_selected_rows3 = guna2DataGridView3.SelectedCells[1].RowIndex.ToString();
            id_selected_rows3 = guna2DataGridView3.Rows[Convert.ToInt32(index_selected_rows3)].Cells[1].Value.ToString();
            toolStripLabel14.Text = id_selected_rows3;
            SaveData.ID_idAC = id_selected_rows3;
        }
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            DBconnect connection = new DBconnect();
            connection.openConnection();
            MySqlCommand command99_1 = new MySqlCommand("DELETE FROM Employee WHERE idAC = @uAD", connection.GetConnection());
            MySqlCommand command99_2 = new MySqlCommand("DELETE FROM ALP WHERE idAC = @uAD", connection.GetConnection());
            int idc = Convert.ToInt32(SaveData.ID_idAC);
            if (SaveData.IDC != idc)
            {
                if (SaveData.ID_idAC != null)
                {
                    command99_1.Parameters.Add("@uAD", MySqlDbType.VarChar).Value = SaveData.ID_idAC;
                    command99_2.Parameters.Add("@uAD", MySqlDbType.VarChar).Value = SaveData.ID_idAC;
                    command99_1.ExecuteNonQuery();
                    command99_2.ExecuteNonQuery();
                    listBox4.Items.Clear();
                    listBox4.Items.Add($"Вы удалили учётку сотрудника под номером айди - {SaveData.ID_idAC}");
                    guna2DataGridView3.Rows.Clear();
                    ClaimTable3();
                }
                else
                {
                    listBox4.Items.Clear();
                    listBox4.Items.Add("Выберете клиента, учётку которого хотите удалить");
                }
            }
            else
            {
                listBox4.Items.Clear();
                listBox4.Items.Add("Вы не можете удалить свою же учётную запись");
            }
            connection.closeConnection();
        }

        private void guna2DataGridView3_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                guna2DataGridView3.CurrentCell = guna2DataGridView3[e.ColumnIndex, e.RowIndex];
            }
            guna2DataGridView3.CurrentRow.Selected = true;
            GetSelectedIDString3();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            DBconnect connection = new DBconnect(); //Подключение к базе данных с помощью файла Program.CS
            connection.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter(); //Создание адаптера
            MySqlCommand command111 = new MySqlCommand("SELECT * FROM `Comment` WHERE `IDR` = @Ur", connection.GetConnection()); //Создание команды на выборку
            command111.Parameters.Add("@Ur", MySqlDbType.VarChar).Value = SaveData.ID_Claim; //Заменяем шифр из команды на переменные
            adapter.SelectCommand = command111; // адаптер выберает команду "КОММАНД"
            MySqlDataReader reader112 = command111.ExecuteReader();
            List<string[]> data1 = new List<string[]>();
            while (reader112.Read())
            {
                SaveData.testIDR = reader112[1].ToString();
            }
            reader112.Close();
            if (toolStripLabel3.Text == SaveData.testIDR)
            {
                listBox4.Items.Clear();
                listBox4.Items.Add("На данную заявку уже есть ответ");
                return;
            }
            else
            {

                guna2TextBox20.Text = "";
                guna2TextBox17.Text = "";
                guna2TextBox15.Text = "";
                guna2TextBox16.Text = "";
                guna2TextBox14.Text = "";
                listBox5.Items.Clear();
                listBox4.Items.Clear();
                if (SaveData.ID_Claim != null)
                {
                    if (guna2DataGridView2.Visible == true && toolStrip1.Visible == true)
                    {
                        guna2Button8.Visible = false;
                        guna2Button9.Visible = false;
                        guna2Button16.Visible = false;
                        guna2DataGridView2.Visible = false;
                        toolStrip1.Visible = false;
                        listBox4.Visible = true;
                        guna2Panel6.Visible = true;
                    }
                    else
                    {
                        guna2Panel6.Visible = true;
                        listBox4.Visible = true;
                    }
                    MySqlCommand command222 = new MySqlCommand("SELECT * FROM `Claim` WHERE `IDR` = @Ur", connection.GetConnection()); //Создание команды на выборку
                    command222.Parameters.Add("@Ur", MySqlDbType.VarChar).Value = SaveData.ID_Claim; //Заменяем шифр из команды на переменные
                    adapter.SelectCommand = command222; // адаптер выберает команду "КОММАНД"
                    MySqlDataReader reader11 = command222.ExecuteReader();
                    List<string[]> data2 = new List<string[]>();
                    while (reader11.Read())
                    {
                        SaveData.test = reader11[1].ToString();
                        guna2TextBox20.Text = reader11[2].ToString();
                        guna2TextBox17.Text = reader11[3].ToString();
                        guna2TextBox16.Text = reader11[4].ToString();
                        string text = reader11[5].ToString();
                        listBox5.Items.Add($"{text}");
                        guna2TextBox15.Text = reader11[6].ToString();
                    }
                    reader11.Close();
                    connection.closeConnection();

                }
                else
                {
                    listBox4.Items.Clear();
                    listBox4.Items.Add("Вы не выбрали заявку, к которой хотите оставить комментарий");
                }
            }

        }
        private void lst_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            e.Graphics.DrawString(listBox5.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
        }
        private void lst_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            if (listBox5.Items.Count > 0)
            {
                e.ItemHeight = (int)e.Graphics.MeasureString(listBox5.Items[e.Index].ToString(), listBox5.Font, listBox5.Width).Height;
                return;
            }

        }

        private void guna2DataGridView4_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                guna2DataGridView4.CurrentCell = guna2DataGridView4[e.ColumnIndex, e.RowIndex];
            }
            guna2DataGridView4.CurrentRow.Selected = true;
            GetSelectedIDString4();
        }
        public void GetSelectedIDString4()
        {
            //Переменная для индекс выбранной строки в гриде
            string index_selected_rows4;
            index_selected_rows4 = guna2DataGridView4.SelectedCells[3].RowIndex.ToString();
            id_selected_rows4 = guna2DataGridView4.Rows[Convert.ToInt32(index_selected_rows4)].Cells[1].Value.ToString();
            toolStripLabel18.Text = id_selected_rows4;
            SaveData.ID_Employee = id_selected_rows4;
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            guna2DataGridView4.Rows.Clear();
            ClaimTable4();
            listBox4.Items.Clear();
            listBox4.Items.Add("Данные обновлены");
        }
        private void ClaimTable4()
        {
            DBconnect connection = new DBconnect();
            connection.openConnection();

            MySqlCommand command55 = new MySqlCommand("SELECT * FROM Comment", connection.GetConnection());
            MySqlDataReader reader55 = command55.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader55.Read())
            {
                data.Add(new string[7]);

                data[data.Count - 1][0] = reader55[0].ToString();
                data[data.Count - 1][1] = reader55[1].ToString();
                data[data.Count - 1][2] = reader55[2].ToString();
                data[data.Count - 1][3] = reader55[3].ToString();
                data[data.Count - 1][4] = reader55[4].ToString();
                data[data.Count - 1][5] = reader55[5].ToString();
                data[data.Count - 1][6] = reader55[6].ToString();
            }
            reader55.Close();
            connection.closeConnection();
            if (SaveData.LVLC == 1)
            {
                if (viemlvl == SaveData.IDC)
                {
                    foreach (string[] s in data)
                        guna2DataGridView4.Rows.Add(s);
                    int rows = guna2DataGridView4.Rows.Count;
                    toolStripLabel2.Text = Convert.ToString(rows);

                    for (int i = 0; i < guna2DataGridView4.RowCount - 1; i++)
                    { // если в таблице больше одной записи (первая - это наименования столбцов)
                        if (guna2DataGridView4.RowCount > 1)
                        {
                            int QuanityValue = Convert.ToInt32(guna2DataGridView4.Rows[i].Cells[2].Value);
                            if (QuanityValue != viemlvl)
                            {
                                guna2DataGridView4.Rows.RemoveAt(i);
                                i--;
                            }
                        }
                    }

                }
            }
            if (SaveData.LVLe > 1)
            {
                foreach (string[] s in data)
                    guna2DataGridView4.Rows.Add(s);
                int rows = guna2DataGridView4.Rows.Count;
                toolStripLabel2.Text = Convert.ToString(rows);
            }
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            if (guna2TextBox14.Text == "")
            {
                guna2TextBox10.PlaceholderText = "Введите комментарий";
                guna2TextBox10.PlaceholderForeColor = Color.Red;
                return;
            }
            DBconnect connection = new DBconnect();
            connection.openConnection();

            MySqlCommand command222 = new MySqlCommand("INSERT INTO `Comment` (`IDR`, `idAC`, `IDE`, `FIO`, `DataAnswer`, `CommentEmp`) VALUES (@1, @2, @3, @4, @5, @6)", connection.GetConnection());

            string index;
            index = toolStripLabel3.Text;
            command222.Parameters.Add("@1", MySqlDbType.VarChar).Value = index;
            command222.Parameters.Add("@2", MySqlDbType.VarChar).Value = SaveData.test;
            command222.Parameters.Add("@3", MySqlDbType.VarChar).Value = SaveData.IDe;
            command222.Parameters.Add("@4", MySqlDbType.VarChar).Value = SaveData.FIOe;
            command222.Parameters.Add("@5", MySqlDbType.VarChar).Value = DateTime.Now;
            command222.Parameters.Add("@6", MySqlDbType.VarChar).Value = guna2TextBox14.Text;
            command222.ExecuteNonQuery();
            listBox4.Items.Clear();
            listBox4.Items.Add("Вы оставили свой комментарий к данному обращению");
            guna2TextBox14.Text = "";
            MySqlCommand command333 = new MySqlCommand($"UPDATE Claim SET RS = 'Завершен' WHERE IDR = {index};", connection.GetConnection());
            command333.ExecuteNonQuery();
            connection.closeConnection();
        }

        private void guna2Button10_Click_1(object sender, EventArgs e)
        {
            if (guna2Panel6.Visible == true)
            {
                guna2Panel6.Visible = false;
                guna2DataGridView2.Visible = true;
                toolStrip1.Visible = true;
                if (SaveData.LVLe == 2)
                {
                    guna2Button9.Visible = true;
                    guna2Button16.Visible = true;
                }
                if (SaveData.LVLe == 3)
                {
                    guna2Button8.Visible = true;
                    guna2Button9.Visible = true;
                    guna2Button16.Visible = true;
                }
            }
            else
            {
                guna2Panel5.Visible = true;
            }
            guna2TextBox20.Text = "";
            guna2TextBox17.Text = "";
            guna2TextBox15.Text = "";
            guna2TextBox16.Text = "";
            guna2TextBox14.Text = "";
            listBox5.Items.Clear();
            listBox4.Items.Clear();
            guna2DataGridView2.Rows.Clear();
            ClaimTable();
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            guna2DataGridView2.Rows.Clear();
            ClaimTable();

            if (toolStripComboBox1.Text == "Завершённые ")
            {

                for (int i = 0; i < guna2DataGridView2.RowCount; i++)
                { // если в таблице больше одной записи (первая - это наименования столбцов)
                    if (guna2DataGridView2.RowCount >= 1)
                    {

                        string QuanityValue = guna2DataGridView2.Rows[i].Cells[7].Value.ToString();
                        if (QuanityValue != "Завершен")
                        {
                            guna2DataGridView2.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
            else if (toolStripComboBox1.Text == "Незавершённые ")
            {

                for (int i = 0; i < guna2DataGridView2.RowCount; i++)
                { // если в таблице больше одной записи (первая - это наименования столбцов)
                    if (guna2DataGridView2.RowCount >= 1)
                    {

                        string QuanityValue = guna2DataGridView2.Rows[i].Cells[7].Value.ToString();
                        if (QuanityValue != "Незавершён")
                        {
                            guna2DataGridView2.Rows.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            guna2TextBox21.Text = "";
            guna2TextBox22.Text = "";
            guna2TextBox23.Text = "";
            guna2TextBox24.Text = "";
            if (guna2Panel7.Visible == false)
            {
                listBox1.Visible = false;
                guna2PictureBox2.Visible = false;
                guna2PictureBox3.Visible = false;
                listBox2.Visible = false;
                guna2Button7.Visible = false;
                guna2Button9.Visible = false;
                guna2DataGridView1.Visible = false;
                guna2DataGridView2.Visible = false;
                toolStrip1.Visible = false;
                toolStrip2.Visible = false;
                listBox4.Visible = false;
                guna2DataGridView3.Visible = false;
                toolStrip3.Visible = false;
                toolStrip4.Visible = false;
                guna2DataGridView4.Visible = false;
                guna2Button16.Visible = false;
                guna2Button8.Visible = false;
                guna2Panel4.Visible = false;
                listBox4.Visible = true;
                guna2Panel7.Visible = true;
            }

            else
            {
                guna2Panel7.Visible = true;
                listBox4.Visible = true;
            }
            DBconnect connection = new DBconnect();
            connection.openConnection();

            MySqlCommand command99 = new MySqlCommand("SELECT * FROM Client", connection.GetConnection());
            MySqlDataReader reader99 = command99.ExecuteReader();
            List<string[]> data1 = new List<string[]>();
            while (reader99.Read())
            {
                data1.Add(new string[4]);
                int proverka = Convert.ToInt32(reader99[1]);
                if (proverka == SaveData.IDC) 
                {
                    guna2TextBox19.Text = reader99[2].ToString();
                    guna2TextBox13.Text = reader99[3].ToString();
                    guna2TextBox11.Text = reader99[4].ToString();
                }
            }
            reader99.Close();

            MySqlCommand command88 = new MySqlCommand("SELECT * FROM ALP", connection.GetConnection());
            MySqlDataReader reader88 = command88.ExecuteReader();
            List<string[]> data2 = new List<string[]>();
            while (reader88.Read())
            {
                data2.Add(new string[2]);
                int proverka = Convert.ToInt32(reader88[0]);
                if (proverka == SaveData.IDC)
                {
                    guna2TextBox18.Text = reader88[1].ToString();
                }
            }
            reader88.Close();
            connection.closeConnection();
        }

        private void guna2Button22_Click(object sender, EventArgs e)
        {
            if (guna2Panel7.Visible == true)
            {
                guna2Panel7.Visible = false;
                listBox4.Visible = false;
            }
        }

        private void guna2Button21_Click(object sender, EventArgs e)
        {
            if(guna2TextBox21.Text == "" || guna2TextBox22.Text == "" || guna2TextBox23.Text == "" || guna2TextBox24.Text == "")
            {
                listBox4.Items.Clear();
                listBox4.Items.Add("Вы не ввели какие-либо данные");
            }
            DBconnect connection = new DBconnect();
            connection.openConnection();
            string fio_c = guna2TextBox21.Text;
            string tel_c = guna2TextBox22.Text;
            string add_c = guna2TextBox23.Text;
            string log_c = guna2TextBox24.Text;
            if (fio_c != SaveData.FIOC)
            {
                if (fio_c != "")
                {
                    MySqlCommand command99_1 = new MySqlCommand($"UPDATE Client SET FIO = '{fio_c}' WHERE idAC = {SaveData.IDC};", connection.GetConnection());
                    command99_1.ExecuteNonQuery();
                    listBox4.Items.Clear();
                    listBox4.Items.Add("Вы изменили свои данные");
                    guna2TextBox19.Text = fio_c;
                    SaveData.FIOC = fio_c;
                    guna2TextBox21.Text = "";
                }
            }
            else
            {
                listBox4.Items.Clear();
                listBox4.Items.Add("Вы не можете поменять данные на те же самые");
            }
            if (tel_c != SaveData.TELEPHONEC)
            {
                if (tel_c != "")
                {
                    MySqlCommand command99_2 = new MySqlCommand($"UPDATE Client SET Telephone = '{tel_c}' WHERE idAC = {SaveData.IDC};", connection.GetConnection());
                    command99_2.ExecuteNonQuery();
                    listBox4.Items.Clear();
                    listBox4.Items.Add("Вы изменили свои данные");
                    guna2TextBox13.Text = tel_c;
                    SaveData.TELEPHONEC = tel_c;
                    guna2TextBox22.Text = "";
                }
            }
            else
            {
                listBox4.Items.Clear();
                listBox4.Items.Add("Вы не можете поменять данные на те же самые");
            }
            if (add_c != SaveData.ADDRESSC)
            {
                if (add_c != "")
                {
                    MySqlCommand command99_3 = new MySqlCommand($"UPDATE Client SET Address = '{add_c}' WHERE idAC = {SaveData.IDC};", connection.GetConnection());
                    command99_3.ExecuteNonQuery();
                    listBox4.Items.Clear();
                    listBox4.Items.Add("Вы изменили свои данные");
                    guna2TextBox11.Text = add_c;
                    SaveData.ADDRESSC = add_c;
                    guna2TextBox23.Text = "";
                }
            }
            else
            {
                listBox4.Items.Clear();
                listBox4.Items.Add("Вы не можете поменять данные на те же самые");
            }



            DataTable table = new DataTable(); //Создание таблицы
            MySqlDataAdapter adapter = new MySqlDataAdapter(); //Создание адаптера
            MySqlCommand command5 = new MySqlCommand("SELECT * FROM `ALP` WHERE `login` = @Ul", connection.GetConnection()); //Создание команды на выборку
            command5.Parameters.Add("@Ul", MySqlDbType.VarChar).Value = guna2TextBox24.Text; //Заменяем шифр из команды на переменные
            adapter.SelectCommand = command5; // адаптер выберает команду "КОММАНД"
            adapter.Fill(table); // ВЫБОР таблицы , в котором должны быть значения
            if (table.Rows.Count > 0) //Есть значения - выполняется вход
            {
                listBox4.Items.Clear();
                listBox4.Items.Add("Логин уже занят");
            }
            else
            {
                if (log_c != SaveData.LOGINC)
                {
                    if (log_c != "")
                    {
                        MySqlCommand command99_4 = new MySqlCommand($"UPDATE ALP SET login = '{log_c}' WHERE idAC = {SaveData.IDC};", connection.GetConnection());
                        command99_4.ExecuteNonQuery();
                        listBox4.Items.Clear();
                        listBox4.Items.Add("Вы изменили свои данные");
                        label1.Text = log_c;
                        guna2TextBox18.Text = log_c;
                        SaveData.LOGINC = log_c;
                        guna2TextBox24.Text = "";
                    }
                }
                else
                {
                    listBox4.Items.Clear();
                    listBox4.Items.Add("Вы не можете поменять данные на те же самые");
                }
            }
            connection.closeConnection();

        }

        private void guna2Button20_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            guna2TextBox21.Text = "";
            guna2TextBox22.Text = "";
            guna2TextBox23.Text = "";
            guna2TextBox24.Text = "";
            guna2TextBox25.Text = "";
            guna2TextBox26.Text = "";
            guna2TextBox27.Text = "";
            if (guna2Button23.Visible == false)
            {
                guna2Button20.Visible = false;
                guna2Button21.Visible = false;
                guna2TextBox19.Visible = false;
                guna2TextBox11.Visible = false;
                guna2TextBox13.Visible = false;
                guna2TextBox18.Visible = false;
                guna2TextBox21.Visible = false;
                guna2TextBox22.Visible = false;
                guna2TextBox23.Visible = false;
                guna2TextBox24.Visible = false;

                guna2Button23.Visible = true;
                guna2Button24.Visible = true;
                guna2TextBox25.Visible = true;
                guna2TextBox26.Visible = true;
                guna2TextBox27.Visible = true;
            }

            else
            {
                guna2Button23.Visible = true;
                guna2Button24.Visible = true;
                guna2TextBox25.Visible = true;
                guna2TextBox26.Visible = true;
                guna2TextBox27.Visible = true;
            }
        }

        private void guna2Button23_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();
            guna2TextBox21.Text = "";
            guna2TextBox22.Text = "";
            guna2TextBox23.Text = "";
            guna2TextBox24.Text = "";
            if (guna2Button20.Visible == false)
            {
                guna2Button20.Visible = true;
                guna2Button21.Visible = true;
                guna2TextBox19.Visible = true;
                guna2TextBox11.Visible = true;
                guna2TextBox13.Visible = true;
                guna2TextBox18.Visible = true;
                guna2TextBox21.Visible = true;
                guna2TextBox22.Visible = true;
                guna2TextBox23.Visible = true;
                guna2TextBox24.Visible = true;

                guna2Button23.Visible = false;
                guna2Button24.Visible = false;
                guna2TextBox25.Visible = false;
                guna2TextBox26.Visible = false;
                guna2TextBox27.Visible = false;
            }

            else
            {
                guna2Button20.Visible = true;
                guna2Button21.Visible = true;
                guna2TextBox19.Visible = true;
                guna2TextBox11.Visible = true;
                guna2TextBox13.Visible = true;
                guna2TextBox18.Visible = true;
                guna2TextBox21.Visible = true;
                guna2TextBox22.Visible = true;
                guna2TextBox23.Visible = true;
                guna2TextBox24.Visible = true;
            }
        }
        private void guna2Button24_Click(object sender, EventArgs e)
        {
            if (guna2TextBox25.Text == "")
            {
                listBox4.Items.Clear();
                listBox4.Items.Add("Вы не ввели старый пароль");
            }
            if (SaveData.PASSWORDC != PassHide.Hash(guna2TextBox25.Text))
            {
                listBox4.Items.Clear();
                listBox4.Items.Add("Вы ввели неверный старый пароль");
            }
            else
            {
                DBconnect connection = new DBconnect();
                connection.openConnection();
                if (guna2TextBox26.Text == guna2TextBox25.Text)
                {
                    listBox4.Items.Clear();
                    listBox4.Items.Add("Старый и новый пароль совпадают");
                }
                if (guna2TextBox26.Text == guna2TextBox27.Text)
                {
                    string pass_c = guna2TextBox26.Text;
                    MySqlCommand command667 = new MySqlCommand($"UPDATE ALP SET pass = '{PassHide.Hash(pass_c)}' WHERE idAC = {SaveData.IDC};", connection.GetConnection());
                    command667.ExecuteNonQuery();
                    listBox4.Items.Clear();
                    listBox4.Items.Add("Вы поменяли Ваш пароль");
                    SaveData.PASSWORDC = PassHide.Hash(pass_c);
                    guna2TextBox25.Text = "";
                    guna2TextBox26.Text = "";
                    guna2TextBox27.Text = "";
                }
                else
                {
                    listBox4.Items.Clear();
                    listBox4.Items.Add("Ведённые Вами пароли не совпадают");
                }
                connection.closeConnection();
            }

        }

        private void guna2TextBox26_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox26.Text != "")
            {
                guna2ToggleSwitch2.Visible = true;
            }
            else if (guna2TextBox26.Text == "")
            {
                guna2ToggleSwitch2.Visible = false;
                guna2ToggleSwitch2.Checked = true;
            }
        }

        private void guna2TextBox27_TextChanged(object sender, EventArgs e)
        {
            if (guna2TextBox27.Text != "")
            {
                guna2ToggleSwitch2.Visible = true;
            }
            else if (guna2TextBox27.Text == "")
            {
                guna2ToggleSwitch2.Visible = false;
                guna2ToggleSwitch2.Checked = true;
            }
        }

        private void guna2ToggleSwitch2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch2.Checked == true) // если свич активирован, символы скрываются системным символом пароля 
            {
                guna2TextBox26.UseSystemPasswordChar = true;
            }
            else if (guna2ToggleSwitch2.Checked == false) // если не активирован, то всё по дефолту
            {
                guna2TextBox26.UseSystemPasswordChar = false;
            }
            if (guna2ToggleSwitch2.Checked == true) // если свич активирован, символы скрываются системным символом пароля 
            {
                guna2TextBox27.UseSystemPasswordChar = true;
            }
            else if (guna2ToggleSwitch2.Checked == false) // если не активирован, то всё по дефолту
            {
                guna2TextBox27.UseSystemPasswordChar = false;
            }
        }

        private void guna2TextBox19_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != ' ')
            {
                e.Handled = true;
            }
        }

        private void guna2TextBox21_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != ' ')
            {
                e.Handled = true;
            }
        }

        private void guna2TextBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void guna2TextBox22_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void guna2TextBox24_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == '!' || e.KeyChar == '.' || e.KeyChar == '(' || e.KeyChar == ')' || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void guna2TextBox25_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == '!' || e.KeyChar == '.' || e.KeyChar == '(' || e.KeyChar == ')' || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void guna2TextBox26_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == '!' || e.KeyChar == '.' || e.KeyChar == '(' || e.KeyChar == ')' || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void guna2TextBox27_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == '!' || e.KeyChar == '.' || e.KeyChar == '(' || e.KeyChar == ')' || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}