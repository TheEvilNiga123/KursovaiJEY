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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
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
    }
}