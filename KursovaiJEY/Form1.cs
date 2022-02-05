﻿using System;
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
            Form1 reg = new Form1(); //создаёт  переменную форм 1
            Form2 avt = new Form2(); //создаёт переменную форм 2
            avt.ShowDialog(); // открывается форма2 
            reg.ShowDialog(); //открываетсч форм 1
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Hide(); //прятки с форм 1
            Form1 reg = new Form1(); //создаёт  переменную форм 1
            Form3 menu = new Form3(); //создаёт переменную форм 2
            menu.ShowDialog(); // открывается форма2 
            reg.ShowDialog(); //открываетсч форм 1
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
            guna2TextBox2.UseSystemPasswordChar = true; //Загружает для тест бокса при запуске значение 1
        }


    }
}
