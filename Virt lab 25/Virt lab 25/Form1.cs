using System;
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
        }
        public int polojenie = 0;
        
        private void check_Results_Click(object sender, System.EventArgs e)
        {
            // проверка значений в таблице, сначала проверяю 10 измерений или нет, затем что значения T не равны нулю(введены), затем что g == 9.8, если работает то должно выдаваться "всё ок", иначе соответсвующие сообщения
            int j = 0;
            if (dataGridView1.Rows.Count < 10) // проверка на кол-во измерений
            {
                MessageBox.Show(
                    "Неверное количество измерений",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                for (int i = 0; i <= 9; i++) 
                {
                    double a = 0;
                    if (dataGridView1.Rows[i].Cells[4].Value == null) // проверка T
                    {
                    MessageBox.Show(
                    "Неверные значения в столбце T",
                    "Сообщение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                    break;
                    }
                    else
                    {
                        if (dataGridView1.Rows[i].Cells[6].Value == null) // проверка g, сначало что не null
                        {
                            MessageBox.Show(
                            "Неверные значения в столбце g",
                            "Сообщение",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
                            break;
                        }
                        else
                        {
                            if (Double.TryParse(dataGridView1.Rows[i].Cells[6].Value.ToString(), out a)) // преобразуем в double 
                            {
                                if (a == 9.8)
                                j++;
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Не удалось преобразовать",
                                    "Сообщение",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information,
                                    MessageBoxDefaultButton.Button1,
                                    MessageBoxOptions.DefaultDesktopOnly);
                                break;
                            }
                        }
                    }
                }
            }
            if ( j > 9) // если всё преобразовалось то соответсвующее сообщение
            {
                MessageBox.Show(
                "Всё ок",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }
        metodichka metodichka = new metodichka();
        private void button3_Click(object sender, EventArgs e)
        {
            metodichka.Show();
        }
        Form2 poryadok = new Form2();
        private void button5_Click(object sender, EventArgs e)
        {
            poryadok.Show();
            
        }
        double time = 0;
        double period = 1;
        private void button2_Click_1(object sender, EventArgs e)
        {
            int number = dataGridView1.Rows.Add();
            dataGridView1.Rows[number].Cells[0].Value = number + 1;  // вписываем номер № действия
            dataGridView1.Rows[number].Cells[1].Value = numericUpDown1.Value / 100; // вписываем длину нити
            dataGridView1.Rows[number].Cells[2].Value = time; // ввод времени t
            dataGridView1.Rows[number].Cells[3].Value = 10; // кол-во колебаний, всегда 10
            dataGridView1.Rows[number].Cells[4].Value = period; // ввод периода T
            if (dataGridView1.Rows[number].Cells[4].Value == null)
                dataGridView1.Rows[number].Cells[5].Value = 0;
            else
            {
                dataGridView1.Rows[number].Cells[5].Value = Math.Pow((double)dataGridView1.Rows[number].Cells[4].Value, 2); // ввод квадрата периода (T^2)
            }
            dataGridView1.Rows[number].Cells[6].Value = 9.8;
        }
        private void DrawCircleAndLine(int a)
        {
            System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Black);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            //formGraphics.DrawLine(myPen, 750, 25, 750, 100);
            //formGraphics.DrawEllipse(myPen, 725, 100, 50, 50);
            if (a == 1)
            {
                formGraphics.DrawLine(myPen, 800, 25, 800, 100);
                formGraphics.DrawEllipse(myPen, 775, 100, 50, 50);
            }
            else if (a == 2)
            {
                formGraphics.DrawLine(myPen, 800, 25, 725, 50);
                formGraphics.DrawEllipse(myPen, 675, 25, 50, 50);

            }
            else if (a == 3)
            {
                formGraphics.DrawLine(myPen, 800, 25, 800, 100);
                formGraphics.DrawEllipse(myPen, 775, 100, 50, 50);

            }
            else if (a == 4) 
            {
                formGraphics.DrawLine(myPen, 800, 25, 875, 50);
                formGraphics.DrawEllipse(myPen, 875, 25, 50, 50);
            }
            myPen.Dispose();
            formGraphics.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (polojenie == 0)
                DrawCircleAndLine(1);
                timer1.Stop();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if ((polojenie < 5) && (polojenie>1))
            {
                //this.Invalidate();
                DrawCircleAndLine(polojenie);
                label1.Text = polojenie.ToString();
                polojenie++;
            }
            else if (polojenie != 0)
            {
                polojenie = 1;
                timer2.Stop();
                timer1.Start();
            }
        }
        
        private void timer3_Tick(object sender, EventArgs e)
        {
            if ((polojenie < 5) && (polojenie > 1))
                this.Invalidate();
            if (polojenie == 1)
            {
                this.Invalidate();
                polojenie = 0;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}