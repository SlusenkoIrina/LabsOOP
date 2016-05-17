using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба3
{
    class Line : Figure
    {
        public Line(Point[] points)
        {
            for (int i = 0; i < 2; i++)
            {
                this.points[i] = new Point();
                this.points[i].X = points[i].X;
                this.points[i].Y = points[i].Y;
            }
        }

        public override void Draw( Graphics myGraphics, SolidBrush myBrush, Pen myPen)
        {
            myPen.Width = 3;
            myGraphics.DrawLine(myPen, points[0].X, points[0].Y, points[1].X, points[1].Y);
        }
    }
}
