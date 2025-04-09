using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Security.Cryptography;

namespace Lab02
{
    public partial class Task2 : Form
    {
        private BigInteger p, q, n, phi, e, d;
        private bool keysGenerated = false;

        public Task2()
        {
            InitializeComponent();
            DisableEncryptionControls();
            MyManualInitialize();
        }

        private void MyManualInitialize()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpKeyGen = new System.Windows.Forms.GroupBox();
            this.btnRandomKeys = new System.Windows.Forms.Button();
            this.btnGenerateKeys = new System.Windows.Forms.Button();
            this.txtE = new System.Windows.Forms.TextBox();
            this.lblE = new System.Windows.Forms.Label();
            this.txtQ = new System.Windows.Forms.TextBox();
            this.lblQ = new System.Windows.Forms.Label();
            this.txtP = new System.Windows.Forms.TextBox();
            this.lblP = new System.Windows.Forms.Label();
            this.grpKeyInfo = new System.Windows.Forms.GroupBox();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.lblPrivateKey = new System.Windows.Forms.Label();
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.lblPublicKey = new System.Windows.Forms.Label();
            this.grpEncDec = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.rbString = new System.Windows.Forms.RadioButton();
            this.rbNumber = new System.Windows.Forms.RadioButton();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.grpKeyGen.SuspendLayout();
            this.grpKeyInfo.SuspendLayout();
            this.grpEncDec.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(215, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "RSA Encryption Demo";
            // 
            // grpKeyGen
            // 
            this.grpKeyGen.Controls.Add(this.btnRandomKeys);
            this.grpKeyGen.Controls.Add(this.btnGenerateKeys);
            this.grpKeyGen.Controls.Add(this.txtE);
            this.grpKeyGen.Controls.Add(this.lblE);
            this.grpKeyGen.Controls.Add(this.txtQ);
            this.grpKeyGen.Controls.Add(this.lblQ);
            this.grpKeyGen.Controls.Add(this.txtP);
            this.grpKeyGen.Controls.Add(this.lblP);
            this.grpKeyGen.Location = new System.Drawing.Point(12, 45);
            this.grpKeyGen.Name = "grpKeyGen";
            this.grpKeyGen.Size = new System.Drawing.Size(500, 100);
            this.grpKeyGen.TabIndex = 1;
            this.grpKeyGen.TabStop = false;
            this.grpKeyGen.Text = "Key Generation";
            // 
            // btnRandomKeys
            // 
            this.btnRandomKeys.Location = new System.Drawing.Point(344, 56);
            this.btnRandomKeys.Name = "btnRandomKeys";
            this.btnRandomKeys.Size = new System.Drawing.Size(150, 23);
            this.btnRandomKeys.TabIndex = 7;
            this.btnRandomKeys.Text = "Generate Random Keys";
            this.btnRandomKeys.UseVisualStyleBackColor = true;
            this.btnRandomKeys.Click += new System.EventHandler(this.btnRandomKeys_Click);
            // 
            // btnGenerateKeys
            // 
            this.btnGenerateKeys.Location = new System.Drawing.Point(344, 27);
            this.btnGenerateKeys.Name = "btnGenerateKeys";
            this.btnGenerateKeys.Size = new System.Drawing.Size(150, 23);
            this.btnGenerateKeys.TabIndex = 6;
            this.btnGenerateKeys.Text = "Generate Keys";
            this.btnGenerateKeys.UseVisualStyleBackColor = true;
            this.btnGenerateKeys.Click += new System.EventHandler(this.btnGenerateKeys_Click);
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(238, 27);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(100, 20);
            this.txtE.TabIndex = 5;
            // 
            // lblE
            // 
            this.lblE.AutoSize = true;
            this.lblE.Location = new System.Drawing.Point(215, 30);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(17, 13);
            this.lblE.TabIndex = 4;
            this.lblE.Text = "e:";
            // 
            // txtQ
            // 
            this.txtQ.Location = new System.Drawing.Point(110, 54);
            this.txtQ.Name = "txtQ";
            this.txtQ.Size = new System.Drawing.Size(100, 20);
            this.txtQ.TabIndex = 3;
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Location = new System.Drawing.Point(87, 57);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(17, 13);
            this.lblQ.TabIndex = 2;
            this.lblQ.Text = "q:";
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(110, 27);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(100, 20);
            this.txtP.TabIndex = 1;
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(87, 30);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(17, 13);
            this.lblP.TabIndex = 0;
            this.lblP.Text = "p:";
            // 
            // grpKeyInfo
            // 
            this.grpKeyInfo.Controls.Add(this.txtPrivateKey);
            this.grpKeyInfo.Controls.Add(this.lblPrivateKey);
            this.grpKeyInfo.Controls.Add(this.txtPublicKey);
            this.grpKeyInfo.Controls.Add(this.lblPublicKey);
            this.grpKeyInfo.Location = new System.Drawing.Point(12, 151);
            this.grpKeyInfo.Name = "grpKeyInfo";
            this.grpKeyInfo.Size = new System.Drawing.Size(500, 120);
            this.grpKeyInfo.TabIndex = 2;
            this.grpKeyInfo.TabStop = false;
            this.grpKeyInfo.Text = "Key Information";
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Location = new System.Drawing.Point(110, 58);
            this.txtPrivateKey.Multiline = true;
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.ReadOnly = true;
            this.txtPrivateKey.Size = new System.Drawing.Size(384, 45);
            this.txtPrivateKey.TabIndex = 3;
            // 
            // lblPrivateKey
            // 
            this.lblPrivateKey.AutoSize = true;
            this.lblPrivateKey.Location = new System.Drawing.Point(6, 58);
            this.lblPrivateKey.Name = "lblPrivateKey";
            this.lblPrivateKey.Size = new System.Drawing.Size(98, 13);
            this.lblPrivateKey.TabIndex = 2;
            this.lblPrivateKey.Text = "Private Key (d, n): ";
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Location = new System.Drawing.Point(110, 19);
            this.txtPublicKey.Multiline = true;
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.ReadOnly = true;
            this.txtPublicKey.Size = new System.Drawing.Size(384, 33);
            this.txtPublicKey.TabIndex = 1;
            // 
            // lblPublicKey
            // 
            this.lblPublicKey.AutoSize = true;
            this.lblPublicKey.Location = new System.Drawing.Point(6, 22);
            this.lblPublicKey.Name = "lblPublicKey";
            this.lblPublicKey.Size = new System.Drawing.Size(96, 13);
            this.lblPublicKey.TabIndex = 0;
            this.lblPublicKey.Text = "Public Key (e, n): ";
            // 
            // grpEncDec
            // 
            this.grpEncDec.Controls.Add(this.lblResult);
            this.grpEncDec.Controls.Add(this.txtResult);
            this.grpEncDec.Controls.Add(this.rbString);
            this.grpEncDec.Controls.Add(this.rbNumber);
            this.grpEncDec.Controls.Add(this.btnDecrypt);
            this.grpEncDec.Controls.Add(this.btnEncrypt);
            this.grpEncDec.Controls.Add(this.txtMessage);
            this.grpEncDec.Controls.Add(this.lblMessage);
            this.grpEncDec.Location = new System.Drawing.Point(12, 277);
            this.grpEncDec.Name = "grpEncDec";
            this.grpEncDec.Size = new System.Drawing.Size(500, 173);
            this.grpEncDec.TabIndex = 3;
            this.grpEncDec.TabStop = false;
            this.grpEncDec.Text = "Encryption / Decryption";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(6, 118);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(43, 13);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Result: ";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(110, 115);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(384, 52);
            this.txtResult.TabIndex = 6;
            // 
            // rbString
            // 
            this.rbString.AutoSize = true;
            this.rbString.Location = new System.Drawing.Point(197, 56);
            this.rbString.Name = "rbString";
            this.rbString.Size = new System.Drawing.Size(52, 17);
            this.rbString.TabIndex = 5;
            this.rbString.Text = "String";
            this.rbString.UseVisualStyleBackColor = true;
            // 
            // rbNumber
            // 
            this.rbNumber.AutoSize = true;
            this.rbNumber.Checked = true;
            this.rbNumber.Location = new System.Drawing.Point(110, 56);
            this.rbNumber.Name = "rbNumber";
            this.rbNumber.Size = new System.Drawing.Size(62, 17);
            this.rbNumber.TabIndex = 4;
            this.rbNumber.TabStop = true;
            this.rbNumber.Text = "Number";
            this.rbNumber.UseVisualStyleBackColor = true;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(219, 79);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(100, 30);
            this.btnDecrypt.TabIndex = 3;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(110, 79);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(100, 30);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(110, 19);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(384, 31);
            this.txtMessage.TabIndex = 1;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(6, 22);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(56, 13);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Message: ";
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 462);
            this.Controls.Add(this.grpEncDec);
            this.Controls.Add(this.grpKeyInfo);
            this.Controls.Add(this.grpKeyGen);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Task2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSA Encryption Demo";
            this.grpKeyGen.ResumeLayout(false);
            this.grpKeyGen.PerformLayout();
            this.grpKeyInfo.ResumeLayout(false);
            this.grpKeyInfo.PerformLayout();
            this.grpEncDec.ResumeLayout(false);
            this.grpEncDec.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpKeyGen;
        private System.Windows.Forms.Button btnRandomKeys;
        private System.Windows.Forms.Button btnGenerateKeys;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.TextBox txtQ;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.GroupBox grpKeyInfo;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.Label lblPrivateKey;
        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.Label lblPublicKey;
        private System.Windows.Forms.GroupBox grpEncDec;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.RadioButton rbString;
        private System.Windows.Forms.RadioButton rbNumber;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblMessage;

