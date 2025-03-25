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
    public partial class Task6 : Form
    {
        private Dictionary<string, List<int>> matrixSizeToTextBoxMapping;
        private TextBox[] allTextBoxes;
        public Task6()
        {
            InitializeComponent();

            allTextBoxes = new TextBox[36];
            for (int i = 1; i <= 36; i++)
            {
                allTextBoxes[i - 1] = (TextBox)this.Controls.Find("txt" + i, true)[0];
                allTextBoxes[i - 1].TextChanged += TextBox_TextChanged;
            }

            matrixSizeToTextBoxMapping = new Dictionary<string, List<int>>
            {
                { "1x1", new List<int> { 1 } },
                { "2x2", new List<int> { 1, 2, 7, 8 } },
                { "3x3", new List<int> { 1, 2, 3, 7, 8, 9, 13, 14, 15 } },
                { "4x4", new List<int> { 1, 2, 3, 4, 7, 8, 9, 10, 13, 14, 15, 16, 19, 20, 21, 22 } },
                { "5x5", new List<int> { 1, 2, 3, 4, 5, 7, 8, 9, 10, 11, 13, 14, 15, 16, 17, 19, 20, 21, 22, 23, 25, 26, 27, 28, 29 } },
                { "6x6", new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 } }
            };

            radioButton1.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            radioButton2.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            radioButton3.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            radioButton4.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            radioButton5.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            radioButton6.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);

            UpdateTextBoxesState();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && !string.IsNullOrEmpty(textBox.Text))
            {
                string input = textBox.Text.Trim();
                char lastChar = input[input.Length - 1];

                if (char.IsLetter(lastChar))
                {
                    textBox.TextChanged -= TextBox_TextChanged;
                    char upperChar = char.ToUpper(lastChar);
                    int value;
                    if (upperChar == 'Z')
                    {
                        value = 0; // Z = 0
                    }
                    else
                    {
                        value = upperChar - 'A' + 1; // A=1, B=2, ..., Y=25
                    }
                    textBox.Text = value.ToString();
                    textBox.TextChanged += TextBox_TextChanged;
                    textBox.SelectionStart = textBox.Text.Length;
                }
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTextBoxesState();
        }

        private void UpdateTextBoxesState()
        {
            foreach (TextBox txt in allTextBoxes)
            {
                txt.Enabled = false;
            }

            string selectedSize = "";
            if (radioButton1.Checked)
                selectedSize = "1x1";
            else if (radioButton2.Checked)
                selectedSize = "2x2";
            else if (radioButton3.Checked)
                selectedSize = "3x3";
            else if (radioButton4.Checked)
                selectedSize = "4x4";
            else if (radioButton5.Checked)
                selectedSize = "5x5";
            else if (radioButton6.Checked)
                selectedSize = "6x6";

            if (matrixSizeToTextBoxMapping.ContainsKey(selectedSize))
            {
                foreach (int textBoxIndex in matrixSizeToTextBoxMapping[selectedSize])
                {
                    TextBox textBox = (TextBox)this.Controls.Find("txt" + textBoxIndex, true)[0];
                    textBox.Enabled = true;
                }
            }
        }

        private void btn_ChkKey_Click(object sender, EventArgs e)
        {
            int size = GetMatrixSize();
            if (size == 0)
            {
                MessageBox.Show("Vui lòng chọn kích thước ma trận.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int[,] keyMatrix = GetKeyMatrix(size);
            if (keyMatrix == null)
                return;

            bool isValidKey = IsValidHillKey(keyMatrix, size);

            if (isValidKey)
            {
                btn_ChkKey.BackColor = Color.Green;
                MessageBox.Show("Ma trận khóa hợp lệ cho thuật toán Hill.", "Kiểm tra thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                btn_ChkKey.BackColor = Color.Red;
                MessageBox.Show("Ma trận khóa không hợp lệ cho thuật toán Hill. Định thức của ma trận phải nguyên tố cùng nhau với 26 (không chia hết cho 2 hoặc 13).", "Kiểm tra thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetMatrixSize()
        {
            int size = 0;
            if (radioButton1.Checked)
                size = 1;
            else if (radioButton2.Checked)
                size = 2;
            else if (radioButton3.Checked)
                size = 3;
            else if (radioButton4.Checked)
                size = 4;
            else if (radioButton5.Checked)
                size = 5;
            else if (radioButton6.Checked)
                size = 6;
            return size;
        }

        private int[,] GetKeyMatrix(int size)
        {
            int[,] keyMatrix = new int[size, size];
            Dictionary<string, int> txtBoxToMatrixMapping = GetTextBoxMapping(size);

            foreach (var mapping in txtBoxToMatrixMapping)
            {
                string[] indices = mapping.Key.Split(',');
                int row = int.Parse(indices[0]);
                int col = int.Parse(indices[1]);

                TextBox txtBox = (TextBox)this.Controls.Find("txt" + mapping.Value, true)[0];

                if (string.IsNullOrWhiteSpace(txtBox.Text) || !int.TryParse(txtBox.Text, out int value))
                {
                    MessageBox.Show("Vui lòng nhập số nguyên hoặc chữ cái vào tất cả các ô của ma trận khóa.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btn_ChkKey.BackColor = Color.Red;
                    return null;
                }

                value = value % 26; 
                keyMatrix[row, col] = value;
            }

            return keyMatrix;
        }

        private bool IsValidHillKey(int[,] matrix, int size)
        {
            if (size == 1)
            {
                return GCD(matrix[0, 0], 26) == 1;
            }

            int det = CalculateDeterminant(matrix, size);
            det = det % 26;
            if (det < 0) det += 26;

            return GCD(det, 26) == 1;
        }

        private int CalculateDeterminant(int[,] matrix, int size)
        {
            if (size == 1)
                return matrix[0, 0];

            if (size == 2)
                return (matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0]);

            int det = 0;
            for (int col = 0; col < size; col++)
            {
                int[,] subMatrix = new int[size - 1, size - 1];
                for (int i = 1; i < size; i++)
                {
                    int subCol = 0;
                    for (int j = 0; j < size; j++)
                    {
                        if (j == col) continue;
                        subMatrix[i - 1, subCol++] = matrix[i, j];
                    }
                }

                int sign = (col % 2 == 0) ? 1 : -1;
                det += sign * matrix[0, col] * CalculateDeterminant(subMatrix, size - 1);
            }

            return det;
        }
        private int GCD(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        private Dictionary<string, int> GetTextBoxMapping(int size)
        {
            Dictionary<string, int> mapping = new Dictionary<string, int>();

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    int txtBoxId = (row * 6) + col + 1;
                    mapping.Add($"{row},{col}", txtBoxId);
                }
            }

            return mapping;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 36; i++)
            {
                TextBox txtBox = (TextBox)this.Controls.Find("txt" + i, true)[0];
                txtBox.Text = string.Empty;
                txtBox.Enabled = false;
            }

            // Reset TextBox nhập liệu tin nhắn và kết quả
            textBox_Message.Text = string.Empty;
            textBox_Result.Text = string.Empty;
            txt_Steps.Text = string.Empty;

            // Reset màu của button kiểm tra khóa thành LemonChiffon
            btn_ChkKey.BackColor = Color.LemonChiffon;

            // Hoặc không chọn RadioButton nào
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;

            // Nếu bạn có các control khác cần reset, thêm vào đây
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            int size = GetMatrixSize();
            if (size == 0)
            {
                MessageBox.Show("Vui lòng chọn kích thước khóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int[,] keyMatrix = GetKeyMatrix(size);
            if (keyMatrix == null)
                return;

            if (!IsValidHillKey(keyMatrix, size))
            {
                MessageBox.Show("Ma trận khóa không hợp lệ đối với thuật toán của Hill. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string plaintext = textBox_Message.Text.Trim().ToUpper();
            plaintext = new string(plaintext.Where(char.IsLetter).ToArray());

            if (string.IsNullOrEmpty(plaintext))
            {
                MessageBox.Show("Vui lòng nhập tin nhắn để mã hóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StringBuilder steps = new StringBuilder();
            steps.AppendLine("Chi tiết về quá trình mã hóa:");
            steps.AppendLine("--------------------");

            string ciphertext = HillEncryptWithSteps(plaintext, keyMatrix, size, steps);

            textBox_Result.Text = ciphertext;

            txt_Steps.Clear();  
            txt_Steps.Text = steps.ToString();
            txt_Steps.SelectionStart = 0;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            int size = GetMatrixSize();
            if (size == 0)
            {
                MessageBox.Show("Vui lòng chọn kích thước ma trận.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int[,] keyMatrix = GetKeyMatrix(size);
            if (keyMatrix == null)
                return;

            if (!IsValidHillKey(keyMatrix, size))
            {
                MessageBox.Show("Ma trận khóa không hợp lệ cho thuật toán Hill. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string ciphertext = textBox_Message.Text.Trim().ToUpper();
            ciphertext = new string(ciphertext.Where(char.IsLetter).ToArray());

            if (string.IsNullOrEmpty(ciphertext))
            {
                MessageBox.Show("Vui lòng nhập tin nhắn đã mã hóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int[,] inverseMatrix = CalculateInverseMatrix(keyMatrix, size);
            if (inverseMatrix == null)
            {
                MessageBox.Show("Không thể tính ma trận nghịch đảo.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            StringBuilder steps = new StringBuilder();
            steps.AppendLine("Chi tiết về quá trình giải mã:");
            steps.AppendLine("--------------------");

            string plaintext = HillDecryptWithSteps(ciphertext, inverseMatrix, size, steps);

            textBox_Result.Text = plaintext;

            txt_Steps.Clear();  
            txt_Steps.Text = steps.ToString();
            txt_Steps.SelectionStart = 0;  
        }


        private string HillDecryptWithSteps(string ciphertext, int[,] inverseMatrix, int size, StringBuilder steps)
        {
            StringBuilder result = new StringBuilder();

            steps.AppendLine($"Văn bản mã hóa: {ciphertext}");

            int completeBlocks = ciphertext.Length / size;
            int remainingChars = ciphertext.Length % size;
            int totalBlocks = remainingChars > 0 ? completeBlocks + 1 : completeBlocks;

            string paddedCiphertext = ciphertext;
            if (remainingChars > 0)
            {
                int charsToAdd = size - remainingChars;
                steps.AppendLine($"Khối cuối cùng thiếu {charsToAdd} kí tự.");
                steps.AppendLine("Các ký tự bị thiếu sẽ được thay thế bằng giá trị 0 (Z).");
                paddedCiphertext = ciphertext.PadRight(ciphertext.Length + charsToAdd, 'Z');
            }

            steps.AppendLine($"Văn bản mã hóa sau khi padding: {paddedCiphertext}");

            steps.AppendLine("\nMa trận nghịch đảo:");
            for (int i = 0; i < size; i++)
            {
                StringBuilder row = new StringBuilder();
                for (int j = 0; j < size; j++)
                {
                    row.Append($"{inverseMatrix[i, j],2} ");
                }
                steps.AppendLine(row.ToString().Trim());
            }

            for (int block = 0; block < totalBlocks; block++)
            {
                steps.AppendLine($"\nCụm {block + 1}:");

                StringBuilder blockText = new StringBuilder();
                for (int j = 0; j < size; j++)
                {
                    int charPosition = block * size + j;
                    blockText.Append(paddedCiphertext[charPosition]);
                }
                steps.AppendLine($"Kí tự mã hóa: {blockText}");

                int[] cipherVector = new int[size];
                StringBuilder vectorStr = new StringBuilder("Vector cụm [");

                for (int j = 0; j < size; j++)
                {
                    int charPosition = block * size + j;
                    char c = paddedCiphertext[charPosition];
                    cipherVector[j] = (c == 'Z') ? 0 : (c - 'A' + 1); // Z=0, A=1, ..., Y=25
                    vectorStr.Append($"{c}={cipherVector[j]}");

                    if (j < size - 1) vectorStr.Append(", ");
                }
                vectorStr.Append("]");
                steps.AppendLine(vectorStr.ToString());

                int[] resultVector = new int[size];
                for (int row = 0; row < size; row++)
                {
                    resultVector[row] = 0;
                    StringBuilder calculation = new StringBuilder($"Dòng {row + 1}: ");

                    for (int col = 0; col < size; col++)
                    {
                        resultVector[row] += inverseMatrix[row, col] * cipherVector[col];
                        calculation.Append($"{inverseMatrix[row, col]}×{cipherVector[col]}");
                        if (col < size - 1) calculation.Append(" + ");
                    }

                    calculation.Append($" = {resultVector[row]}");
                    steps.AppendLine(calculation.ToString());

                    int modResult = resultVector[row] % 26;
                    if (modResult < 0) modResult += 26; 
                    steps.AppendLine($"Modulo 26: {resultVector[row]} mod 26 = {modResult}");
                    resultVector[row] = modResult;
                }

                StringBuilder decryptedBlock = new StringBuilder();
                for (int j = 0; j < size; j++)
                {
                    char c = (resultVector[j] == 0) ? 'Z' : (char)(resultVector[j] + 'A' - 1); 
                    decryptedBlock.Append(c);
                }
                steps.AppendLine($"Kí tự sau khi giải mã: {decryptedBlock}");
                result.Append(decryptedBlock);
            }

            steps.AppendLine($"\nVăn bản sau khi giải mã: {result.ToString()}");
            return result.ToString();
        }

        private int[,] CalculateInverseMatrix(int[,] matrix, int size)
        {
            int det = CalculateDeterminant(matrix, size);
            det = det % 26;
            if (det < 0) det += 26;

            int detInverse = ModInverse(det, 26);
            if (detInverse == -1)
            {
                return null; 
            }

            int[,] adjugate = new int[size, size];

            if (size == 1)
            {
                adjugate[0, 0] = 1;
            }
            else if (size == 2)
            {
                adjugate[0, 0] = matrix[1, 1];
                adjugate[0, 1] = -matrix[0, 1];
                adjugate[1, 0] = -matrix[1, 0];
                adjugate[1, 1] = matrix[0, 0];
            }
            else
            {
                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col < size; col++)
                    {
                        int[,] minor = GetMinor(matrix, row, col, size);
                        int minorDet = CalculateDeterminant(minor, size - 1);
                        int sign = ((row + col) % 2 == 0) ? 1 : -1;
                        adjugate[col, row] = sign * minorDet;
                    }
                }
            }

            int[,] inverse = new int[size, size];
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    int value = (adjugate[row, col] * detInverse) % 26;
                    if (value < 0) value += 26;
                    inverse[row, col] = value;
                }
            }

            return inverse;
        }

        private int[,] GetMinor(int[,] matrix, int row, int col, int size)
        {
            int[,] minor = new int[size - 1, size - 1];
            int r = 0, c = 0;

            for (int i = 0; i < size; i++)
            {
                if (i == row) continue;
                c = 0;
                for (int j = 0; j < size; j++)
                {
                    if (j == col) continue;
                    minor[r, c] = matrix[i, j];
                    c++;
                }
                r++;
            }

            return minor;
        }

        private int ModInverse(int a, int m)
        {
            a = ((a % m) + m) % m; 

            for (int x = 1; x < m; x++)
            {
                if ((a * x) % m == 1)
                {
                    return x;
                }
            }

            return -1; 
        }



        private string HillEncryptWithSteps(string text, int[,] keyMatrix, int size, StringBuilder steps)
        {
            StringBuilder result = new StringBuilder();

            text = new string(text.Where(char.IsLetter).ToArray()).ToUpper();
            steps.AppendLine($"Văn bản trước khi mã hóa: {text}");

            int completeBlocks = text.Length / size;
            int remainingChars = text.Length % size;
            int totalBlocks = remainingChars > 0 ? completeBlocks + 1 : completeBlocks;

            if (remainingChars > 0)
            {
                steps.AppendLine($"Khối cuối cùng thiếu {size - remainingChars} kí tự.");
                steps.AppendLine("Các ký tự bị thiếu sẽ được xử lý bằng giá trị 0 (Z).");
            }

            for (int block = 0; block < totalBlocks; block++)
            {
                steps.AppendLine($"\nCụm {block + 1}:");

                StringBuilder blockText = new StringBuilder();
                for (int j = 0; j < size; j++)
                {
                    int charPosition = block * size + j;
                    if (charPosition < text.Length)
                    {
                        blockText.Append(text[charPosition]);
                    }
                    else
                    {
                        blockText.Append("Z"); 
                    }
                }
                steps.AppendLine($"Kí tự: {blockText}");

                int[] messageVector = new int[size];
                StringBuilder vectorStr = new StringBuilder("Vector cụm [");

                for (int j = 0; j < size; j++)
                {
                    int charPosition = block * size + j;
                    if (charPosition < text.Length)
                    {
                        char c = text[charPosition];
                        messageVector[j] = (c == 'Z') ? 0 : (c - 'A' + 1); // A=1, ..., Y=25, Z=0
                        vectorStr.Append($"{c}={messageVector[j]}");
                    }
                    else
                    {
                        messageVector[j] = 0; // Padding với Z (0)
                        vectorStr.Append($"Z=0");
                    }

                    if (j < size - 1) vectorStr.Append(", ");
                }
                vectorStr.Append("]");
                steps.AppendLine(vectorStr.ToString());

                int[] resultVector = new int[size];
                for (int row = 0; row < size; row++)
                {
                    resultVector[row] = 0;
                    StringBuilder calculation = new StringBuilder($"Dòng {row + 1}: ");

                    for (int col = 0; col < size; col++)
                    {
                        resultVector[row] += keyMatrix[row, col] * messageVector[col];
                        calculation.Append($"{keyMatrix[row, col]}×{messageVector[col]}");
                        if (col < size - 1) calculation.Append(" + ");
                    }

                    calculation.Append($" = {resultVector[row]}");
                    steps.AppendLine(calculation.ToString());

                    int modResult = resultVector[row] % 26;
                    steps.AppendLine($"Modulo 26: {resultVector[row]} mod 26 = {modResult}");
                    resultVector[row] = modResult;
                }

                StringBuilder encryptedBlock = new StringBuilder();
                for (int j = 0; j < size; j++)
                {
                    char c = (resultVector[j] == 0) ? 'Z' : (char)(resultVector[j] + 'A' - 1); 
                    encryptedBlock.Append(c);
                }
                steps.AppendLine($"Kí tự sau khi mã hóa: {encryptedBlock}");
                result.Append(encryptedBlock);
            }

            return result.ToString();
        }
    }
}




