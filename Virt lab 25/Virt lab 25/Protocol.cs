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
    public partial class Protocol : Form
    {
        DateTime currentDate = DateTime.Now;
        
        string key = "b22ca5898a4e4147bbce2ea2322a1226";
        string encryptedString = "";
        string decryptedString = "";
        public string fullName = "";
        public string groupName = "";
        public string workName = "Лабораторная работа 'Изучение эффекта Холла в проводниках'";

        
        public Protocol()
        {
            InitializeComponent();
            MaximizeBox = false;
            saveFileDialog1.Filter = "Prot files(*.prot)|*.prot|All files(*.*)|*.*";
            saveFileDialog1.AddExtension = true;
        }

        private void Protocol_Load(object sender, EventArgs e)
        {
            label1.Text = fullName;
        }

        private void exportProtocol_Click(object sender, EventArgs e)
        {
            var str = label1.Text;
            var encryptedString = AesOperation.EncryptString(key, str);

            var currentDateEncrypted = AesOperation.EncryptString(key, currentDate.ToString());
            var fullNameEncrypted = AesOperation.EncryptString(key, fullName);
            
            string[] encryptedStrings = new string[] {  currentDateEncrypted, fullNameEncrypted };

            


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveFileDialog1.FileName, encryptedStrings);
            }
            MessageBox.Show("Протокол выгружен в папку с программой");
        }

        private void importProtocol_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(openFileDialog1.FileName);
                    if (Path.GetExtension(openFileDialog1.FileName) == ".prot")
                    {
                        this.decryptedString = AesOperation.DecryptString(key, sr.ReadToEnd());
                        MessageBox.Show("Протокол загружен");
                    } else
                    {
                        MessageBox.Show("Не поддерживаемый файл");
                    }
                    
                    sr.Close();
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                                    $"Details:\n\n{ex.StackTrace}");
                }
            }
            //var decryptedString = AesOperation.DecryptString(key, File.ReadAllText("protocol.prot"));
            label1.Text = this.decryptedString;
        }
    }
    
    public class AesOperation
    {
        public static string EncryptString(string key, string plainText)
        {
            byte[] iv = new byte[16];
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(array);
        }

        public static string DecryptString(string key, string cipherText)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}