        private void DisableEncryptionControls()
        {
            grpEncDec.Enabled = false;
        }

        private void EnableEncryptionControls()
        {
            grpEncDec.Enabled = true;
        }

        private void btnGenerateKeys_Click(object sender, EventArgs evt)
        {
            try
            {
                if (string.IsNullOrEmpty(txtP.Text) || string.IsNullOrEmpty(txtQ.Text) || string.IsNullOrEmpty(txtE.Text))
                {
                    MessageBox.Show("Please enter values for p, q, and e.", "Missing Values", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Parse input values
                if (!BigInteger.TryParse(txtP.Text, out p) || !BigInteger.TryParse(txtQ.Text, out q) || !BigInteger.TryParse(txtE.Text, out e))
                {
                    MessageBox.Show("Invalid input. Please enter valid integer values.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if p and q are prime
                if (!IsPrime(p) || !IsPrime(q))
                {
                    MessageBox.Show("p and q must be prime numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Calculate n and phi
                n = p * q;
                phi = (p - 1) * (q - 1);

                // Check if e is valid
                if (e <= 1 || e >= phi || BigInteger.GreatestCommonDivisor(e, phi) != 1)
                {
                    MessageBox.Show("e must be greater than 1, less than φ(n), and coprime with φ(n).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Calculate private key (d)
                d = ModInverse(e, phi);

                // Display keys
                DisplayKeys();
                EnableEncryptionControls();
                keysGenerated = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating keys: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRandomKeys_Click(object sender, EventArgs e)
        {
            try
            {
                // Generate random primes p and q (with a reasonable bit length for demo)
                int bitLength = 8; // For demo, keep it small but can be increased
                p = GenerateRandomPrime(bitLength);
                q = GenerateRandomPrime(bitLength);

                // Calculate n and phi
                n = p * q;
                phi = (p - 1) * (q - 1);

                // Generate a valid e
                e = GenerateValidE(phi);

                // Calculate private key (d)
                d = ModInverse(e, phi);

                // Update UI
                txtP.Text = p.ToString();
                txtQ.Text = q.ToString();
                txtE.Text = e.ToString();

                // Display keys
                DisplayKeys();
                EnableEncryptionControls();
                keysGenerated = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating random keys: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayKeys()
        {
            txtPublicKey.Text = $"e = {e}, n = {n}";
            txtPrivateKey.Text = $"d = {d}, n = {n}";
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (!keysGenerated)
            {
                MessageBox.Show("Please generate keys first.", "Keys Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtMessage.Text))
            {
                MessageBox.Show("Please enter a message to encrypt.", "Missing Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (rbNumber.Checked)
                {
                    // Encrypt as number
                    if (!BigInteger.TryParse(txtMessage.Text, out BigInteger m))
                    {
                        MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (m >= n)
                    {
                        MessageBox.Show($"Message value must be less than n ({n}).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    BigInteger cipher = ModPow(m, e, n);
                    txtResult.Text = cipher.ToString();
                }
                else
                {
                    // Encrypt as string
                    string message = txtMessage.Text;
                    StringBuilder encryptedText = new StringBuilder();

                    foreach (char c in message)
                    {
                        // Convert char to number, encrypt, and store
                        BigInteger m = new BigInteger(c);
                        if (m >= n)
                        {
                            MessageBox.Show($"Character value exceeds the limit (n={n}). Please use smaller keys or shorter message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        BigInteger cipher = ModPow(m, e, n);
                        encryptedText.Append(cipher.ToString());
                        encryptedText.Append(" ");
                    }

                    txtResult.Text = encryptedText.ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Encryption error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (!keysGenerated)
            {
                MessageBox.Show("Please generate keys first.", "Keys Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtMessage.Text))
            {
                MessageBox.Show("Please enter a message to decrypt.", "Missing Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (rbNumber.Checked)
                {
                    // Decrypt as number
                    if (!BigInteger.TryParse(txtMessage.Text, out BigInteger cipher))
                    {
                        MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    BigInteger plaintext = ModPow(cipher, d, n);
                    txtResult.Text = plaintext.ToString();
                }
                else
                {
                    // Decrypt as string
                    string[] encryptedParts = txtMessage.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    StringBuilder decryptedText = new StringBuilder();

                    foreach (string part in encryptedParts)
                    {
                        if (BigInteger.TryParse(part, out BigInteger cipher))
                        {
                            BigInteger plaintext = ModPow(cipher, d, n);
                            char c = (char)((int)plaintext);
                            decryptedText.Append(c);
                        }
                        else
                        {
                            MessageBox.Show("Invalid encrypted format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    txtResult.Text = decryptedText.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Decryption error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper methods for RSA operations
        private bool IsPrime(BigInteger n)
        {
            if (n <= 1)
                return false;
            if (n <= 3)
                return true;
            if (n % 2 == 0 || n % 3 == 0)
                return false;

            for (BigInteger i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                    return false;
            }
            return true;
        }

        private BigInteger ModInverse(BigInteger a, BigInteger m)
        {
            BigInteger m0 = m;
            BigInteger y = 0, x = 1;

            if (m == 1)
                return 0;

            while (a > 1)
            {
                BigInteger q = a / m;
                BigInteger t = m;

                m = a % m;
                a = t;
                t = y;

                y = x - q * y;
                x = t;
            }

            if (x < 0)
                x += m0;

            return x;
        }

        private BigInteger ModPow(BigInteger baseNum, BigInteger exponent, BigInteger modulus)
        {
            return BigInteger.ModPow(baseNum, exponent, modulus);
        }

        private BigInteger GenerateRandomPrime(int bitLength)
        {
            Random rand = new Random();
            BigInteger prime;

            do
            {
                byte[] bytes = new byte[bitLength / 8 + 1];
                rand.NextBytes(bytes);
                bytes[bytes.Length - 1] = 0; // Ensure positive number
                prime = new BigInteger(bytes);

                // Set lowest bit to 1 to ensure odd number
                prime = prime | BigInteger.One;
            } while (!IsPrime(prime));

            return prime;
        }

        private BigInteger GenerateValidE(BigInteger phi)
        {
            // Simple approach: try common values like 3, 5, 17, 65537
            BigInteger[] commonEs = { 3, 5, 17, 65537 };

            foreach (BigInteger candidate in commonEs)
            {
                if (candidate < phi && BigInteger.GreatestCommonDivisor(candidate, phi) == 1)
                    return candidate;
            }

            // If none of the common values work, find another one
            BigInteger e = 65537; // Start with a common value
            while (e < phi)
            {
                if (BigInteger.GreatestCommonDivisor(e, phi) == 1)
                    return e;
                e += 2; // Only consider odd numbers
            }

            // Fallback to a simpler method for small phi
            for (BigInteger i = 3; i < phi; i += 2)
            {
                if (BigInteger.GreatestCommonDivisor(i, phi) == 1)
                    return i;
            }

            throw new Exception("Could not find valid e value");
        }
    }
}