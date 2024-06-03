using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);

            int result = num1 + num2;

            label4.Text = result.ToString();
            label4.Visible = true;
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);

            int result = num1 - num2;

            label4.Text = result.ToString();
            label4.Visible = true;
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);

            int result = num1 * num2;

            label4.Text = result.ToString();
            label4.Visible = true;
        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);

            int result = num1 / num2;

            label4.Text = result.ToString();
            label4.Visible = true;
        }
    }
}
