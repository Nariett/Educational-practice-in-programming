using System.Diagnostics;

namespace Part67
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        public DataPoint PointInfo = new DataPoint();

        public DataPoint GetPointFromForm2()
        {
            return PointInfo;
        }
        private void inputToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Owner = this;
            form.ShowDialog();
        }

        private void drawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(PointInfo.color, 2);
            int x1 = PointInfo.X1;
            int y1 = PointInfo.Y1;
            g.DrawEllipse(pen, x1 - 5, y1 - 5, 10, 10);
            int x2 = PointInfo.X2;
            int y2 = PointInfo.Y2;
            g.DrawEllipse(pen, x2 - 5, y2 - 5, 10, 10);
            g.DrawLine(pen, x1, y1, x2, y2);
            pen.Dispose();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PointInfo = new DataPoint();
            MessageBox.Show("Values is null","Clear");
            this.Invalidate();
        }
    }
}