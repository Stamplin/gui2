using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            originNum.Text = "88 + 420 = " + (44 + 420);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            originNum.Text = "88 ? 420 = ?";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void negButton_Click(object sender, EventArgs e)
        {
            originNum.Text = "88 - 420 = " + (44 - 420);
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            originNum.Text = "88 / 420 = " + (44.0 / 420.0);
        }

        private void mutiplicationButton_Click(object sender, EventArgs e)
        {
            originNum.Text = "88 * 420 = " + (44 * 420);
        }
    }
}
