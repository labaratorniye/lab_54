﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virt_lab_25
{
    public partial class Form1 : Form
    {
        public string name = "123123";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        Form3 metodichka = new Form3();

        Form2 taskList = new Form2();

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
                if (Convert.ToDouble(label2.Text) != 8)
                {
                    if (Convert.ToDouble(label2.Text) == -0.5)
                    {
                        label2.Text = "0,5";
                    }
                    else
                    {
                        label2.Text = Convert.ToString(Convert.ToDouble(label2.Text) + 0.5);
                    }
                }
            PerformEDS();
        }
        
        private void button6_Click(object sender, EventArgs e)
        {

                if (Convert.ToDouble(label2.Text) != -8)
                {
                    if (Convert.ToDouble(label2.Text) == 0.5)
                    {
                        label2.Text = "-0,5";
                    }
                    else
                    {
                        label2.Text = Convert.ToString(Convert.ToDouble(label2.Text) - 0.5);
                    }
                }
            PerformEDS();

        }
        int quantity = 0;


        private void PerformEDS()
        {
            switch (label2.Text)
            {
                case "8":
                    label4.Text = "3,5";
                    break;
                case "7,5":
                    label4.Text = "3,3";
                    break;
                case "7":
                    label4.Text = "3,1";
                    break;
                case "6,5":
                    label4.Text = "2,9";
                    break;
                case "6":
                    label4.Text = "2,7";
                    break;
                case "5,5":
                    label4.Text = "2,5";
                    break;
                case "5":
                    label4.Text = "2,2";
                    break;
                case "4,5":
                    label4.Text = "2,0";
                    break;
                case "4":
                    label4.Text = "1,8";
                    break;
                case "3,5":
                    label4.Text = "1,6";
                    break;
                case "3":
                    label4.Text = "1,4";
                    break;
                case "2,5":
                    label4.Text = "1,2";
                    break;
                case "2":
                    label4.Text = "1,0";
                    break;
                case "1,5":
                    label4.Text = "0,8";
                    break;
                case "1":
                    label4.Text = "0,6";
                    break;
                case "0,5":
                    label4.Text = "0,4";
                    break;
                case "-0,5":
                    label4.Text = "0,0";
                    break;
                case "-1":
                    label4.Text = "-0,2";
                    break;
                case "-1,5":
                    label4.Text = "-0,4";
                    break;
                case "-2":
                    label4.Text = "-0,6";
                    break;
                case "-2,5":
                    label4.Text = "-0,9";
                    break;
                case "-3":
                    label4.Text = "-1,1";
                    break;
                case "-3,5":
                    label4.Text = "-1,3";
                    break;
                case "-4":
                    label4.Text = "-1,5";
                    break;
                case "-4,5":
                    label4.Text = "-1,7";
                    break;
                case "-5":
                    label4.Text = "-1,9";
                    break;
                case "-5,5":
                    label4.Text = "-2,1";
                    break;
                case "-6":
                    label4.Text = "-2,3";
                    break;
                case "-6,5":
                    label4.Text = "-2,5";
                    break;
                case "-7":
                    label4.Text = "-2,7";
                    break;
                case "-7,5":
                    label4.Text = "-2,9";
                    break;
                case "-8":
                    label4.Text = "-3,1";
                    break;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            if (quantity < 8) // проверка на количество измерений 
            {
                bool isThisNumberWasUsed = false;
                int number = dataGridView1.Rows.Add();
                
                    for(int i = 0; i < number; i++)
                    {
                        if (Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value) == Convert.ToDouble(label2.Text))
                        {
                        MessageBox.Show("Вы уже проводили измерения с данной величиной", "Сообщение");
                        isThisNumberWasUsed = true;
                        }
                    }
                if (!isThisNumberWasUsed)
                {
                    quantity++;
                    dataGridView1.Rows[number].Cells[0].Value = quantity;
                    dataGridView1.Rows[number].Cells[1].Value = label2.Text;
                    dataGridView1.Rows[number].Cells[2].Value = label4.Text;
                }
                else
                {
                    dataGridView1.Rows.RemoveAt(number);
                }
            }
            else
            {
                MessageBox.Show("Вы провели максимальное число измерений", "Сообщение");
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            metodichka.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            taskList.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Protocol protocol = new Protocol();
            protocol.fullName = name;
            protocol.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}