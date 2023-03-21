namespace Part66
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string Text = this.textBox1.Text;
            int counterDigit = 0;
            int counterMark = 0;
            int counterLetter = 0;
            for (int i = 0; i < Text.Length; i++)
            {
                if (Char.IsDigit(Text[i]))
                {
                    counterDigit++;
                }
                else if (Char.IsLetter(Text[i]))
                {
                    counterLetter++;
                }
                else if (Char.IsPunctuation(Text[i]))
                {
                    counterMark++;
                }
            }
            this.label1.Text = $"Кол-во букв: {counterLetter}, Кол-во цифр: {counterDigit}, Кол-во знаков {counterMark}";
        }
    }
}