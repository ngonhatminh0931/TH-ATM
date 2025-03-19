using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Task5 : Form
    {
        public Task5()
        {
            InitializeComponent();
            textBox_Message.TextChanged += new EventHandler(textBox_Message_TextChanged);
            textBox_Key.TextChanged += new EventHandler(textBox_Key_TextChanged);
        }


        


        private void textBox_Message_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = textBox_Message.SelectionStart;
            textBox_Message.Text = textBox_Message.Text.ToUpper();
            textBox_Message.SelectionStart = selectionStart;
        }

        // Sự kiện TextChanged cho textBox_Key
        private void textBox_Key_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = textBox_Key.SelectionStart;
            textBox_Key.Text = textBox_Key.Text.ToUpper();
            textBox_Key.SelectionStart = selectionStart;
        }

        private string Encrypt(string plainText, string key)
        {
            StringBuilder result = new StringBuilder();
            plainText = plainText.ToUpper();
            key = key.ToUpper();
            int keyIndex = 0;

            foreach (char c in plainText)
            {
                if (char.IsLetter(c))
                {
                    // Công thức mã hóa Vigenère: (P[i] + K[i]) mod 26
                    int charValue = (c - 'A');
                    int keyValue = (key[keyIndex % key.Length] - 'A');
                    int encryptedValue = (charValue + keyValue) % 26;
                    result.Append((char)(encryptedValue + 'A'));
                    keyIndex++;
                }
                else
                {
                    // Giữ nguyên các ký tự không phải chữ cái
                    result.Append(c);
                }
            }

            return result.ToString();
        }

        private string Decrypt(string cipherText, string key)
        {
            StringBuilder result = new StringBuilder();
            cipherText = cipherText.ToUpper();
            key = key.ToUpper();
            int keyIndex = 0;

            foreach (char c in cipherText)
            {
                if (char.IsLetter(c))
                {
                    // Công thức giải mã Vigenère: (C[i] - K[i] + 26) mod 26
                    int charValue = (c - 'A');
                    int keyValue = (key[keyIndex % key.Length] - 'A');
                    int decryptedValue = (charValue - keyValue + 26) % 26;
                    result.Append((char)(decryptedValue + 'A'));
                    keyIndex++;
                }
                else
                {
                    // Giữ nguyên các ký tự không phải chữ cái
                    result.Append(c);
                }
            }

            return result.ToString();
        }

        private void button_Encrypt_Click(object sender, EventArgs e)
        {
            string message = textBox_Message.Text;
            string key = textBox_Key.Text;

            if (string.IsNullOrEmpty(message) || string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Vui lòng nhập cả văn bản và khóa!", "Lỗi!",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string encryptedMessage = Encrypt(message, key);
            textBox_Result.Text = encryptedMessage.ToUpper();
        }

        private void button_Decrypt_Click(object sender, EventArgs e)
        {
            string message = textBox_Message.Text;
            string key = textBox_Key.Text;

            if (string.IsNullOrEmpty(message) || string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Vui lòng nhập cả văn bản và khóa!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string decryptedMessage = Decrypt(message, key);
            textBox_Result.Text = decryptedMessage.ToUpper();
        }
    }
}
