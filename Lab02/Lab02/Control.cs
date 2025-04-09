using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }

        private void button_Task1_Click(object sender, EventArgs e)
        {
            Form form = new Task1();
            form.Show();
        }

        private void button_Task2_Click(object sender, EventArgs e)
        {
            Form form = new Task2_1();
            form.Show();
        }
    }
}
