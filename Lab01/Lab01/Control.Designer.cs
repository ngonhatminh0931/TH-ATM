namespace Lab01
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
            this.label_Tittle = new System.Windows.Forms.Label();
            this.button_Task2 = new System.Windows.Forms.Button();
            this.button_Task4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Tittle
            // 
            this.label_Tittle.AutoSize = true;
            this.label_Tittle.BackColor = System.Drawing.Color.LemonChiffon;
            this.label_Tittle.Font = new System.Drawing.Font("Ravie", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Tittle.ForeColor = System.Drawing.Color.Peru;
            this.label_Tittle.Location = new System.Drawing.Point(40, 36);
            this.label_Tittle.Name = "label_Tittle";
            this.label_Tittle.Size = new System.Drawing.Size(672, 54);
            this.label_Tittle.TabIndex = 35;
            this.label_Tittle.Text = "Classical Cryptography";
            // 
            // button_Task2
            // 
            this.button_Task2.AutoSize = true;
            this.button_Task2.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_Task2.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.button_Task2.FlatAppearance.BorderSize = 3;
            this.button_Task2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.button_Task2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.button_Task2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Task2.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Task2.ForeColor = System.Drawing.Color.Peru;
            this.button_Task2.Location = new System.Drawing.Point(70, 126);
            this.button_Task2.Name = "button_Task2";
            this.button_Task2.Size = new System.Drawing.Size(663, 43);
            this.button_Task2.TabIndex = 43;
            this.button_Task2.Text = "Task2: Ceasar Cipher";
            this.button_Task2.UseVisualStyleBackColor = false;
            this.button_Task2.Click += new System.EventHandler(this.button_Task2_Click);
            // 
            // button_Task4
            // 
            this.button_Task4.AutoSize = true;
            this.button_Task4.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_Task4.FlatAppearance.BorderColor = System.Drawing.Color.Peru;
            this.button_Task4.FlatAppearance.BorderSize = 3;
            this.button_Task4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCyan;
            this.button_Task4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.button_Task4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Task4.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Task4.ForeColor = System.Drawing.Color.Peru;
            this.button_Task4.Location = new System.Drawing.Point(70, 210);
            this.button_Task4.Name = "button_Task4";
            this.button_Task4.Size = new System.Drawing.Size(663, 43);
            this.button_Task4.TabIndex = 44;
            this.button_Task4.Text = "Task4: Playfair Cipher";
            this.button_Task4.UseVisualStyleBackColor = false;
            this.button_Task4.Click += new System.EventHandler(this.button_Task4_Click);
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(805, 574);
            this.Controls.Add(this.button_Task4);
            this.Controls.Add(this.button_Task2);
            this.Controls.Add(this.label_Tittle);
            this.Name = "Control";
            this.Text = "Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Tittle;
        private System.Windows.Forms.Button button_Task2;
        private System.Windows.Forms.Button button_Task4;
    }
}