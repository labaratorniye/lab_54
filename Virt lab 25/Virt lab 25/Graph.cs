using System;
using System.Windows.Forms;

namespace Virt_lab_25
{
    public partial class Graph : Form
    {
        public double dataCells1Value1;
        public double dataCells1Value2;
        public double dataCells1Value3;
        public double dataCells1Value4;
        public double dataCells1Value5;
        public double dataCells1Value6;
        public double dataCells1Value7;
        public double dataCells1Value8;
        public double dataCells2Value1;
        public double dataCells2Value2;
        public double dataCells2Value3;
        public double dataCells2Value4;
        public double dataCells2Value5;
        public double dataCells2Value6;
        public double dataCells2Value7;
        public double dataCells2Value8;
        public double kA;
        public double kB;
        public Graph()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] array1 = new double[8];
            double[] array2 = new double[8];
            array1[0] = this.kA * this.dataCells1Value1 + this.kB;
            array1[1] = this.kA * this.dataCells1Value2 + this.kB;
            array1[2] = this.kA * this.dataCells1Value3 + this.kB;
            array1[3] = this.kA * this.dataCells1Value4 + this.kB;
            array1[4] = this.kA * this.dataCells1Value5 + this.kB;
            array1[5] = this.kA * this.dataCells1Value6 + this.kB;
            array1[6] = this.kA * this.dataCells1Value7 + this.kB;
            array1[7] = this.kA * this.dataCells1Value8 + this.kB;
            
            array2[0] = dataCells2Value1;
            array2[1] = dataCells2Value2;
            array2[2] = dataCells2Value3;
            array2[3] = dataCells2Value4;
            array2[4] = dataCells2Value5;
            array2[5] = dataCells2Value6;
            array2[6] = dataCells2Value7;
            array2[7] = dataCells2Value8;

            double temp1;
            double temp2;
            
            // Сортировка массива пузырьком
            for (int i = 0; i < 8 - 1; i++) {
                for (int j = 0; j < 8 - i - 1; j++) {
                    if (array1[j] > array1[j + 1]) {
                        // меняем элементы местами
                        temp1 = array1[j];
                        array1[j] = array1[j + 1];
                        array1[j + 1] = temp1;
                    }
                }
            }
            // Сортировка массива пузырьком
            for (int i = 0; i < 8 - 1; i++) {
                for (int j = 0; j < 8 - i - 1; j++) {
                    if (array2[j] > array2[j + 1]) {
                        // меняем элементы местами
                        temp2 = array2[j];
                        array2[j] = array2[j + 1];
                        array2[j + 1] = temp2;
                    }
                }
            }
            
            chart1.Series[0].Points.AddXY(array2[0],array1[0]);
            chart1.Series[0].Points.AddXY(array2[1],array1[1]);
            chart1.Series[0].Points.AddXY(array2[2],array1[2]);
            chart1.Series[0].Points.AddXY(array2[3],array1[3]);
            chart1.Series[0].Points.AddXY(array2[4],array1[4]);
            chart1.Series[0].Points.AddXY(array2[5],array1[5]);
            chart1.Series[0].Points.AddXY(array2[6],array1[6]);
            chart1.Series[0].Points.AddXY(array2[7],array1[7]);

            label1.Text = "1) X: " + Convert.ToString(array2[0]) + " Y: " + Convert.ToString(array1[0]) + "\n" +
                          "2) X: " + Convert.ToString(array2[1]) + " Y: " + Convert.ToString(array1[1]) + "\n" +
                          "3) X: " + Convert.ToString(array2[2]) + " Y: " + Convert.ToString(array1[2]) + "\n" +
                          "4) X: " + Convert.ToString(array2[3]) + " Y: " + Convert.ToString(array1[3]) + "\n" +
                          "5) X: " + Convert.ToString(array2[4]) + " Y: " + Convert.ToString(array1[4]) + "\n" +
                          "6) X: " + Convert.ToString(array2[5]) + " Y: " + Convert.ToString(array1[5]) + "\n" +
                          "7) X: " + Convert.ToString(array2[6]) + " Y: " + Convert.ToString(array1[6]) + "\n" +
                          "8) X: " + Convert.ToString(array2[7]) + " Y: " + Convert.ToString(array1[7]);
            
            button1.Enabled = false;
        }
    }
}