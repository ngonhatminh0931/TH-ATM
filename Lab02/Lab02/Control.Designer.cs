namespace Lab02
{
    partial class Control
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
            this.button_Task2_1 = new System.Windows.Forms.Button();
            this.button_Task1 = new System.Windows.Forms.Button();
            this.label_Tittle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Task2_1
            // 
            this.button_Task2_1.AutoSize = true;
            this.button_Task2_1.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_Task2_1.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.button_Task2_1.FlatAppearance.BorderSize = 3;
            this.button_Task2_1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.button_Task2_1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.button_Task2_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Task2_1.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Task2_1.ForeColor = System.Drawing.Color.Peru;
            this.button_Task2_1.Location = new System.Drawing.Point(60, 214);
            this.button_Task2_1.Name = "button_Task2_1";
            this.button_Task2_1.Size = new System.Drawing.Size(663, 43);
            this.button_Task2_1.TabIndex = 47;
            this.button_Task2_1.Text = "Task2: RSA Public-Key Encryption ";
            this.button_Task2_1.UseVisualStyleBackColor = false;
            this.button_Task2_1.Click += new System.EventHandler(this.button_Task2_Click);
            // 
            // button_Task1
            // 
            this.button_Task1.AutoSize = true;
            this.button_Task1.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_Task1.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.button_Task1.FlatAppearance.BorderSize = 3;
            this.button_Task1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.button_Task1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.button_Task1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Task1.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Task1.ForeColor = System.Drawing.Color.Peru;
            this.button_Task1.Location = new System.Drawing.Point(60, 131);
            this.button_Task1.Name = "button_Task1";
            this.button_Task1.Size = new System.Drawing.Size(663, 43);
            this.button_Task1.TabIndex = 46;
            this.button_Task1.Text = "Task1: Number Theory";
            this.button_Task1.UseVisualStyleBackColor = false;
            this.button_Task1.Click += new System.EventHandler(this.button_Task1_Click);
            // 
            // label_Tittle
            // 
            this.label_Tittle.AutoSize = true;
            this.label_Tittle.BackColor = System.Drawing.Color.LemonChiffon;
            this.label_Tittle.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tittle.ForeColor = System.Drawing.Color.Peru;
            this.label_Tittle.Location = new System.Drawing.Point(51, 36);
            this.label_Tittle.Name = "label_Tittle";
            this.label_Tittle.Size = new System.Drawing.Size(634, 54);
            this.label_Tittle.TabIndex = 45;
            this.label_Tittle.Text = "Modern Cryptography";
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(799, 301);
            this.Controls.Add(this.button_Task2_1);
            this.Controls.Add(this.button_Task1);
            this.Controls.Add(this.label_Tittle);
            this.Name = "Control";
            this.Text = "Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Task2_1;
        private System.Windows.Forms.Button button_Task1;
        private System.Windows.Forms.Label label_Tittle;
    }
}