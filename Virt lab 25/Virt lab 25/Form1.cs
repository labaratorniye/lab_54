using System;
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
        private void button3_Click(object sender, EventArgs e)
        {
            metodichka.Show();
        }
        
        Form2 taskList = new Form2();
        private void button5_Click(object sender, EventArgs e)
        {
            taskList.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            Protocol protocol = new Protocol();
            protocol.fullName = name;
            protocol.Show();
        }
    }
}