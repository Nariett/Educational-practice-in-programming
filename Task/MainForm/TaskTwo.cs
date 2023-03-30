namespace MainForm
{
    public partial class TaskTwo : Form
    {
        public TaskTwo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(this.textBox1.Text);
            double y = Convert.ToDouble(this.textBox2.Text);
            double z = Convert.ToDouble(this.textBox3.Text);
            double result = 0;
            if (x - y == 0)
            {
                result = Math.Sin(Math.Pow(x, 2)) - Math.Cos(Math.Pow(y, 2));
            }
            else
            {
                if (x - y > 0)
                {
                    result = Math.Tan(Math.Pow(x + y, 2));
                }
                else
                {
                    result = Math.Pow(Math.Sin(Math.Pow(x, 2)),2) + Math.Pow(Math.Cos(Math.Pow(y, 2)), 2);
                }
            }
            this.textBox4.Text = $"Самойлов Александр Сергеевич {Environment.NewLine}При x = {x}{Environment.NewLine}При y = {y}{Environment.NewLine}" +
                $"При z = {z}{Environment.NewLine}Результат равен {result}";


        }
    }
}
