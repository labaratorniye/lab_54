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
    //Application.Run(new Register());
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Enabled = false;
        }        
        private void check_Results_Click(object sender, System.EventArgs e)
        {
            // проверка значений в таблице, сначала проверяю 10 измерений или нет, затем что значения T не равны нулю(введены), затем что g == 9.8, если работает то должно выдаваться "всё ок", иначе соответсвующие сообщения
            int j = 0;
            if (dataGridView1.Rows.Count < 10) // проверка на кол-во измерений
            {
                showTextBox("Неверное количество измерений", "Сообщение");
            }
            else
            {
                for (int i = 0; i <= 9; i++) 
                {
                    double a = 0;
                    if (dataGridView1.Rows[i].Cells[4].Value == null) // проверка T
                    {
                    showTextBox("ячейки значений T пусты", "Сообщение");
                    break;
                    }
                    else
                    {
                        if (dataGridView1.Rows[i].Cells[6].Value == null) // проверка g, сначало что не null
                        {

                            showTextBox("ячейки значений g пусты", "Сообщение");
                            break;
                        }
                        else
                        {
                            if (Double.TryParse(dataGridView1.Rows[i].Cells[6].Value.ToString(), out a)) // преобразуем в double 
                            {
                                if ((a >= 9.7) && (a <= 9.9))
                                j++;
                            }
                            else
                            {
                                showTextBox("Не удалось преобразовать", "Сообщение");
                                break;
                            }
                        }
                    }
                }
                if (j == 10) // если всё преобразовалось то соответсвующее сообщение
                {
                    showTextBox("Всё ок", "Сообщение");
                }
                else if (j < 10)
                {
                    showTextBox("Неверные значения g", "Сообщение");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }
        Form3 metodichka = new Form3();
        private void button3_Click(object sender, EventArgs e)
        {
            metodichka.Show();
        }
        Form2 taskList = new Form2();
        private void button5_Click(object sender, EventArgs e)
        {
            taskList.Show();
        }
        double time = 0;
        double period = 1;
        private void button2_Click_1(object sender, EventArgs e)
        {
            int number = dataGridView1.Rows.Add();

            this.Invalidate();
            double g, l, T, t, n=10;
            l = Convert.ToDouble(numericUpDown1.Value)/100;
            Random rand = new Random();
            g = Convert.ToDouble(9.7+rand.NextDouble()*(9.9-9.7));
            g = Math.Round(g, 2);
            T = 2*Math.PI*Math.Sqrt(l / g);
            T = Math.Round(T, 2);
            t = T * n;
            t = Math.Round(t, 2);
            time = t;
            period = T;
            // textBox1.Text = Convert.ToString(t); ?
            dataGridView1.Rows[number].Cells[0].Value = number + 1;  // вписываем номер № действия
            dataGridView1.Rows[number].Cells[1].Value = l; // вписываем длину нити
            dataGridView1.Rows[number].Cells[2].Value = time; // ввод времени t
            dataGridView1.Rows[number].Cells[3].Value = 10; // кол-во колебаний, всегда 10
            dataGridView1.Rows[number].Cells[4].Value = period; // ввод периода T
            if (dataGridView1.Rows[number].Cells[4].Value == null)
                dataGridView1.Rows[number].Cells[5].Value = 0;
            else
            {
                dataGridView1.Rows[number].Cells[5].Value = Math.Pow((double)dataGridView1.Rows[number].Cells[4].Value, 2); // ввод квадрата периода (T^2)
            }
            dataGridView1.Rows[number].Cells[6].Value = g;
            if (!pictureBox1.Enabled)
            {
                pictureBox1.Enabled = true;
                //timer1.Start(); ?
            } else
            {
                pictureBox1.Enabled = false;
                //timer1.Stop(); ?
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        static bool checkNumberText(object number)
        {
            if (!double.TryParse(number.ToString(), out _))
            {
                return (false);
            } else
            {
                return (true);
            }

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (!checkNumberText(dataGridView1[e.ColumnIndex, e.RowIndex].Value))
            {
                MessageBox.Show("Некоректные данные(Формат записи дробей: 1,33)");
                dataGridView1[e.ColumnIndex, e.RowIndex].Value = "";
            }
        }


        private void showTextBox(String message, String description)
        {
            MessageBox.Show(
                   message,
                   description);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = numericUpDown1.Value.ToString();
        }
    }
}