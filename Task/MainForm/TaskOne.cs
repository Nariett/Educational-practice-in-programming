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
    public partial class TaskOne : Form
    {
        public TaskOne()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(this.textBox1.Text);
            double b = Convert.ToDouble(this.textBox2.Text);
            double x = Convert.ToDouble(this.textBox3.Text);
            double result = (a * x - Math.Sqrt(b) / 5.7 * (Math.Pow(x, 2) + Math.Pow(b, 2))) - ((Math.Abs(x+b)-Math.Pow(a,2))/x)*Math.Tan(b)*Math.Tan(b);
            this.textBox4.Text = $"Самойлов Александр Сергеевич {Environment.NewLine}При a = {a}{Environment.NewLine}При b = {b}{Environment.NewLine}" +
                $"При x = {x}{Environment.NewLine}Результат равен = {result.ToString()}";
        }
    }
}
