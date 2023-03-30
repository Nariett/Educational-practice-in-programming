using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MainForm2
{
    public partial class FormTwo : Form
    {
        public FormTwo()
        {
            InitializeComponent();
        }
        public static int[] ArrOne;
        public static int[] ArrTwo;
        private void button1_Click(object sender, EventArgs e)
        {
            string text = this.textBox1.Text;
            string[] TextArrayOne = text.Split(' ');
            int textLengthOne = TextArrayOne.Length;
            int[] IntArrayOne = new int[textLengthOne];
            string text2 = this.textBox2.Text;
            string[] TextArrayTwo = text2.Split(' ');
            int textLengthTwo = TextArrayTwo.Length;
            int[] IntArrayTwo = new int[textLengthOne];
            for (int i = 0; i < textLengthOne; i++)
            {
                IntArrayOne[i] = Convert.ToInt32(TextArrayOne[i]);
                IntArrayTwo[i] = Convert.ToInt32(TextArrayTwo[i]);
            }
            ArrOne = IntArrayOne;
            ArrTwo = IntArrayTwo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> newArr = new List<int>();
                for (int i = 0; i < ArrOne.Length; i++)
                {
                    newArr.Add(ArrOne[i]);
                }
                for (int i = 0; i < ArrTwo.Length; i++)
                {
                    newArr.Add(ArrTwo[i]);
                }
                newArr = newArr.Distinct().ToList();
                this.textBox1.Clear();
                for (int i = 0; i < newArr.Count; i++)
                {
                    this.textBox1.Text += newArr[i] + Environment.NewLine;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Сначала добавьте массив","Error");
            }



        }
    }
}
