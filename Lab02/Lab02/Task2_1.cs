using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Task2_1 : Form
    {
        public Task2_1()
        {
            InitializeComponent();
            radioButton_Decimal.Checked = true;
        }

        BigInteger p = 0, q = 0, eValue = 0;
        BigInteger n, d, phi;

        private void button_FindPuPr_Click(object sender, EventArgs e)
        {
           
            if (radioButton_Decimal.Checked)
            {

                if (!BigInteger.TryParse(textBox_p.Text, out p) || !BigInteger.TryParse(textBox_q.Text, out q) || !BigInteger.TryParse(textBox_e.Text, out eValue))
                {
                    MessageBox.Show("Please enter integer.");
                    return;
                }
            }
            else if (radioButton_Hexadecimal.Checked)
            {
                string pHex = NormalizeHex(textBox_p.Text);
                string qHex = NormalizeHex(textBox_q.Text);
                string eHex = NormalizeHex(textBox_e.Text);

                if (!BigInteger.TryParse(pHex, System.Globalization.NumberStyles.HexNumber, null, out p) ||
                    !BigInteger.TryParse(qHex, System.Globalization.NumberStyles.HexNumber, null, out q) ||
                    !BigInteger.TryParse(eHex, System.Globalization.NumberStyles.HexNumber, null, out eValue))
                {
                    MessageBox.Show("Please enter hex format (0-9, A-F).");
                    return;
                }
            }
            if (IsProbablyPrime(p) == false)
            {
                MessageBox.Show("Please enter a prime number for p.");
            }
            else if (IsProbablyPrime(q) == false)
            {
                MessageBox.Show("Please enter a prime number for q.");
            }
            else if (GCD(eValue, (p -1) * (q -1)) != 1)
            {
                MessageBox.Show("Please enter an integer e that is relatively prime to phi(n).");
            }
            else
            {
                InitKeys(p, q, eValue);

                string publicKey = $"({eValue}, {n})";
                string privateKey = $"({d}, {n})";

                textBox_Result.Text =
                    $"Modun: n = p * q = {n}\r\n" +
                    $"phi(n) = (p - 1)(q - 1) = {phi}\r\n" +
                    $"Check e: GCD(e, phi(n)) = {GCD(eValue,phi)} → The integer e is relatively prime to phi(n)\r\n" +
                    $"Modular Inverse: d = e⁻¹ mod phi(n) = {d}\r\n\r\n" +
                    $"PU(e, n): {publicKey}\r\n" +
                    $"PR(d, n): {privateKey}";
            }
        }

        bool IsProbablyPrime(BigInteger n, int k = 10)
        {
            if (n < 2) return false;
            if (n == 2 || n == 3) return true;
            if (n % 2 == 0) return false;

            BigInteger d = n - 1;
            int r = 0;
            while (d % 2 == 0)
            {
                d /= 2;
                r++;
            }

            Random rnd = new Random();
            for (int i = 0; i < k; i++)
            {
                BigInteger a = RandomBigInteger(2, n - 2, rnd);
                BigInteger x = BigInteger.ModPow(a, d, n);
                if (x == 1 || x == n - 1) continue;

                bool passed = false;
                for (int j = 0; j < r - 1; j++)
                {
                    x = BigInteger.ModPow(x, 2, n);
                    if (x == 1) return false;
                    if (x == n - 1)
                    {
                        passed = true;
                        break;
                    }
                }
                if (!passed) return false;
            }
            return true;
        }

        BigInteger RandomBigInteger(BigInteger min, BigInteger max, Random rnd)
        {
            byte[] bytes = max.ToByteArray();
            BigInteger result;
            do
            {
                rnd.NextBytes(bytes);
                result = new BigInteger(bytes);
            } while (result < min || result >= max);
            return result;
        }

        BigInteger GCD(BigInteger a, BigInteger b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        private void button_Authentication_Click(object sender, EventArgs e)
        {
            if (!BigInteger.TryParse(textBox_Message_Int.Text, out BigInteger M))
            {
                MessageBox.Show("Please enter enteger.");
                return;
            }
            textBox_Result.Text = "";
            BigInteger Signature = BigInteger.ModPow(M, d, n);
            BigInteger Verified = BigInteger.ModPow(Signature, eValue, n);

            textBox_Result.Text = $"[Authentication]\r\n" +
                                  $"Original Message: {M}\r\n" +
                                  $"Signature: {Signature}\r\n" +
                                  $"Verified: {Verified}";
        }

        private async void button_Encrypt_Click(object sender, EventArgs e)
        {
            string message = textBox_Message_Text.Text.Trim();

            if (string.IsNullOrEmpty(message))
            {
                MessageBox.Show("Please enter a text message.");
                return;
            }

            int chunkSize = (n.GetBitLength() - 1) / 8;
            if (chunkSize <= 0)
            {
                MessageBox.Show("The modulus n is too small to encrypt even a single byte.\n" +
                                "Please generate larger primes p and q to increase key size.");
                return;
            }

            textBox_Result.Text = "Encrypting... Please wait.";

            try
            {
                string base64 = await Task.Run(() => EncryptMessage(message, chunkSize));
                textBox_Result.Text = "[Encryption for Confidentiality]\r\nCiphertext (Base64):\r\n" + base64;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Encryption failed: " + ex.Message);
            }
    
        }

        private string EncryptMessage(string message, int chunkSize)
        {
            byte[] messageBytes = Encoding.UTF8.GetBytes(message);
            List<BigInteger> encryptedChunks = new List<BigInteger>();

            for (int i = 0; i < messageBytes.Length; i += chunkSize)
            {
                byte[] chunk = messageBytes.Skip(i).Take(chunkSize).ToArray();
                BigInteger m = new BigInteger(chunk.Reverse().Concat(new byte[] { 0 }).ToArray());

                if (m >= n)
                    throw new Exception("Message chunk is too large to encrypt. Increase key size.");

                BigInteger c = BigInteger.ModPow(m, eValue, n);
                encryptedChunks.Add(c);
            }

            List<byte> encryptedBytes = new List<byte>();
            foreach (BigInteger c in encryptedChunks)
            {
                byte[] cBytes = c.ToByteArray().Reverse().ToArray();
                encryptedBytes.Add((byte)cBytes.Length);
                encryptedBytes.AddRange(cBytes);
            }

            return Convert.ToBase64String(encryptedBytes.ToArray());
        }

        private void button_Decrypt_Click(object sender, EventArgs e)
        {
            string cipherBase64 = textBox_Ciphertext.Text.Trim();

            try
            {
                byte[] encryptedBytes = Convert.FromBase64String(cipherBase64);
                List<BigInteger> cipherChunks = new List<BigInteger>();

                for (int i = 0; i < encryptedBytes.Length;)
                {
                    int len = encryptedBytes[i];
                    i++;
                    byte[] chunk = encryptedBytes.Skip(i).Take(len).Reverse().ToArray();
                    i += len;
                    cipherChunks.Add(new BigInteger(chunk.Concat(new byte[] { 0 }).ToArray()));
                }

                List<byte> decryptedBytes = new List<byte>();
                foreach (BigInteger c in cipherChunks)
                {
                    BigInteger m = BigInteger.ModPow(c, d, n);
                    byte[] mBytes = m.ToByteArray();
                    byte[] clean = mBytes.Reverse().SkipWhile(b => b == 0).ToArray();
                    decryptedBytes.AddRange(clean);
                }

                string decryptedText = Encoding.UTF8.GetString(decryptedBytes.ToArray());
                textBox_Result.Text = $"[Decryption]\r\n{decryptedText}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Chuỗi không phải dạng Base64 hợp lệ.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi giải mã: " + ex.Message);
            }
        }

        private BigInteger ModInverse(BigInteger e, BigInteger phi)
        {
            BigInteger t = 0, newT = 1;
            BigInteger r = phi, newR = e;

            while (newR != 0)
            {
                BigInteger quotient = r / newR;

                BigInteger tempT = t;
                t = newT;
                newT = tempT - quotient * newT;

                BigInteger tempR = r;
                r = newR;
                newR = tempR - quotient * newR;
            }

            if (r > 1)
                throw new Exception("Không tồn tại d vì e không có nghịch đảo modular theo φ(n)");

            if (t < 0)
                t += phi;

            return t;
        }

        private void InitKeys(BigInteger p, BigInteger q, BigInteger eValue)
        {
            n = p * q;
            phi = (p - 1) * (q - 1);
            d = ModInverse(eValue, phi);
        }

        private void button_Confidentiality_Click(object sender, EventArgs e)
        {
            if (!BigInteger.TryParse(textBox_Message_Int.Text, out BigInteger M))
            {
                MessageBox.Show("Please enter enteger.");
                return;
            }
            textBox_Result.Text = "";
            BigInteger C = BigInteger.ModPow(M, eValue, n);
            BigInteger M_decrypted = BigInteger.ModPow(C, d, n);

            textBox_Result.Text = $"[Confidentiality]\r\n" +
                                  $"Original Message: {M}\r\n" +
                                  $"Encrypted (C): {C}\r\n" +
                                  $"Decrypted: {M_decrypted}";
        }

        string NormalizeHex(string hex)
        {
            hex = hex.Trim().ToUpper().Replace("0X", "");

            if (hex.Length % 2 == 0 && "89ABCDEF".Contains(hex[0]))
            {
                hex = "00" + hex;
            }
            return hex;
        }
    }
}
public static class BigIntegerExtensions
{
    public static int GetBitLength(this BigInteger bigint)
    {
        byte[] bytes = bigint.ToByteArray();
        int bits = (bytes.Length - 1) * 8;
        byte mostSignificantByte = bytes[bytes.Length - 1];

        while (mostSignificantByte != 0)
        {
            mostSignificantByte >>= 1;
            bits++;
        }

        return bits;
    }
}
