namespace Lab01
{
    partial class Task5
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
            this.button_Decrypt = new System.Windows.Forms.Button();
            this.button_Encrypt = new System.Windows.Forms.Button();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.label_Result = new System.Windows.Forms.Label();
            this.label_Tittle = new System.Windows.Forms.Label();
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.label_Key = new System.Windows.Forms.Label();
            this.textBox_Message = new System.Windows.Forms.TextBox();
            this.label_Message = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.button_Decrypt.Location = new System.Drawing.Point(1027, 195);
            this.button_Decrypt.Margin = new System.Windows.Forms.Padding(4);
            this.button_Decrypt.Name = "button_Decrypt";
            this.button_Decrypt.Size = new System.Drawing.Size(263, 64);
            this.button_Decrypt.TabIndex = 54;
            this.button_Decrypt.Text = "Decrypt";
            this.button_Decrypt.UseVisualStyleBackColor = false;
            this.button_Decrypt.Click += new System.EventHandler(this.button_Decrypt_Click);
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
            this.button_Encrypt.Location = new System.Drawing.Point(734, 195);
            this.button_Encrypt.Margin = new System.Windows.Forms.Padding(4);
            this.button_Encrypt.Name = "button_Encrypt";
            this.button_Encrypt.Size = new System.Drawing.Size(266, 64);
            this.button_Encrypt.TabIndex = 53;
            this.button_Encrypt.Text = "Encrypt";
            this.button_Encrypt.UseVisualStyleBackColor = false;
            this.button_Encrypt.Click += new System.EventHandler(this.button_Encrypt_Click);
            // 
            // textBox_Result
            // 
            this.textBox_Result.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Result.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_Result.Location = new System.Drawing.Point(734, 334);
            this.textBox_Result.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Result.Multiline = true;
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Result.Size = new System.Drawing.Size(556, 107);
            this.textBox_Result.TabIndex = 52;
            // 
            // label_Result
            // 
            this.label_Result.AutoSize = true;
            this.label_Result.BackColor = System.Drawing.Color.LemonChiffon;
            this.label_Result.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Result.ForeColor = System.Drawing.Color.Peru;
            this.label_Result.Location = new System.Drawing.Point(727, 292);
            this.label_Result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(142, 38);
            this.label_Result.TabIndex = 51;
            this.label_Result.Text = "Result";
            // 
            // label_Tittle
            // 
            this.label_Tittle.AutoSize = true;
            this.label_Tittle.BackColor = System.Drawing.Color.LemonChiffon;
            this.label_Tittle.Font = new System.Drawing.Font("Ravie", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tittle.ForeColor = System.Drawing.Color.Peru;
            this.label_Tittle.Location = new System.Drawing.Point(248, 24);
            this.label_Tittle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Tittle.Name = "label_Tittle";
            this.label_Tittle.Size = new System.Drawing.Size(953, 111);
            this.label_Tittle.TabIndex = 50;
            this.label_Tittle.Text = "Vigenère Cipher";
            // 
            // textBox_Key
            // 
            this.textBox_Key.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Key.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_Key.Location = new System.Drawing.Point(244, 397);
            this.textBox_Key.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.Size = new System.Drawing.Size(407, 44);
            this.textBox_Key.TabIndex = 49;
            // 
            // label_Key
            // 
            this.label_Key.AutoSize = true;
            this.label_Key.BackColor = System.Drawing.Color.LemonChiffon;
            this.label_Key.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Key.ForeColor = System.Drawing.Color.Peru;
            this.label_Key.Location = new System.Drawing.Point(59, 397);
            this.label_Key.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Key.Name = "label_Key";
            this.label_Key.Size = new System.Drawing.Size(88, 38);
            this.label_Key.TabIndex = 48;
            this.label_Key.Text = "Key";
            // 
            // textBox_Message
            // 
            this.textBox_Message.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Message.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_Message.Location = new System.Drawing.Point(244, 180);
            this.textBox_Message.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Message.Multiline = true;
            this.textBox_Message.Name = "textBox_Message";
            this.textBox_Message.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Message.Size = new System.Drawing.Size(407, 174);
            this.textBox_Message.TabIndex = 47;
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.BackColor = System.Drawing.Color.LemonChiffon;
            this.label_Message.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Message.ForeColor = System.Drawing.Color.Peru;
            this.label_Message.Location = new System.Drawing.Point(59, 180);
            this.label_Message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(179, 38);
            this.label_Message.TabIndex = 46;
            this.label_Message.Text = "Message";
            // 
            // Task5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1387, 576);
            this.Controls.Add(this.button_Decrypt);
            this.Controls.Add(this.button_Encrypt);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.label_Result);
            this.Controls.Add(this.label_Tittle);
            this.Controls.Add(this.textBox_Key);
            this.Controls.Add(this.label_Key);
            this.Controls.Add(this.textBox_Message);
            this.Controls.Add(this.label_Message);
            this.Name = "Task5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Decrypt;
        private System.Windows.Forms.Button button_Encrypt;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Label label_Result;
        private System.Windows.Forms.Label label_Tittle;
        private System.Windows.Forms.TextBox textBox_Key;
        private System.Windows.Forms.Label label_Key;
        private System.Windows.Forms.TextBox textBox_Message;
        private System.Windows.Forms.Label label_Message;
    }
}