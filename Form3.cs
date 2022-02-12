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
                listBox2.Visible = false;
                guna2Button7.Visible = false;
                guna2PictureBox3.Visible = false;
                guna2Button8.Visible = false;
                guna2Button9.Visible = false;
                guna2Button10.Visible = false;
                guna2Button11.Visible = false;
                guna2DataGridView1.Visible = false;
                guna2Panel4.Visible = false;
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
    }
}
