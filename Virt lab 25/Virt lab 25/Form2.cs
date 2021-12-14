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
            button1.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            MaximizeBox = false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //pictureBox1.Image = Image.FromFile("TaskList2.png");
            pictureBox1.Parent = panel1;
            //pictureBox2.Parent = panel1;
            panel1.AutoScroll = true;
        }
        //Form2 close = new Form2();

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
