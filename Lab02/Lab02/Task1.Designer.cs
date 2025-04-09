namespace Lab02
{
    partial class Task1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Tittle = new System.Windows.Forms.Label();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.label_Result = new System.Windows.Forms.Label();
            this.comboBox_Size = new System.Windows.Forms.ComboBox();
            this.label_1a = new System.Windows.Forms.Label();
            this.button_GenerateRandPrime = new System.Windows.Forms.Button();
            this.label_Size = new System.Windows.Forms.Label();
            this.label_1b = new System.Windows.Forms.Label();
            this.button_DetermineTopMersenne = new System.Windows.Forms.Button();
            this.button_CheckPrime = new System.Windows.Forms.Button();
            this.label_1c = new System.Windows.Forms.Label();
            this.textBox_LargeInt1c = new System.Windows.Forms.TextBox();
            this.label_Enter = new System.Windows.Forms.Label();
            this.label_Base = new System.Windows.Forms.Label();
            this.textBox_Base = new System.Windows.Forms.TextBox();
            this.textBox_Exponent = new System.Windows.Forms.TextBox();
            this.label_Exponent = new System.Windows.Forms.Label();
            this.button_GetLargeInt_1c = new System.Windows.Forms.Button();
            this.button_GetLargeInt_21 = new System.Windows.Forms.Button();
            this.textBox_LargeInt21 = new System.Windows.Forms.TextBox();
            this.button_DetermineGCD = new System.Windows.Forms.Button();
            this.label_2 = new System.Windows.Forms.Label();
            this.button_GetLargeInt_22 = new System.Windows.Forms.Button();
            this.textBox_LargeInt22 = new System.Windows.Forms.TextBox();
            this.textBox_Modulo = new System.Windows.Forms.TextBox();
            this.button_GetLargeInt_3 = new System.Windows.Forms.Button();
            this.textBox_LargeInt3 = new System.Windows.Forms.TextBox();
            this.button_Compute = new System.Windows.Forms.Button();
            this.label_3 = new System.Windows.Forms.Label();
            this.label_Modulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Tittle
            // 
            this.label_Tittle.AutoSize = true;
            this.label_Tittle.BackColor = System.Drawing.Color.LemonChiffon;
            this.label_Tittle.Font = new System.Drawing.Font("Ravie", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tittle.ForeColor = System.Drawing.Color.Peru;
            this.label_Tittle.Location = new System.Drawing.Point(363, 9);
            this.label_Tittle.Name = "label_Tittle";
            this.label_Tittle.Size = new System.Drawing.Size(658, 81);
            this.label_Tittle.TabIndex = 40;
            this.label_Tittle.Text = "Number Theory";
            // 
            // textBox_Result
            // 
            this.textBox_Result.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Result.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_Result.Location = new System.Drawing.Point(893, 567);
            this.textBox_Result.Multiline = true;
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Result.Size = new System.Drawing.Size(398, 182);
            this.textBox_Result.TabIndex = 43;
            // 
            // label_Result
            // 
            this.label_Result.AutoSize = true;
            this.label_Result.BackColor = System.Drawing.Color.LemonChiffon;
            this.label_Result.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Result.ForeColor = System.Drawing.Color.Peru;
            this.label_Result.Location = new System.Drawing.Point(746, 567);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(102, 27);
            this.label_Result.TabIndex = 42;
            this.label_Result.Text = "Result";
            // 
            // comboBox_Size
            // 
            this.comboBox_Size.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Size.FormattingEnabled = true;
            this.comboBox_Size.Items.AddRange(new object[] {
            "8",
            "16",
            "64"});
            this.comboBox_Size.Location = new System.Drawing.Point(840, 156);
            this.comboBox_Size.Name = "comboBox_Size";
            this.comboBox_Size.Size = new System.Drawing.Size(138, 35);
            this.comboBox_Size.TabIndex = 44;
            // 
            // label_1a
            // 
            this.label_1a.AutoSize = true;
            this.label_1a.BackColor = System.Drawing.Color.LemonChiffon;
            this.label_1a.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_1a.ForeColor = System.Drawing.Color.Peru;
            this.label_1a.Location = new System.Drawing.Point(746, 111);
            this.label_1a.Name = "label_1a";
            this.label_1a.Size = new System.Drawing.Size(460, 27);
            this.label_1a.TabIndex = 45;
            this.label_1a.Text = "Generate a random prime number";
            // 
            // button_GenerateRandPrime
            // 
            this.button_GenerateRandPrime.AutoSize = true;
            this.button_GenerateRandPrime.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_GenerateRandPrime.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.button_GenerateRandPrime.FlatAppearance.BorderSize = 3;
            this.button_GenerateRandPrime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.button_GenerateRandPrime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.button_GenerateRandPrime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_GenerateRandPrime.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GenerateRandPrime.ForeColor = System.Drawing.Color.Peru;
            this.button_GenerateRandPrime.Location = new System.Drawing.Point(1142, 152);
            this.button_GenerateRandPrime.Name = "button_GenerateRandPrime";
            this.button_GenerateRandPrime.Size = new System.Drawing.Size(149, 43);
            this.button_GenerateRandPrime.TabIndex = 46;
            this.button_GenerateRandPrime.Text = "Generate";
            this.button_GenerateRandPrime.UseVisualStyleBackColor = false;
            this.button_GenerateRandPrime.Click += new System.EventHandler(this.button_GenerateRandPrime_Click);
            // 
            // label_Size
            // 
            this.label_Size.AutoSize = true;
            this.label_Size.BackColor = System.Drawing.Color.LemonChiffon;
            this.label_Size.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Size.ForeColor = System.Drawing.Color.Peru;
            this.label_Size.Location = new System.Drawing.Point(746, 160);
            this.label_Size.Name = "label_Size";
            this.label_Size.Size = new System.Drawing.Size(68, 27);
            this.label_Size.TabIndex = 47;
            this.label_Size.Text = "Size";
            // 
            // label_1b
            // 
            this.label_1b.AutoSize = true;
            this.label_1b.BackColor = System.Drawing.Color.LemonChiffon;
            this.label_1b.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_1b.ForeColor = System.Drawing.Color.Peru;
            this.label_1b.Location = new System.Drawing.Point(746, 236);
            this.label_1b.Name = "label_1b";
            this.label_1b.Size = new System.Drawing.Size(525, 54);
            this.label_1b.TabIndex = 48;
            this.label_1b.Text = "The 10 largest prime numbers under 10\r\nfirst Mersenne prime numbers";
            // 
            // button_DetermineTopMersenne
            // 
            this.button_DetermineTopMersenne.AutoSize = true;
            this.button_DetermineTopMersenne.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_DetermineTopMersenne.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.button_DetermineTopMersenne.FlatAppearance.BorderSize = 3;
            this.button_DetermineTopMersenne.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.button_DetermineTopMersenne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.button_DetermineTopMersenne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DetermineTopMersenne.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DetermineTopMersenne.ForeColor = System.Drawing.Color.Peru;
            this.button_DetermineTopMersenne.Location = new System.Drawing.Point(751, 309);
            this.button_DetermineTopMersenne.Name = "button_DetermineTopMersenne";
            this.button_DetermineTopMersenne.Size = new System.Drawing.Size(540, 43);
            this.button_DetermineTopMersenne.TabIndex = 49;
            this.button_DetermineTopMersenne.Text = "Determine";
            this.button_DetermineTopMersenne.UseVisualStyleBackColor = false;
            this.button_DetermineTopMersenne.Click += new System.EventHandler(this.button_DetermineTopMersenne_Click);
            // 
            // button_CheckPrime
            // 
            this.button_CheckPrime.AutoSize = true;
            this.button_CheckPrime.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_CheckPrime.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.button_CheckPrime.FlatAppearance.BorderSize = 3;
            this.button_CheckPrime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.button_CheckPrime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.button_CheckPrime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CheckPrime.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CheckPrime.ForeColor = System.Drawing.Color.Peru;
            this.button_CheckPrime.Location = new System.Drawing.Point(1176, 463);
            this.button_CheckPrime.Name = "button_CheckPrime";
            this.button_CheckPrime.Size = new System.Drawing.Size(115, 43);
            this.button_CheckPrime.TabIndex = 51;
            this.button_CheckPrime.Text = "Check";
            this.button_CheckPrime.UseVisualStyleBackColor = false;
            this.button_CheckPrime.Click += new System.EventHandler(this.button_CheckPrime_Click);
            // 
            // label_1c
            // 
            this.label_1c.AutoSize = true;
            this.label_1c.BackColor = System.Drawing.Color.LemonChiffon;
            this.label_1c.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_1c.ForeColor = System.Drawing.Color.Peru;
            this.label_1c.Location = new System.Drawing.Point(746, 390);
            this.label_1c.Name = "label_1c";
            this.label_1c.Size = new System.Drawing.Size(545, 54);
            this.label_1c.TabIndex = 50;
            this.label_1c.Text = "Check if an arbitrary integer less than\r\n2^89 - 1 is prime or not";
            // 
            // textBox_LargeInt1c
            // 
            this.textBox_LargeInt1c.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_LargeInt1c.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_LargeInt1c.Location = new System.Drawing.Point(1052, 469);
            this.textBox_LargeInt1c.Name = "textBox_LargeInt1c";
            this.textBox_LargeInt1c.Size = new System.Drawing.Size(100, 34);
            this.textBox_LargeInt1c.TabIndex = 54;
            // 
            // label_Enter
            // 
            this.label_Enter.AutoSize = true;
            this.label_Enter.BackColor = System.Drawing.Color.LemonChiffon;
            this.label_Enter.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Enter.ForeColor = System.Drawing.Color.Peru;
            this.label_Enter.Location = new System.Drawing.Point(74, 111);
            this.label_Enter.Name = "label_Enter";
            this.label_Enter.Size = new System.Drawing.Size(273, 27);
            this.label_Enter.TabIndex = 55;
            this.label_Enter.Text = "Enter large integer";
            // 
            // label_Base
            // 
            this.label_Base.AutoSize = true;
            this.label_Base.BackColor = System.Drawing.Color.LemonChiffon;
            this.label_Base.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Base.ForeColor = System.Drawing.Color.Peru;
            this.label_Base.Location = new System.Drawing.Point(74, 158);
            this.label_Base.Name = "label_Base";
            this.label_Base.Size = new System.Drawing.Size(107, 27);
            this.label_Base.TabIndex = 57;
            this.label_Base.Text = "Base(a)";
            // 
            // textBox_Base
            // 
            this.textBox_Base.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Base.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_Base.Location = new System.Drawing.Point(257, 156);
            this.textBox_Base.Name = "textBox_Base";
            this.textBox_Base.Size = new System.Drawing.Size(362, 34);
            this.textBox_Base.TabIndex = 1;
            // 
            // textBox_Exponent
            // 
            this.textBox_Exponent.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Exponent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_Exponent.Location = new System.Drawing.Point(257, 213);
            this.textBox_Exponent.Name = "textBox_Exponent";
            this.textBox_Exponent.Size = new System.Drawing.Size(362, 34);
            this.textBox_Exponent.TabIndex = 60;
            // 
            // label_Exponent
            // 
            this.label_Exponent.AutoSize = true;
            this.label_Exponent.BackColor = System.Drawing.Color.LemonChiffon;
            this.label_Exponent.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Exponent.ForeColor = System.Drawing.Color.Peru;
            this.label_Exponent.Location = new System.Drawing.Point(74, 215);
            this.label_Exponent.Name = "label_Exponent";
            this.label_Exponent.Size = new System.Drawing.Size(166, 27);
            this.label_Exponent.TabIndex = 59;
            this.label_Exponent.Text = "Exponent(x)";
            // 
            // button_GetLargeInt_1c
            // 
            this.button_GetLargeInt_1c.AutoSize = true;
            this.button_GetLargeInt_1c.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_GetLargeInt_1c.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.button_GetLargeInt_1c.FlatAppearance.BorderSize = 3;
            this.button_GetLargeInt_1c.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.button_GetLargeInt_1c.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.button_GetLargeInt_1c.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_GetLargeInt_1c.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GetLargeInt_1c.ForeColor = System.Drawing.Color.Peru;
            this.button_GetLargeInt_1c.Location = new System.Drawing.Point(751, 463);
            this.button_GetLargeInt_1c.Name = "button_GetLargeInt_1c";
            this.button_GetLargeInt_1c.Size = new System.Drawing.Size(270, 43);
            this.button_GetLargeInt_1c.TabIndex = 61;
            this.button_GetLargeInt_1c.Text = "Get Large Integer";
            this.button_GetLargeInt_1c.UseVisualStyleBackColor = false;
            this.button_GetLargeInt_1c.Click += new System.EventHandler(this.button_GetLargeInt_1c_Click);
            // 
            // button_GetLargeInt_21
            // 
            this.button_GetLargeInt_21.AutoSize = true;
            this.button_GetLargeInt_21.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_GetLargeInt_21.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.button_GetLargeInt_21.FlatAppearance.BorderSize = 3;
            this.button_GetLargeInt_21.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.button_GetLargeInt_21.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.button_GetLargeInt_21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_GetLargeInt_21.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GetLargeInt_21.ForeColor = System.Drawing.Color.Peru;
            this.button_GetLargeInt_21.Location = new System.Drawing.Point(79, 371);
            this.button_GetLargeInt_21.Name = "button_GetLargeInt_21";
            this.button_GetLargeInt_21.Size = new System.Drawing.Size(292, 43);
            this.button_GetLargeInt_21.TabIndex = 65;
            this.button_GetLargeInt_21.Text = "Get Large Integer 1";
            this.button_GetLargeInt_21.UseVisualStyleBackColor = false;
            this.button_GetLargeInt_21.Click += new System.EventHandler(this.button_GetLargeInt_21_Click);
            // 
            // textBox_LargeInt21
            // 
            this.textBox_LargeInt21.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_LargeInt21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_LargeInt21.Location = new System.Drawing.Point(405, 380);
            this.textBox_LargeInt21.Name = "textBox_LargeInt21";
            this.textBox_LargeInt21.Size = new System.Drawing.Size(114, 34);
            this.textBox_LargeInt21.TabIndex = 64;
            // 
            // button_DetermineGCD
            // 
            this.button_DetermineGCD.AutoSize = true;
            this.button_DetermineGCD.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_DetermineGCD.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.button_DetermineGCD.FlatAppearance.BorderSize = 3;
            this.button_DetermineGCD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.button_DetermineGCD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.button_DetermineGCD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DetermineGCD.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DetermineGCD.ForeColor = System.Drawing.Color.Peru;
            this.button_DetermineGCD.Location = new System.Drawing.Point(543, 371);
            this.button_DetermineGCD.Name = "button_DetermineGCD";
            this.button_DetermineGCD.Size = new System.Drawing.Size(76, 107);
            this.button_DetermineGCD.TabIndex = 63;
            this.button_DetermineGCD.Text = "GCD";
            this.button_DetermineGCD.UseVisualStyleBackColor = false;
            this.button_DetermineGCD.Click += new System.EventHandler(this.button_DetermineGCD_Click);
            // 
            // label_2
            // 
            this.label_2.AutoSize = true;
            this.label_2.BackColor = System.Drawing.Color.LemonChiffon;
            this.label_2.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_2.ForeColor = System.Drawing.Color.Peru;
            this.label_2.Location = new System.Drawing.Point(74, 298);
            this.label_2.Name = "label_2";
            this.label_2.Size = new System.Drawing.Size(535, 54);
            this.label_2.TabIndex = 62;
            this.label_2.Text = "The greatest common divisor (gcd) of 2\r\narbitrary “large” integers";
            // 
            // button_GetLargeInt_22
            // 
            this.button_GetLargeInt_22.AutoSize = true;
            this.button_GetLargeInt_22.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_GetLargeInt_22.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.button_GetLargeInt_22.FlatAppearance.BorderSize = 3;
            this.button_GetLargeInt_22.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.button_GetLargeInt_22.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.button_GetLargeInt_22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_GetLargeInt_22.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GetLargeInt_22.ForeColor = System.Drawing.Color.Peru;
            this.button_GetLargeInt_22.Location = new System.Drawing.Point(79, 438);
            this.button_GetLargeInt_22.Name = "button_GetLargeInt_22";
            this.button_GetLargeInt_22.Size = new System.Drawing.Size(291, 43);
            this.button_GetLargeInt_22.TabIndex = 68;
            this.button_GetLargeInt_22.Text = "Get Large Integer 2";
            this.button_GetLargeInt_22.UseVisualStyleBackColor = false;
            this.button_GetLargeInt_22.Click += new System.EventHandler(this.button_GetLargeInt_22_Click);
            // 
            // textBox_LargeInt22
            // 
            this.textBox_LargeInt22.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_LargeInt22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_LargeInt22.Location = new System.Drawing.Point(405, 444);
            this.textBox_LargeInt22.Name = "textBox_LargeInt22";
            this.textBox_LargeInt22.Size = new System.Drawing.Size(114, 34);
            this.textBox_LargeInt22.TabIndex = 67;
            // 
            // textBox_Modulo
            // 
            this.textBox_Modulo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Modulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_Modulo.Location = new System.Drawing.Point(230, 715);
            this.textBox_Modulo.Name = "textBox_Modulo";
            this.textBox_Modulo.Size = new System.Drawing.Size(219, 34);
            this.textBox_Modulo.TabIndex = 73;
            // 
            // button_GetLargeInt_3
            // 
            this.button_GetLargeInt_3.AutoSize = true;
            this.button_GetLargeInt_3.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_GetLargeInt_3.CausesValidation = false;
            this.button_GetLargeInt_3.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.button_GetLargeInt_3.FlatAppearance.BorderSize = 3;
            this.button_GetLargeInt_3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.button_GetLargeInt_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.button_GetLargeInt_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_GetLargeInt_3.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GetLargeInt_3.ForeColor = System.Drawing.Color.Peru;
            this.button_GetLargeInt_3.Location = new System.Drawing.Point(80, 648);
            this.button_GetLargeInt_3.Name = "button_GetLargeInt_3";
            this.button_GetLargeInt_3.Size = new System.Drawing.Size(291, 43);
            this.button_GetLargeInt_3.TabIndex = 72;
            this.button_GetLargeInt_3.Text = "Get Large Integer ";
            this.button_GetLargeInt_3.UseVisualStyleBackColor = false;
            this.button_GetLargeInt_3.Click += new System.EventHandler(this.button_GetLargeInt_3_Click);
            // 
            // textBox_LargeInt3
            // 
            this.textBox_LargeInt3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_LargeInt3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_LargeInt3.Location = new System.Drawing.Point(405, 654);
            this.textBox_LargeInt3.Name = "textBox_LargeInt3";
            this.textBox_LargeInt3.Size = new System.Drawing.Size(214, 34);
            this.textBox_LargeInt3.TabIndex = 71;
            // 
            // button_Compute
            // 
            this.button_Compute.AutoSize = true;
            this.button_Compute.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_Compute.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.button_Compute.FlatAppearance.BorderSize = 3;
            this.button_Compute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.button_Compute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.button_Compute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Compute.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Compute.ForeColor = System.Drawing.Color.Peru;
            this.button_Compute.Location = new System.Drawing.Point(477, 709);
            this.button_Compute.Name = "button_Compute";
            this.button_Compute.Size = new System.Drawing.Size(142, 43);
            this.button_Compute.TabIndex = 70;
            this.button_Compute.Text = "Compute";
            this.button_Compute.UseVisualStyleBackColor = false;
            this.button_Compute.Click += new System.EventHandler(this.button_Compute_Click);
            // 
            // label_3
            // 
            this.label_3.AutoSize = true;
            this.label_3.BackColor = System.Drawing.Color.LemonChiffon;
            this.label_3.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_3.ForeColor = System.Drawing.Color.Peru;
            this.label_3.Location = new System.Drawing.Point(74, 567);
            this.label_3.Name = "label_3";
            this.label_3.Size = new System.Drawing.Size(505, 54);
            this.label_3.TabIndex = 69;
            this.label_3.Text = "Compute the modular exponentiation\r\na^x mod p";
            // 
            // label_Modulo
            // 
            this.label_Modulo.AutoSize = true;
            this.label_Modulo.BackColor = System.Drawing.Color.LemonChiffon;
            this.label_Modulo.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Modulo.ForeColor = System.Drawing.Color.Peru;
            this.label_Modulo.Location = new System.Drawing.Point(75, 717);
            this.label_Modulo.Name = "label_Modulo";
            this.label_Modulo.Size = new System.Drawing.Size(136, 27);
            this.label_Modulo.TabIndex = 74;
            this.label_Modulo.Text = "Modulo(p)";
            // 
            // Task1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1396, 794);
            this.Controls.Add(this.label_Modulo);
            this.Controls.Add(this.textBox_Modulo);
            this.Controls.Add(this.button_GetLargeInt_3);
            this.Controls.Add(this.textBox_LargeInt3);
            this.Controls.Add(this.button_Compute);
            this.Controls.Add(this.label_3);
            this.Controls.Add(this.button_GetLargeInt_22);
            this.Controls.Add(this.textBox_LargeInt22);
            this.Controls.Add(this.button_GetLargeInt_21);
            this.Controls.Add(this.textBox_LargeInt21);
            this.Controls.Add(this.button_DetermineGCD);
            this.Controls.Add(this.label_2);
            this.Controls.Add(this.button_GetLargeInt_1c);
            this.Controls.Add(this.textBox_Exponent);
            this.Controls.Add(this.label_Exponent);
            this.Controls.Add(this.textBox_Base);
            this.Controls.Add(this.label_Base);
            this.Controls.Add(this.label_Enter);
            this.Controls.Add(this.textBox_LargeInt1c);
            this.Controls.Add(this.button_CheckPrime);
            this.Controls.Add(this.label_1c);
            this.Controls.Add(this.button_DetermineTopMersenne);
            this.Controls.Add(this.label_1b);
            this.Controls.Add(this.label_Size);
            this.Controls.Add(this.button_GenerateRandPrime);
            this.Controls.Add(this.label_1a);
            this.Controls.Add(this.comboBox_Size);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.label_Result);
            this.Controls.Add(this.label_Tittle);
            this.Name = "Task1";
            this.Text = "Task1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Tittle;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Label label_Result;
        private System.Windows.Forms.ComboBox comboBox_Size;
        private System.Windows.Forms.Label label_1a;
        private System.Windows.Forms.Button button_GenerateRandPrime;
        private System.Windows.Forms.Label label_Size;
        private System.Windows.Forms.Label label_1b;
        private System.Windows.Forms.Button button_DetermineTopMersenne;
        private System.Windows.Forms.Button button_CheckPrime;
        private System.Windows.Forms.Label label_1c;
        private System.Windows.Forms.TextBox textBox_LargeInt1c;
        private System.Windows.Forms.Label label_Enter;
        private System.Windows.Forms.Label label_Base;
        private System.Windows.Forms.TextBox textBox_Base;
        private System.Windows.Forms.TextBox textBox_Exponent;
        private System.Windows.Forms.Label label_Exponent;
        private System.Windows.Forms.Button button_GetLargeInt_1c;
        private System.Windows.Forms.Button button_GetLargeInt_21;
        private System.Windows.Forms.TextBox textBox_LargeInt21;
        private System.Windows.Forms.Button button_DetermineGCD;
        private System.Windows.Forms.Label label_2;
        private System.Windows.Forms.Button button_GetLargeInt_22;
        private System.Windows.Forms.TextBox textBox_LargeInt22;
        private System.Windows.Forms.TextBox textBox_Modulo;
        private System.Windows.Forms.Button button_GetLargeInt_3;
        private System.Windows.Forms.TextBox textBox_LargeInt3;
        private System.Windows.Forms.Button button_Compute;
        private System.Windows.Forms.Label label_3;
        private System.Windows.Forms.Label label_Modulo;
    }
}