using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Lab01
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }

        private string Encrypt(string text, int shift)
        {
            char[] buffer = text.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                if (char.IsLetter(letter))
                {
                    char offset = char.IsUpper(letter) ? 'A' : 'a';
                    buffer[i] = (char)((letter + shift - offset) % 26 + offset);
                }
            }
            return new string(buffer);
        }


        private string Decrypt(string text, int shift)
        {
            char[] buffer = text.ToCharArray();
            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                if (char.IsLetter(letter))
                {
                    char offset = char.IsUpper(letter) ? 'A' : 'a';
                    buffer[i] = (char)((letter - offset - shift + 26) % 26 + offset);
                }
            }
            return new string(buffer);
        }


        private void button_checkKey_Click(object sender, EventArgs e)
        {
            string encryptedText = textBox_Message.Text;

            if (string.IsNullOrWhiteSpace(encryptedText))
            {
                MessageBox.Show("Vui lòng nhập văn bản đã mã hóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StringBuilder results = new StringBuilder();

            // Thử tất cả các giá trị của key từ 1 đến 25
            for (int shift = 1; shift < 26; shift++)
            {
                string decryptedText = Decrypt(encryptedText, shift);
                results.AppendLine($"Key {shift}: {decryptedText}");
            }

            // Hiển thị danh sách kết quả vào textBox_checkKey
            textBox_checkKey.Text = results.ToString();
        }

        private void button_Encrypt_Click(object sender, EventArgs e)
        {
            int shift;

            if (textBox_Key.Text.Length == 1 && char.IsLetter(textBox_Key.Text[0]))
            {
                char keyChar = textBox_Key.Text[0];
                shift = char.IsUpper(keyChar) ? keyChar - 'A' : keyChar - 'a';
                textBox_Result.Text = Encrypt(textBox_Message.Text, shift);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số hoặc một chữ cái hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Decrypt_Click(object sender, EventArgs e)
        {
            int shift;

            if (textBox_Key.Text.Length == 1 && char.IsLetter(textBox_Key.Text[0]))
            {
                char keyChar = textBox_Key.Text[0];
                shift = char.IsUpper(keyChar) ? keyChar - 'A' : keyChar - 'a';
                textBox_Result.Text = Decrypt(textBox_Message.Text, shift);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số hoặc một chữ cái hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_Key_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
                MessageBox.Show("Chỉ được nhập một chữ cái!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Nếu đã có 1 ký tự, chặn nhập thêm
            if (textBox_Key.Text.Length >= 1 && e.KeyChar != '\b')
            {
                e.Handled = true;
                MessageBox.Show("Chỉ được nhập 1 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
