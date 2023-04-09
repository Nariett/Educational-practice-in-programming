using Timer = System.Windows.Forms.Timer;

namespace WinFormsApp1
{
    public partial class TaskTwo : Form
    {
        private Timer timer = new Timer();
        private double angle = 0;
        private double angleSpeed = 0.05;
        private double radiusSpeed = 0.05;

        public TaskTwo()
        {
            InitializeComponent();
            this.ClientSize = new Size(400, 400);
            timer.Interval = 20;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            double radius = angle * radiusSpeed;
            int x = (int)(this.ClientSize.Width / 2 + radius * Math.Cos(angle));
            int y = (int)(this.ClientSize.Height / 2 + radius * Math.Sin(angle));
            g.FillEllipse(Brushes.Blue, x - 10, y - 10, 20, 20);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            angle += angleSpeed;
            radiusSpeed += 0.02;
            this.Invalidate();
        }
    }
}
