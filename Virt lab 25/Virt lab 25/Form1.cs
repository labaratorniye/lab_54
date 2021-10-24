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

        private void results_Click(object sender, System.EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Invalidate();
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
        int b = 0;
        private void button2_Click_1(object sender, EventArgs e)
        {
            b = 1;
            this.Invalidate();
            //double g, l, T;
            //l = Convert.ToDouble(numericUpDown1);
            // T = 2 * Math.PI * Math.Sqrt(l / g);
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

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (b == 0)
            { 
                DrawCircleAndLine(1);
                b++;
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
                if ((b > 0) && (b < 5))
                {
                    DrawCircleAndLine(b);
                    b++;
                }
                else
                {
                    b = 0;
                }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            if ((b > 1) && (b < 5))
            {
                this.Invalidate();
            }
        }
    }
}
