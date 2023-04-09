namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void taskOneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskOne formOne = new TaskOne();
            formOne.Show();
        }

        private void taskTwoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskTwo formTwo = new TaskTwo();
            formTwo.Show();
        }

        private void taskThreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskThree formThree = new TaskThree();
            formThree.Show();
        }

        private void taskFourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskFour formFour = new TaskFour();
            formFour.Show();
        }

        private void taskFiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFive formFive = new FormFive();
            formFive.Show();
        }
    }
}