using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class TaskOne : Form
    {
        public TaskOne()
        {
            InitializeComponent();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rec = new Rectangle(10, 10, 20, 20);
            e.Graphics.DrawRectangle(new Pen(Brushes.Red, 3), rec);

            Point[] points = new Point[3];
            points[0] = new Point(150, 150);
            points[1] = new Point(200, 200);
            points[2] = new Point(250, 150);
            Pen pen = new Pen(Color.Black, 2);
            pen.DashStyle = DashStyle.DashDot;
            e.Graphics.DrawPolygon(pen, points);
            Brush brush = new SolidBrush(Color.Red);
            e.Graphics.FillPolygon(brush, points);
            pen.Dispose();

            Rectangle oval = new Rectangle(50, 50, 100, 200);
            e.Graphics.DrawEllipse(new Pen(Brushes.Black, 2), oval);

            Pen pe = new Pen(Color.Black, 2);
            e.Graphics.DrawLine(pe, 0, 0, 100, 100);
            //g.Clear(Color.White);


        }
    }
}
