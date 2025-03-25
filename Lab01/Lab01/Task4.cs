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
    public partial class Task4 : Form
    {
        private int size;
        private char[,] matrix;
        private Dictionary<char, (int, int)> position;
        private List<char> keyString = new List<char>();

        public Task4()
        {
            InitializeComponent();
            radioButton_5x5.Checked = true;
        }

        private bool ContainsDigit(string text)
        {
            return text.Any(char.IsDigit);
        }

        private void GenerateMatrix(string key, bool use6x6)//Tạo ma trận flayfair từ key
        {
            size = use6x6 ? 6 : 5;
            matrix = new char[size, size];
            position = new Dictionary<char, (int, int)>();

            keyString.Clear();
            HashSet<char> used = new HashSet<char>();

            foreach (char ch in key.ToUpper())
            {
                char tempCh = (ch == 'J' && !use6x6) ? 'I' : ch;
                if (!used.Contains(tempCh) && (char.IsLetter(tempCh) || (use6x6 && char.IsDigit(tempCh))))
                {
                    keyString.Add(tempCh);
                    used.Add(tempCh);
                }
            }

            for (char ch = 'A'; ch <= 'Z'; ch++)
            {
                if (ch == 'J' && !use6x6) continue;
                if (!used.Contains(ch))
                {
                    keyString.Add(ch);
                    used.Add(ch);
                }
            }

            if (use6x6)
            {
                for (char ch = '0'; ch <= '9'; ch++)
                {
                    if (!used.Contains(ch))
                    {
                        keyString.Add(ch);
                        used.Add(ch);
                    }
                }
            }

            int index = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = keyString[index];
                    position[keyString[index]] = (i, j);
                    index++;
                }
            }

            UpdateMatrixDisplay();
        }

        private List<(char, char)> PreprocessText(string text, bool use6x6)
        {
            List<(char, char)> digraphs = new List<(char, char)>();
            List<char> cleanedText = new List<char>();

            foreach (char ch in text.ToUpper())
            {
                if (char.IsLetter(ch) || (use6x6 && char.IsDigit(ch)))
                {
                    cleanedText.Add((ch == 'J' && !use6x6) ? 'I' : ch);
                }
            }

            if (cleanedText.Count == 0)
            {
                MessageBox.Show("Lỗi: Văn bản không có ký tự hợp lệ!");
                return digraphs;
            }

            for (int i = 0; i < cleanedText.Count; i++)
            {
                char first = cleanedText[i];
                char second;

                if (i + 1 < cleanedText.Count)
                {
                    second = cleanedText[i + 1];

                    if (first == second)
                    {
                        second = 'X';
                    }
                    else
                    {
                        i++;
                    }
                }
                else
                {
                    second = 'X';
                }

                digraphs.Add((first, second));
            }

            return digraphs;
        }

        private (char, char) EncryptPair(char a, char b)
        {
            (int rowA, int colA) = position[a];
            (int rowB, int colB) = position[b];

            if (rowA == rowB)
            {
                return (matrix[rowA, (colA + 1) % size], matrix[rowB, (colB + 1) % size]);
            }
            else if (colA == colB)
            {
                return (matrix[(rowA + 1) % size, colA], matrix[(rowB + 1) % size, colB]);
            }
            else
            {
                return (matrix[rowA, colB], matrix[rowB, colA]);
            }
        }

        private string Encrypt(string text, string key)
        {
            bool use6x6 = ContainsDigit(text);
            GenerateMatrix(key, use6x6);
            List<(char, char)> digraphs = PreprocessText(text, use6x6);

            StringBuilder cipherText = new StringBuilder();

            foreach (var (a, b) in digraphs)
            {
                if (!position.ContainsKey(a) || !position.ContainsKey(b))
                {
                    MessageBox.Show($"Lỗi: Ký tự {a} hoặc {b} không có trong ma trận!");
                    return "";
                }

                var (encA, encB) = EncryptPair(a, b);
                cipherText.Append(encA).Append(encB);
            }

            return cipherText.ToString();
        }

        private (char, char) DecryptPair(char a, char b)
        {
            (int rowA, int colA) = position[a];
            (int rowB, int colB) = position[b];

            if (rowA == rowB)
            {
                return (matrix[rowA, (colA - 1 + size) % size], matrix[rowB, (colB - 1 + size) % size]);
            }
            else if (colA == colB)
            {
                return (matrix[(rowA - 1 + size) % size, colA], matrix[(rowB - 1 + size) % size, colB]);
            }
            else
            {
                return (matrix[rowA, colB], matrix[rowB, colA]);
            }
        }

        private string Decrypt(string cipherText, string key)
        {
            bool use6x6 = ContainsDigit(cipherText);
            GenerateMatrix(key, use6x6);
            List<(char, char)> digraphs = PreprocessText(cipherText, use6x6);

            StringBuilder plainText = new StringBuilder();

            foreach (var (a, b) in digraphs)
            {
                if (!position.ContainsKey(a) || !position.ContainsKey(b))
                {
                    MessageBox.Show($"Lỗi: Ký tự {a} hoặc {b} không có trong ma trận!");
                    return "";
                }

                var (decA, decB) = DecryptPair(a, b);
                plainText.Append(decA).Append(decB);
            }

            return plainText.ToString();
        }

        private void button_Encrypt_Click(object sender, EventArgs e)
        {
            string key = textBox_Key.Text.Trim();
            string input = textBox_Message.Text.Trim();

            if (string.IsNullOrWhiteSpace(key) && string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Vui lòng nhập khóa và văn bản.");
                return;
            }

            if (string.IsNullOrWhiteSpace(key))
            {
                MessageBox.Show("Vui lòng nhập khóa.");
                return;
            }

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Vui lòng nhập văn bản cần mã hóa.");
                return;
            }

            textBox_Result.Text = Encrypt(input, key);
        }

        private void button_Decrypt_Click(object sender, EventArgs e)
        {
            string key = textBox_Key.Text;
            string input = textBox_Message.Text;

            if (string.IsNullOrWhiteSpace(key) && string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Vui lòng nhập khóa và văn bản.");
                return;
            }

            if (string.IsNullOrWhiteSpace(key))
            {
                MessageBox.Show("Vui lòng nhập khóa.");
                return;
            }

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Vui lòng nhập văn bản cần giải mã.");
                return;
            }

            textBox_Result.Text = Decrypt(input, key);
        }

        private void InitializeMatrix(int size)
        {
            tableLayoutPanel_KeyMatrix.Controls.Clear();
            tableLayoutPanel_KeyMatrix.ColumnStyles.Clear();
            tableLayoutPanel_KeyMatrix.RowStyles.Clear();
            tableLayoutPanel_KeyMatrix.ColumnCount = size;
            tableLayoutPanel_KeyMatrix.RowCount = size;

            for (int i = 0; i < size; i++)
            {
                tableLayoutPanel_KeyMatrix.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / size));
                tableLayoutPanel_KeyMatrix.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / size));
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    TextBox txt = new TextBox
                    {
                        ReadOnly = true,
                        TextAlign = HorizontalAlignment.Center,
                        Width = 30,
                        Height = 30,
                        Anchor = AnchorStyles.None,
                        BackColor = Color.White
                    };
                    tableLayoutPanel_KeyMatrix.Controls.Add(txt, j, i);
                }
            }
        }

        private void UpdateMatrixDisplay()
        {
            int index = 0;
            foreach (System.Windows.Forms.Control control in tableLayoutPanel_KeyMatrix.Controls)
            {
                if (control is TextBox)
                {
                    TextBox txt = (TextBox)control; // Ép kiểu tường minh
                    txt.Text = (index < keyString.Count) ? keyString[index].ToString() : "";
                    index++;
                }
            }
        }

        private void textBox_Key_TextChanged(object sender, EventArgs e)
        {
            textBox_Key.KeyPress += textBox_Key_AllowLettersAndNumbers;
            bool use6x6 = textBox_Key.Text.Any(char.IsDigit);
            GenerateMatrix(textBox_Key.Text, use6x6);
        }

        private void textBox_Message_TextChanged(object sender, EventArgs e)
        {
            textBox_Message.KeyPress += textBox_Message_AllowLettersAndNumbers;
        }

        private void textBox_Key_AllowLettersAndNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_Message_AllowLettersAndNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_Key_AllowOnlyLetters(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_Message_AllowOnlyLetters(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void radioButton_5x5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_5x5.Checked)
            {
                textBox_Key.Text = new string(textBox_Key.Text.Where(ch => char.IsLetter(ch) && ch != 'J').ToArray());
                textBox_Key.KeyPress -= textBox_Key_AllowLettersAndNumbers;
                textBox_Key.KeyPress += textBox_Key_AllowOnlyLetters;
                textBox_Message.KeyPress -= textBox_Message_AllowLettersAndNumbers;
                textBox_Message.KeyPress += textBox_Message_AllowOnlyLetters;
                InitializeMatrix(5);
                GenerateMatrix(textBox_Key.Text, false);
            }
            else if (radioButton_6x6.Checked)
            {
                textBox_Key.KeyPress -= textBox_Key_AllowOnlyLetters;
                textBox_Key.KeyPress += textBox_Key_AllowLettersAndNumbers;
                textBox_Message.KeyPress -= textBox_Message_AllowOnlyLetters;
                textBox_Message.KeyPress += textBox_Message_AllowLettersAndNumbers;
                InitializeMatrix(6);
                GenerateMatrix(textBox_Key.Text, true);
            }
        }
    }
}
