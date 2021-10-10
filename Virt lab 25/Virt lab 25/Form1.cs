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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            left.Text = char.ConvertFromUtf32(0x2190);
            right.Text = char.ConvertFromUtf32(0x2192);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
