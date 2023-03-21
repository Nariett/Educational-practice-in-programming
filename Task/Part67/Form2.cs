using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part67
{

    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 forma = (Form1)this.Owner;
            forma.PointInfo = GetData();
            this.Close();
        }
        public DataPoint GetData()
        {
            int X1 = Convert.ToInt32(this.textBox1.Text);
            int Y1 = Convert.ToInt32(this.textBox2.Text);
            int X2 = Convert.ToInt32(this.textBox3.Text);
            int Y2 = Convert.ToInt32(this.textBox4.Text);
            Color Color = Color.Red;
            if (radioButton1.Checked == true)
            {
                Color = Color.Red;
            }
            if (radioButton2.Checked == true)
            {
                Color = Color.Blue;
            }
            else Color = Color.Green;
            DataPoint DataX = new DataPoint(X1, Y1, X2, Y2, Color);
            return DataX;
        }

    }
}
