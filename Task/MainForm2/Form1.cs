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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void taskOneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOne formOne = new FormOne();
            formOne.Show();
        }

        private void taskTwoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTwo formtwo = new FormTwo();
            formtwo.Show();
        }

        private void taskThreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThree formthree = new FormThree();
            formthree.Show();
        }

        private void taskFourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFour formfour = new FormFour();
            formfour.Show();
        }
    }
}
