using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm2
{
    public partial class FormOne : Form
    {
        public FormOne()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = this.textBox1.Text;
            string[] textArr = text.Split(' ');
            this.textBox1.Text = $"{textArr[1]} {textArr[0]}";
        }
    }
}
