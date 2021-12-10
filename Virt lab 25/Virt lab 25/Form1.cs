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
        public string name;
        // public object dataCellsValue1;
        // public object dataCellsValue2;
        // public object dataCellsValue3;
        // public object dataCellsValue4;
        // public object dataCellsValue5;
        // public object dataCellsValue6;
        // public object dataCellsValue7;
        // public object dataCellsValue8;
        // public double kA;
        // public double kB;
        public string group;
        public bool workWasDone = false;
        
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


        private double AMathematicalOperation()
        {
            double a = 0;
            double algebraicSumOfIideltaFii = 0;
            double algebraicIi = 0;
            double algebraicIiInSquare = 0;
            double algebraicdeltaFii = 0;
            for (int i = 0; i < numberofoperations; i++)
            {
                algebraicSumOfIideltaFii += Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value) * Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);

                algebraicIi += Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);

                algebraicdeltaFii += Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);

                algebraicIiInSquare += Math.Pow(Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value),2);
            }
            a = (algebraicSumOfIideltaFii * numberofoperations - (algebraicSumOfIideltaFii * algebraicIi)) / (algebraicIiInSquare * numberofoperations - Math.Pow(algebraicIi,2));
            a = Math.Round(a, 3);
            return a;
        }
        private double BMathematicalOperation()
        {
            double b = 0;
            double algebraicSumOfIideltaFii = 0;
            double algebraicIi = 0;
            double algebraicIiInSquare = 0;
            double algebraicdeltaFii = 0;
            for (int i = 0; i < numberofoperations; i++)
            {
                algebraicSumOfIideltaFii += Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value) * Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);

                algebraicIi += Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);

                algebraicdeltaFii += Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);

                algebraicIiInSquare += Math.Pow(Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value), 2);
            }
            b = ((algebraicIiInSquare * algebraicdeltaFii) - (algebraicSumOfIideltaFii * algebraicIi)) / ((Math.Pow(algebraicIi, 2) * numberofoperations) - algebraicIi);
            b = Math.Round(b, 3);
            return b;
        }

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
        public int numberofoperations = 0;
        int quantity = 0;
        public void Button2_Click(object sender, EventArgs e)
        {
            if (quantity < 8) // проверка на количество измерений 
            {
                bool isThisNumberWasUsed = false;
                int number = dataGridView1.Rows.Add();
                numberofoperations = number;
                    for (int i = 0; i < number; i++)
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
            if (workWasDone)
            {
                Protocol protocol = new Protocol();
                protocol.fullName = name;
                protocol.groupName = group;
                protocol.countErrors = countErrorsOfCheckResutls.ToString();
                protocol.Show();  
            }
            else
            {
                MessageBox.Show("Вы не выполнили работу");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public int countErrorsOfCheckResutls = 0;
        private void check_Results_Click(object sender, EventArgs e)
        {
            double a, b;
            MessageBox.Show(Convert.ToString(AMathematicalOperation()) + " " + Convert.ToString(BMathematicalOperation()));
            if (quantity != 8)
            {
                MessageBox.Show("Вы провели меньше 8-ми опытов", "Внимание");
            }
            else
            {
                if (Double.TryParse(textBox1.Text, out a) && Double.TryParse(textBox2.Text, out b))
                {
                    if ((a == AMathematicalOperation()) && (b == BMathematicalOperation()))
                    {
                        MessageBox.Show("Ваши измерения коэффициентов верны", "Поздравляем");
                        workWasDone = true;
                        Graph graph = new Graph();
                        graph.dataCells1Value1 = Convert.ToDouble(dataGridView1.Rows[0].Cells[1].Value);
                        graph.dataCells1Value2 = Convert.ToDouble(dataGridView1.Rows[1].Cells[1].Value);
                        graph.dataCells1Value3 = Convert.ToDouble(dataGridView1.Rows[2].Cells[1].Value);
                        graph.dataCells1Value4 = Convert.ToDouble(dataGridView1.Rows[3].Cells[1].Value);
                        graph.dataCells1Value5 = Convert.ToDouble(dataGridView1.Rows[4].Cells[1].Value);
                        graph.dataCells1Value6 = Convert.ToDouble(dataGridView1.Rows[5].Cells[1].Value);
                        graph.dataCells1Value7 = Convert.ToDouble(dataGridView1.Rows[6].Cells[1].Value);
                        graph.dataCells1Value8 = Convert.ToDouble(dataGridView1.Rows[7].Cells[1].Value);
                        graph.dataCells2Value1 = Convert.ToDouble(dataGridView1.Rows[0].Cells[2].Value);
                        graph.dataCells2Value2 = Convert.ToDouble(dataGridView1.Rows[1].Cells[2].Value);
                        graph.dataCells2Value3 = Convert.ToDouble(dataGridView1.Rows[2].Cells[2].Value);
                        graph.dataCells2Value4 = Convert.ToDouble(dataGridView1.Rows[3].Cells[2].Value);
                        graph.dataCells2Value5 = Convert.ToDouble(dataGridView1.Rows[4].Cells[2].Value);
                        graph.dataCells2Value6 = Convert.ToDouble(dataGridView1.Rows[5].Cells[2].Value);
                        graph.dataCells2Value7 = Convert.ToDouble(dataGridView1.Rows[6].Cells[2].Value);
                        graph.dataCells2Value8 = Convert.ToDouble(dataGridView1.Rows[7].Cells[2].Value);
                        graph.kA = AMathematicalOperation();
                        graph.kB = BMathematicalOperation();
                        graph.Show();
                    }
                    else
                    {
                        MessageBox.Show("Ваши измерения коэффициентов неверны", "Ошибка");
                        countErrorsOfCheckResutls++;
                    }
                }
                else
                {
                    MessageBox.Show("Ваши измерения коэффициентов неверны", "Ошибка");
                    countErrorsOfCheckResutls++;
                }
            }
        }
    }
}