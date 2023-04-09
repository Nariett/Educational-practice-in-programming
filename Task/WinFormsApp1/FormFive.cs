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
    public partial class FormFive : Form
    {
        public FormFive()
        {
            InitializeComponent();
        }

        static int RecursiveSum(int[] array)
        {
            int n = array.Length;
            if (n == 1) // базовый случай
            {
                return array[0];
            }
            else
            {
                int[] leftArray = new int[n / 2];
                int[] rightArray = new int[n - n / 2];
                Array.Copy(array, 0, leftArray, 0, n / 2);
                Array.Copy(array, n / 2, rightArray, 0, n - n / 2); 
                int leftSum = RecursiveSum(leftArray); 
                int rightSum = RecursiveSum(rightArray); 
                return leftSum + rightSum; 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] textArray = this.textBox1.Text.Split(' ');
            int[] arr = new int[textArray.Length];
            for(int i = 0; i < textArray.Length;i++)
            {
                arr[i] = Convert.ToInt32(textArray[i]);
            }
            this.textBox1.Clear();
            this.textBox1.Text = RecursiveSum(arr).ToString();
        }
    }
}
