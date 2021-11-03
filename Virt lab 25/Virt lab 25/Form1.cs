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
        public int postionMajatnik = 0;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Enabled = false;
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
        Form2 taskList = new Form2();
        private void button5_Click(object sender, EventArgs e)
        {
            taskList.Show();
            
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (!pictureBox1.Enabled)
            {
                pictureBox1.Enabled = true;
                timer1.Start();
            } else
            {
                pictureBox1.Enabled = false;
                timer1.Stop();
            }
            

        }
   

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          /*  if (postionMajatnik == 0)
                DrawCircleAndLine(1);
                timer1.Stop(); */
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           /* if ((postionMajatnik < 5) && (postionMajatnik>1))
            {
                //this.Invalidate();
                DrawCircleAndLine(postionMajatnik);
                label1.Text = postionMajatnik.ToString();
                postionMajatnik++;
            }
            else if (postionMajatnik != 0)
            {
                postionMajatnik = 1;
                timer2.Stop();
                timer1.Start();
            } */
        }
        
        private void timer3_Tick(object sender, EventArgs e)
        {
            if ((postionMajatnik < 5) && (postionMajatnik > 1))
                this.Invalidate();
            if (postionMajatnik == 1)
            {
                this.Invalidate();
                postionMajatnik = 0;
            }
        }

        private void label1_Click(object sender, EventArgs e)
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