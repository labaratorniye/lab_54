using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Security;
using System.Text;

namespace Virt_lab_25
{
    public partial class ImportProtocol : Form
    {
        string key = "b22ca5898a4e4147bbce2ea2322a1226";
        public string currentDateDecrypted = "";
        public string fullNameDecrypted = "";
        public string groupNameDecrypted = "";
        public string countErrorsDecrypted = "";
        public string workNameDecrypted = "";
        

        public ImportProtocol()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(openFileDialog1.FileName);
                    if (Path.GetExtension(openFileDialog1.FileName) == ".prot")
                    {
                        var list = new List<string>();
                        while(!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            list.Add(line);
                        }
                        
                        var arrTheoria = list.ToArray();

                        this.fullNameDecrypted = AesOperation.DecryptString(key, arrTheoria[1]);
                        this.groupNameDecrypted = AesOperation.DecryptString(key, arrTheoria[3]);
                        this.countErrorsDecrypted = AesOperation.DecryptString(key, arrTheoria[4]);
                        this.workNameDecrypted = AesOperation.DecryptString(key, arrTheoria[2]);
                        this.currentDateDecrypted = AesOperation.DecryptString(key, arrTheoria[0]);
                        
                        MessageBox.Show("Протокол загружен");
                    } else
                    {
                        MessageBox.Show("Не поддерживаемый файл");
                        return;
                    }
                    
                    sr.Close();
                    
                    if (Convert.ToInt32(countErrorsDecrypted) == 0)
                    {
                        label1.Text = workNameDecrypted + "\nВыполнена в " + currentDateDecrypted  + "\nФИО: " + fullNameDecrypted + "\nГруппа: " + groupNameDecrypted + "\nРабота выполнена без ошибок";
                    }
                    else
                    {
                        label1.Text = workNameDecrypted + "\nВыполнена в " + currentDateDecrypted + "\nФИО: " + fullNameDecrypted + "\nГруппа: " + groupNameDecrypted + "\nРабота выполнена с ошибками: " + countErrorsDecrypted;
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show("Чет не то");
                }
            }
        }
    }
}
