namespace Lab01
{
    partial class Task2
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
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.label_Key = new System.Windows.Forms.Label();
            this.textBox_Message = new System.Windows.Forms.TextBox();
            this.label_Message = new System.Windows.Forms.Label();
            this.label_Tittle = new System.Windows.Forms.Label();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.label_Result = new System.Windows.Forms.Label();
            this.button_Decrypt = new System.Windows.Forms.Button();
            this.button_Encrypt = new System.Windows.Forms.Button();
            this.button_checkKey = new System.Windows.Forms.Button();
            this.textBox_checkKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_Key
            // 
            this.textBox_Key.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Key.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_Key.Location = new System.Drawing.Point(159, 258);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.Size = new System.Drawing.Size(297, 34);
            this.textBox_Key.TabIndex = 38;
            this.textBox_Key.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Key_KeyPress);
            // 
            // label_Key
            // 
            this.label_Key.AutoSize = true;
            this.label_Key.BackColor = System.Drawing.Color.LemonChiffon;
            this.label_Key.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Key.ForeColor = System.Drawing.Color.Peru;
            this.label_Key.Location = new System.Drawing.Point(25, 258);
            this.label_Key.Name = "label_Key";
            this.label_Key.Size = new System.Drawing.Size(62, 27);
            this.label_Key.TabIndex = 37;
            this.label_Key.Text = "Key";
            // 
            // textBox_Message
            // 
            this.textBox_Message.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Message.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_Message.Location = new System.Drawing.Point(159, 113);
            this.textBox_Message.Multiline = true;
            this.textBox_Message.Name = "textBox_Message";
            this.textBox_Message.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Message.Size = new System.Drawing.Size(297, 117);
            this.textBox_Message.TabIndex = 36;
            // 
            // label_Message
            // 
            this.label_Message.AutoSize = true;
            this.label_Message.BackColor = System.Drawing.Color.LemonChiffon;
            this.label_Message.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Message.ForeColor = System.Drawing.Color.Peru;
            this.label_Message.Location = new System.Drawing.Point(25, 113);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(128, 27);
            this.label_Message.TabIndex = 35;
            this.label_Message.Text = "Message";
            // 
            // label_Tittle
            // 
            this.label_Tittle.AutoSize = true;
            this.label_Tittle.BackColor = System.Drawing.Color.LemonChiffon;
            this.label_Tittle.Font = new System.Drawing.Font("Ravie", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tittle.ForeColor = System.Drawing.Color.Peru;
            this.label_Tittle.Location = new System.Drawing.Point(199, 9);
            this.label_Tittle.Name = "label_Tittle";
            this.label_Tittle.Size = new System.Drawing.Size(605, 81);
            this.label_Tittle.TabIndex = 39;
            this.label_Tittle.Text = "Ceasar Cipher";
            // 
            // textBox_Result
            // 
            this.textBox_Result.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Result.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_Result.Location = new System.Drawing.Point(652, 113);
            this.textBox_Result.Multiline = true;
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_Result.Size = new System.Drawing.Size(297, 117);
            this.textBox_Result.TabIndex = 41;
            // 
            // label_Result
            // 
            this.label_Result.AutoSize = true;
            this.label_Result.BackColor = System.Drawing.Color.LemonChiffon;
            this.label_Result.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Result.ForeColor = System.Drawing.Color.Peru;
            this.label_Result.Location = new System.Drawing.Point(514, 113);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(102, 27);
            this.label_Result.TabIndex = 40;
            this.label_Result.Text = "Result";
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
            this.button_Decrypt.Location = new System.Drawing.Point(308, 315);
            this.button_Decrypt.Name = "button_Decrypt";
            this.button_Decrypt.Size = new System.Drawing.Size(143, 43);
            this.button_Decrypt.TabIndex = 43;
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
            this.button_Encrypt.Location = new System.Drawing.Point(159, 315);
            this.button_Encrypt.Name = "button_Encrypt";
            this.button_Encrypt.Size = new System.Drawing.Size(143, 43);
            this.button_Encrypt.TabIndex = 42;
            this.button_Encrypt.Text = "Encrypt";
            this.button_Encrypt.UseVisualStyleBackColor = false;
            this.button_Encrypt.Click += new System.EventHandler(this.button_Encrypt_Click);
            // 
            // button_checkKey
            // 
            this.button_checkKey.AutoSize = true;
            this.button_checkKey.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_checkKey.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.button_checkKey.FlatAppearance.BorderSize = 3;
            this.button_checkKey.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.button_checkKey.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.button_checkKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_checkKey.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_checkKey.ForeColor = System.Drawing.Color.Peru;
            this.button_checkKey.Location = new System.Drawing.Point(30, 378);
            this.button_checkKey.Name = "button_checkKey";
            this.button_checkKey.Size = new System.Drawing.Size(162, 43);
            this.button_checkKey.TabIndex = 44;
            this.button_checkKey.Text = "Check Key";
            this.button_checkKey.UseVisualStyleBackColor = false;
            this.button_checkKey.Click += new System.EventHandler(this.button_checkKey_Click);
            // 
            // textBox_checkKey
            // 
            this.textBox_checkKey.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_checkKey.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_checkKey.Location = new System.Drawing.Point(30, 427);
            this.textBox_checkKey.Multiline = true;
            this.textBox_checkKey.Name = "textBox_checkKey";
            this.textBox_checkKey.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_checkKey.Size = new System.Drawing.Size(919, 173);
            this.textBox_checkKey.TabIndex = 45;
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1009, 621);
            this.Controls.Add(this.textBox_checkKey);
            this.Controls.Add(this.button_checkKey);
            this.Controls.Add(this.button_Decrypt);
            this.Controls.Add(this.button_Encrypt);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.label_Result);
            this.Controls.Add(this.label_Tittle);
            this.Controls.Add(this.textBox_Key);
            this.Controls.Add(this.label_Key);
            this.Controls.Add(this.textBox_Message);
            this.Controls.Add(this.label_Message);
            this.Name = "Task2";
            this.Text = "Task2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_Key;
        private System.Windows.Forms.Label label_Key;
        private System.Windows.Forms.TextBox textBox_Message;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.Label label_Tittle;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Label label_Result;
        private System.Windows.Forms.Button button_Decrypt;
        private System.Windows.Forms.Button button_Encrypt;
        private System.Windows.Forms.Button button_checkKey;
        private System.Windows.Forms.TextBox textBox_checkKey;
    }
}