namespace MainForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void task1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskOne FormOne = new TaskOne();
            FormOne.Show();
        }

        private void task2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskTwo FormTwo = new TaskTwo();
            FormTwo.Show();
        }

        private void task3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskThree FormThree = new TaskThree();
            FormThree.Show();
        }

        private void task4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskFour FormFour = new TaskFour();
            FormFour.Show();
        }
    }
}