namespace MainForm
{
    public partial class TaskFour : Form
    {
        public TaskFour()
        {
            InitializeComponent();
        }
        public int x = 36;
        public int y = 92;
        private void TaskFour_MouseDown(object sender, MouseEventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                TextBox textbox = new TextBox();
                textbox.Name = "TextBox";
                textbox.Text = "TextBox";
                if (x > 816)
                {
                    y += 30;
                    x = 36;
                    textbox.Location = new Point(x, y);
                    textbox.Size = new Size(100, 23);
                    this.Controls.Add(textbox);
                }
                else
                {
                    textbox.Location = new Point(x, y);
                    textbox.Size = new Size(100, 23);
                    this.Controls.Add(textbox);
                }
                x += 120;

            }
            else
            {
                if (radioButton2.Checked == true)
                {
                    Button button = new Button();
                    button.Name = "Button";
                    button.Text = "Button";
                    if (x > 816)
                    {
                        y += 30;
                        x = 36;
                        button.Location = new Point(x, y);
                        button.Size = new Size(100, 23);
                        this.Controls.Add(button);
                    }
                    else
                    {
                        button.Location = new Point(x, y);
                        button.Size = new Size(100, 23);
                        this.Controls.Add(button);
                    }
                    x += 120;
                }
                else
                {
                    Label label = new Label();
                    label.Name = "Label";
                    label.Text = "Label";
                    if (x > 816)
                    {
                        y += 30;
                        x = 36;
                        label.Location = new Point(x, y);
                        label.Size = new Size(100, 23);
                        this.Controls.Add(label);
                    }
                    else
                    {
                        label.Location = new Point(x, y);
                        label.Size = new Size(100, 23);
                        this.Controls.Add(label);
                    }
                    x += 120;
                }
            }

        }
    }
}
