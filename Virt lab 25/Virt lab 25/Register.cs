﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virt_lab_25
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void enterRegister_Click(object sender, EventArgs e)
        {
           
           if (checkTextBox())
            {
                string name = textBoxName.Text + " " + textBoxGroup.Text;
                this.Hide();
                Form1 form = new Form1();
                form.Show();
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void closeRegister_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool checkTextBox()
        {
            if ((textBoxName.Text == "") || (textBoxName.Text == null))
            {
                MessageBox.Show("Не заполнены поля");
                return false;
            } else if ((textBoxGroup.Text == "") || (textBoxGroup.Text == null))
            {
                MessageBox.Show("Не заполнены поля");
                return false;
            }
            return true;
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
