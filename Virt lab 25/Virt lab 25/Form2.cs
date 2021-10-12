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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "Порядок выполнения работы \n 1. \n 2. \n 3. \n";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Form2 close = new Form2();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
