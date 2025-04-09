using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Numerics;

namespace Lab02
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
            comboBox_Size.SelectedIndex = 0;
        }

        private void button_GenerateRandPrime_Click(object sender, EventArgs e)
        {
            if (comboBox_Size.SelectedIndex != -1)
            {
                textBox_Result.Text = "";
                int bits = int.Parse(comboBox_Size.SelectedItem.ToString());
                BigInteger prime = GenerateRandomPrime(bits);
                textBox_Result.Text = $"Random prime number ({bits} bit): {prime}";
            }
            else
            {
                MessageBox.Show("Please select bit size");
            }
        }

        private void button_DetermineTopMersenne_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "";
            var primes = GetTop10PrimesBelowMersenne();
            textBox_Result.Text = "The 10 largest prime numbers under 10 first Mersenne prime numbers:\r\n";
            foreach (var p in primes)
                textBox_Result.AppendText(p + "\r\n");
        }

        private void button_GetLargeInt_1c_Click(object sender, EventArgs e)
        {
            if (textBox_Base.Text == "" || textBox_Exponent.Text == "")
            {
                MessageBox.Show("Please enter base and exponent in the large integer entry field");
            }
            else
            {
                textBox_LargeInt1c.Text = "";
                textBox_LargeInt1c.Text = textBox_Base.Text + "^" + textBox_Exponent.Text;
            }
        }

        private void button_CheckPrime_Click(object sender, EventArgs e)
        {
            BigInteger max = BigInteger.Pow(2, 89) - 1;
            if (textBox_LargeInt1c.Text == "")
            {
                MessageBox.Show("Please get large integer");
            }
            else
            {
                BigInteger Base;
                int Exponent;
                PowerSplit(textBox_LargeInt1c.Text, out Base, out Exponent);
                BigInteger LargeInt = BigInteger.Pow(Base, Exponent);
                if(LargeInt > max)
                {
                    MessageBox.Show("Please take an integer less than 2^89 - 1");
                }
                else 
                {
                    textBox_Result.Text = "";
                    bool isPrime = IsProbablyPrime(LargeInt);
                    textBox_Result.Text = $"{textBox_LargeInt1c.Text} is {(isPrime ? "a" : "not a")} prime number.";
                }
            }
        }

        private void button_GetLargeInt_21_Click(object sender, EventArgs e)
        {
            if (textBox_Base.Text == "" || textBox_Exponent.Text == "")
            {
                MessageBox.Show("Please enter base and exponent in the large integer entry field");
            }
            else
            {
                textBox_LargeInt21.Text = "";
                textBox_LargeInt21.Text = textBox_Base.Text + "^" + textBox_Exponent.Text;
            }
        }

        private void button_GetLargeInt_22_Click(object sender, EventArgs e)
        {
            if (textBox_Base.Text == "" || textBox_Exponent.Text == "")
            {
                MessageBox.Show("Please enter base and exponent in the large integer entry field");
            }
            else
            {
                textBox_LargeInt22.Text = "";
                textBox_LargeInt22.Text = textBox_Base.Text + "^" + textBox_Exponent.Text;
            }
        }

        private void button_DetermineGCD_Click(object sender, EventArgs e)
        {
            if (textBox_LargeInt21.Text == "" || textBox_LargeInt22.Text == "")
            {

                MessageBox.Show("Please get large integer");
            }
            else
            {
                textBox_Result.Text = "";
                BigInteger Base1;
                int Exponent1;
                PowerSplit(textBox_LargeInt21.Text, out Base1, out Exponent1);
                BigInteger a = BigInteger.Pow(Base1, Exponent1);
                BigInteger Base2;
                int Exponent2;
                PowerSplit(textBox_LargeInt22.Text, out Base2, out Exponent2);
                BigInteger b = BigInteger.Pow(Base2, Exponent2);
                BigInteger result = GCD(a, b);
                textBox_Result.Text = $"GCD({textBox_LargeInt21.Text}, {textBox_LargeInt22.Text}) = {result}";
            }
        }

        private void button_GetLargeInt_3_Click(object sender, EventArgs e)
        {
            if (textBox_Base.Text == "" || textBox_Exponent.Text == "")
            {
                MessageBox.Show("Please enter base and exponent in the large integer entry field");
            }
            else
            {
                textBox_LargeInt3.Text = "";
                textBox_LargeInt3.Text = textBox_Base.Text + "^" + textBox_Exponent.Text;
            }
        }

        private void button_Compute_Click(object sender, EventArgs e)
        {
            if (textBox_LargeInt3.Text == "" || textBox_Modulo.Text == "")
            {

                MessageBox.Show("Please get large integer and modulo");
            }
            else
            {
                textBox_Result.Text = ""; 
                BigInteger a;
                int x;
                PowerSplit(textBox_LargeInt3.Text, out a, out x);
                BigInteger p = BigInteger.Parse(textBox_Modulo.Text);
                BigInteger result = ModularExponentiation(a, x, p);
                textBox_Result.Text = $"{textBox_LargeInt3.Text} mod {p} = {result}";
            }
        }

        BigInteger GenerateRandomPrime(int bits)
        {
            Random rnd = new Random();
            BigInteger number;
            do
            {
                byte[] bytes = new byte[bits / 8];
                rnd.NextBytes(bytes);
                number = BigInteger.Abs(new BigInteger(bytes)) | 1;
            } while (!IsProbablyPrime(number));
            return number;
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

        List<BigInteger> GetTop10PrimesBelowMersenne()
        {
            List<BigInteger> mersennePrimes = new List<BigInteger>
            {
                3, 7, 31, 127, 8191, 131071, 524287, 2147483647,
                BigInteger.Parse("2305843009213693951"),
                BigInteger.Parse("618970019642690137449562111")
            };

            List<BigInteger> result = new List<BigInteger>();
            foreach (var m in mersennePrimes)
            {
                BigInteger n = m - 1;
                while (n >= 2)
                {
                    if (IsProbablyPrime(n))
                    {
                        result.Add(n);
                        break;
                    }
                    n--;
                }
            }
            return result;
        }

        void PowerSplit(string input, out BigInteger Base, out int Exponent)
        {
            if (input.Contains("^"))
            {
                string[] parts = input.Split('^');
                if (parts.Length == 2 && BigInteger.TryParse(parts[0], out Base) && Int32.TryParse(parts[1], out Exponent))
                {
                }
                else
                {
                    Base = BigInteger.Zero;
                    Exponent = 0;
                }
            }
            else if (BigInteger.TryParse(input, out Base))
            {
                Exponent = 1;
            }
            else
            {
                Base = BigInteger.Zero;
                Exponent = 0;
            }
        }

        BigInteger GCD(BigInteger a, BigInteger b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        BigInteger ModularExponentiation(BigInteger a, BigInteger x, BigInteger p)
        {
            BigInteger result = 1;
            a = a % p;
            while (x > 0)
            {
                if ((x & 1) == 1)
                    result = (result * a) % p;
                x >>= 1;
                a = (a * a) % p;
            }
            return result;
        }
    }
}
