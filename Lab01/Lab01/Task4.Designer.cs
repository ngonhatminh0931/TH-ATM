namespace Lab01
{
    partial class Task4
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
            this.textBox_Message = new System.Windows.Forms.TextBox();
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.label_Key = new System.Windows.Forms.Label();
            this.label_Message = new System.Windows.Forms.Label();
            this.label_KeyMatrix = new System.Windows.Forms.Label();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.label_Result = new System.Windows.Forms.Label();
            this.button_Encrypt = new System.Windows.Forms.Button();
            this.tableLayoutPanel_KeyMatrix = new System.Windows.Forms.TableLayoutPanel();
            this.button_Decrypt = new System.Windows.Forms.Button();
            this.radioButton_6x6 = new System.Windows.Forms.RadioButton();
            this.radioButton_5x5 = new System.Windows.Forms.RadioButton();
            this.label_Tittle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Message
            // 
            this.textBox_Message.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Message.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_Message.Location = new System.Drawing.Point(166, 197);
            this.textBox_Message.Multiline = true;
            this.textBox_Message.Name = "textBox_Message";
            this.textBox_Message.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Message.Size = new System.Drawing.Size(297, 184);
            this.textBox_Message.TabIndex = 1;
            this.textBox_Message.TextChanged += new System.EventHandler(this.textBox_Message_TextChanged);
            // 
            // textBox_Key
            // 
            this.textBox_Key.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Key.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_Key.Location = new System.Drawing.Point(166, 417);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.Size = new System.Drawing.Size(297, 34);
            this.textBox_Key.TabIndex = 3;
            this.textBox_Key.TextChanged += new System.EventHandler(this.textBox_Key_TextChanged);
            // 
            // label_Key
            // 
            this.label_Key.AutoSize = true;
            this.label_Key.BackColor = System.Drawing.Color.LemonChiffon;
            this.label_Key.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Key.ForeColor = System.Drawing.Color.Peru;
            this.label_Key.Location = new System.Drawing.Point(32, 417);
            this.label_Key.Name = "label_Key";
            this.label_Key.Size = new System.Drawing.Size(62, 27);
            this.label_Key.TabIndex = 2;
            this.label_Key.Text = "Key";
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.BackColor = System.Drawing.Color.LemonChiffon;
            this.label_Message.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Message.ForeColor = System.Drawing.Color.Peru;
            this.label_Message.Location = new System.Drawing.Point(32, 201);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(128, 27);
            this.label_Message.TabIndex = 0;
            this.label_Message.Text = "Message";
            // 
            // label_KeyMatrix
            // 
            this.label_KeyMatrix.AutoSize = true;
            this.label_KeyMatrix.BackColor = System.Drawing.Color.LemonChiffon;
            this.label_KeyMatrix.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_KeyMatrix.ForeColor = System.Drawing.Color.Peru;
            this.label_KeyMatrix.Location = new System.Drawing.Point(589, 21);
            this.label_KeyMatrix.Name = "label_KeyMatrix";
            this.label_KeyMatrix.Size = new System.Drawing.Size(170, 27);
            this.label_KeyMatrix.TabIndex = 5;
            this.label_KeyMatrix.Text = "Key Matrix";
            // 
            // textBox_Result
            // 
            this.textBox_Result.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Result.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_Result.Location = new System.Drawing.Point(882, 62);
            this.textBox_Result.Multiline = true;
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Result.Size = new System.Drawing.Size(297, 389);
            this.textBox_Result.TabIndex = 7;
            // 
            // label_Result
            // 
            this.label_Result.AutoSize = true;
            this.label_Result.BackColor = System.Drawing.Color.LemonChiffon;
            this.label_Result.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Result.ForeColor = System.Drawing.Color.Peru;
            this.label_Result.Location = new System.Drawing.Point(971, 21);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(102, 27);
            this.label_Result.TabIndex = 6;
            this.label_Result.Text = "Result";
            // 
            // button_Encrypt
            // 
            this.button_Encrypt.AutoSize = true;
            this.button_Encrypt.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_Encrypt.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.button_Encrypt.FlatAppearance.BorderSize = 3;
            this.button_Encrypt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.button_Encrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.button_Encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Encrypt.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Encrypt.ForeColor = System.Drawing.Color.Peru;
            this.button_Encrypt.Location = new System.Drawing.Point(546, 338);
            this.button_Encrypt.Name = "button_Encrypt";
            this.button_Encrypt.Size = new System.Drawing.Size(143, 43);
            this.button_Encrypt.TabIndex = 26;
            this.button_Encrypt.Text = "Encrypt";
            this.button_Encrypt.UseVisualStyleBackColor = false;
            this.button_Encrypt.Click += new System.EventHandler(this.button_Encrypt_Click);
            // 
            // tableLayoutPanel_KeyMatrix
            // 
            this.tableLayoutPanel_KeyMatrix.ColumnCount = 2;
            this.tableLayoutPanel_KeyMatrix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_KeyMatrix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_KeyMatrix.Location = new System.Drawing.Point(534, 62);
            this.tableLayoutPanel_KeyMatrix.Name = "tableLayoutPanel_KeyMatrix";
            this.tableLayoutPanel_KeyMatrix.RowCount = 2;
            this.tableLayoutPanel_KeyMatrix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_KeyMatrix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel_KeyMatrix.Size = new System.Drawing.Size(297, 254);
            this.tableLayoutPanel_KeyMatrix.TabIndex = 27;
            // 
            // button_Decrypt
            // 
            this.button_Decrypt.AutoSize = true;
            this.button_Decrypt.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_Decrypt.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.button_Decrypt.FlatAppearance.BorderSize = 3;
            this.button_Decrypt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.button_Decrypt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.button_Decrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Decrypt.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Decrypt.ForeColor = System.Drawing.Color.Peru;
            this.button_Decrypt.Location = new System.Drawing.Point(546, 408);
            this.button_Decrypt.Name = "button_Decrypt";
            this.button_Decrypt.Size = new System.Drawing.Size(143, 43);
            this.button_Decrypt.TabIndex = 30;
            this.button_Decrypt.Text = "Decrypt";
            this.button_Decrypt.UseVisualStyleBackColor = false;
            this.button_Decrypt.Click += new System.EventHandler(this.button_Decrypt_Click);
            // 
            // radioButton_6x6
            // 
            this.radioButton_6x6.AutoSize = true;
            this.radioButton_6x6.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_6x6.ForeColor = System.Drawing.Color.Peru;
            this.radioButton_6x6.Location = new System.Drawing.Point(750, 413);
            this.radioButton_6x6.Name = "radioButton_6x6";
            this.radioButton_6x6.Size = new System.Drawing.Size(81, 31);
            this.radioButton_6x6.TabIndex = 29;
            this.radioButton_6x6.TabStop = true;
            this.radioButton_6x6.Text = "6x6";
            this.radioButton_6x6.UseVisualStyleBackColor = true;
            // 
            // radioButton_5x5
            // 
            this.radioButton_5x5.AutoSize = true;
            this.radioButton_5x5.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_5x5.ForeColor = System.Drawing.Color.Peru;
            this.radioButton_5x5.Location = new System.Drawing.Point(750, 344);
            this.radioButton_5x5.Name = "radioButton_5x5";
            this.radioButton_5x5.Size = new System.Drawing.Size(81, 31);
            this.radioButton_5x5.TabIndex = 28;
            this.radioButton_5x5.TabStop = true;
            this.radioButton_5x5.Text = "5x5";
            this.radioButton_5x5.UseVisualStyleBackColor = true;
            this.radioButton_5x5.CheckedChanged += new System.EventHandler(this.radioButton_5x5_CheckedChanged);
            // 
            // label_Tittle
            // 
            this.label_Tittle.AutoSize = true;
            this.label_Tittle.BackColor = System.Drawing.Color.LemonChiffon;
            this.label_Tittle.Font = new System.Drawing.Font("Ravie", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tittle.ForeColor = System.Drawing.Color.Peru;
            this.label_Tittle.Location = new System.Drawing.Point(23, 21);
            this.label_Tittle.Name = "label_Tittle";
            this.label_Tittle.Size = new System.Drawing.Size(414, 162);
            this.label_Tittle.TabIndex = 34;
            this.label_Tittle.Text = "Playfair \r\nCipher";
            // 
            // Task4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1260, 501);
            this.Controls.Add(this.label_Tittle);
            this.Controls.Add(this.button_Decrypt);
            this.Controls.Add(this.radioButton_6x6);
            this.Controls.Add(this.radioButton_5x5);
            this.Controls.Add(this.tableLayoutPanel_KeyMatrix);
            this.Controls.Add(this.button_Encrypt);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.label_Result);
            this.Controls.Add(this.label_KeyMatrix);
            this.Controls.Add(this.textBox_Key);
            this.Controls.Add(this.label_Key);
            this.Controls.Add(this.textBox_Message);
            this.Controls.Add(this.label_Message);
            this.Name = "Task4";
            this.Text = "Task4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_Message;
        private System.Windows.Forms.TextBox textBox_Key;
        private System.Windows.Forms.Label label_Key;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.Label label_KeyMatrix;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Label label_Result;
        private System.Windows.Forms.Button button_Encrypt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_KeyMatrix;
        private System.Windows.Forms.Button button_Decrypt;
        private System.Windows.Forms.RadioButton radioButton_6x6;
        private System.Windows.Forms.RadioButton radioButton_5x5;
        private System.Windows.Forms.Label label_Tittle;
    }
}