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
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }

        private void button_Task2_Click(object sender, EventArgs e)
        {
            Form form = new Task2();
            form.Show();
        }

        private void button_Task4_Click(object sender, EventArgs e)
        {
            Form form = new Task4();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form task5 = new Task5();
            task5.Show();
        }
    }
}
