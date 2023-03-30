using System;
using System.Threading;
using System.Windows.Forms;

namespace MainForm2
{
    public partial class FormThree : Form
    {
        public FormThree()
        {
            InitializeComponent();
        }
        public int[,] area = new int[8, 8];
        public int stroka;
        public int stolb;

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 8;
            dataGridView1.ColumnCount = 8;
            Random rnd = new Random();
            stroka = rnd.Next(0, 8);
            stolb = rnd.Next(0, 8);
            area[stroka, stolb] = 1;
            dataGridView1.Rows[stroka].Cells[stolb].Value = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread CheckThread = new Thread(Check);
            CheckThread.Start();
        }
        public void Check()
        {
            while(true)
            {
                if (stroka - 2 >= 0 && stolb + 1 <= 7 && Convert.ToInt32(dataGridView1.Rows[stroka - 2].Cells[stolb + 1].Value) != 1)//вверх  право
                {
                    stroka -= 2;
                    stolb += 1;
                    area[stroka, stolb] = 1;
                    dataGridView1.Rows[stroka].Cells[stolb].Value = 1;
                }
                else if (stroka - 2 >= 0 && stolb - 1 > 0 && Convert.ToInt32(dataGridView1.Rows[stroka - 2].Cells[stolb - 1].Value) != 1)// вверх лево
                {
                    stroka -= 2;
                    stolb -= 1;
                    area[stroka, stolb] = 1;
                    dataGridView1.Rows[stroka].Cells[stolb].Value = 1;
                }
                else if (stroka - 1 >= 0 && stolb + 2 <= 7 && Convert.ToInt32(dataGridView1.Rows[stroka - 1].Cells[stolb + 2].Value) != 1)// право вверх 
                {
                    stroka -= 1;
                    stolb += 2;
                    area[stroka, stolb] = 1;
                    dataGridView1.Rows[stroka].Cells[stolb].Value = 1;
                }
                else if (stroka + 1 <= 7 && stolb + 2 <= 7 && Convert.ToInt32(dataGridView1.Rows[stroka + 1].Cells[stolb + 2].Value) != 1)// право низ
                {
                    stroka += 1;
                    stolb += 2;
                    area[stroka, stolb] = 1;
                    dataGridView1.Rows[stroka].Cells[stolb].Value = 1;
                }
                else if (stroka + 2 <= 7 && stolb + 1 <= 7 && Convert.ToInt32(dataGridView1.Rows[stroka + 2].Cells[stolb + 1].Value) != 1)//низ права
                {
                    stroka += 2;
                    stolb += 1;
                    area[stroka, stolb] = 1;
                    dataGridView1.Rows[stroka].Cells[stolb].Value = 1;
                }
                else if (stroka + 2 <= 7 && stolb - 1 >= 0 && Convert.ToInt32(dataGridView1.Rows[stroka + 2].Cells[stolb - 1].Value) != 1)//них лево
                {
                    stroka += 2;
                    stolb -= 1;
                    area[stroka, stolb] = 1;
                    dataGridView1.Rows[stroka].Cells[stolb].Value = 1;
                }
                else if (stroka - 1 >= 0 && stolb - 2 >= 0 && Convert.ToInt32(dataGridView1.Rows[stroka - 1].Cells[stolb - 2].Value) != 1)//лево верх
                {
                    stroka -= 1;
                    stolb -= 2;
                    area[stroka, stolb] = 1;
                    dataGridView1.Rows[stroka].Cells[stolb].Value = 1;
                }
                else if (stroka + 1 <= 7 && stolb - 2 >= 0 && Convert.ToInt32(dataGridView1.Rows[stroka + 1].Cells[stolb - 2].Value) != 1)//лево низ
                {
                    stroka += 1;
                    stolb -= 2;
                    area[stroka, stolb] = 1;
                    dataGridView1.Rows[stroka].Cells[stolb].Value = 1;
                }
                else
                {
                    MessageBox.Show("Заполнение невозможно");
                    break;
                }
                Thread.Sleep(500);
            }
        }

    }
}

