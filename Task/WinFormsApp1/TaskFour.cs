using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class TaskFour : Form
    {
        public TaskFour()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] text = this.textBox1.Text.Split('_');
            string[] x = text[0].Split(' ');
            int[,] array = new int[text.Length, x.Length];
            for (int i = 0; i < text.Length; i++)
            {
                string[] item = text[i].Split(' ');
                for (int j = 0; j < item.Length; j++)
                {
                    array[i, j] = Convert.ToInt32(item[j]);
                }
            }
            string[] textTwo = this.textBox1.Text.Split('_');
            string[] x2 = textTwo[0].Split(' ');
            int[,] arrayTwo = new int[text.Length, x2.Length];
            for (int i = 0; i < textTwo.Length; i++)
            {
                string[] item = textTwo[i].Split(' ');
                for (int j = 0; j < item.Length; j++)
                {
                    arrayTwo[i, j] = Convert.ToInt32(item[j]);
                }
            }
            int[,] arr = ArrSum(array, arrayTwo);
            textBox3.Clear();
            for(int i = 0;i < arr.GetLength(0);i++)
            {
                for(int j = 0; j < arr.GetLength(1);j++)
                {
                    this.textBox3.Text += arr[i, j].ToString() + " ";
                }
                this.textBox3.Text += Environment.NewLine;
            }    

        }
        public int[,] ArrSum(int[,] a, int[,] b)
        {
            if(a.GetLength(0) == b.GetLength(0) && a.GetLength(1) == b.GetLength(1))
            {
                int[,] myArray = new int[a.GetLength(0), b.GetLength(1)];
                for(int i = 0; i < a.GetLength(0); i++)
                {
                    for(int j = 0; j < b.GetLength(1);j++)
                    {
                        myArray[i, j] = a[i, j] + b[i,j];
                    }
                }
                return myArray;
            }
            else
            {
                MessageBox.Show("Разные размеры массивов");
                return new int[1, 1];
            }
        }
    }
}
