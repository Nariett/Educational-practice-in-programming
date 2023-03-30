using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class TaskThree : Form
    {
        public TaskThree()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(this.textBox1.Text);
            double xk = Convert.ToDouble(this.textBox2.Text);
            double dx = Convert.ToDouble(this.textBox3.Text);
            for (double x = x0; x <= xk; x += dx)
            {
                var result = Math.Pow(Math.Log10(Math.Sin((Math.Pow(x, 3) + 0.0025))), 1.5) + 0.8 * Math.Pow(10, -3);
                this.textBox4.Text += $"При x = {x} y = {result.ToString()}" + Environment.NewLine;
            }
        }
    }
}
