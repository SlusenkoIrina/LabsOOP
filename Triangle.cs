using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба3
{
    class Triangle : Figure 
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public Triangle()
        {

        }
        public Triangle(Point x1y1, Point x2y2, Point x3y3)
        {
            this.points[0] = new Point();
            this.points[0].X = x1y1.X;
            this.points[0].Y = x1y1.Y;
            this.points[1] = new Point();
            this.points[1].X = x2y2.X;
            this.points[1].Y = x2y2.Y;
            this.points[2] = new Point();
            this.points[2].X = x3y3.X;
            this.points[2].Y = x2y2.Y;
        }
        public Triangle(Point[] points)
            {
            for (int i = 0; i < points.Length; i++)
                {
                    this.points[i] = new Point();
                    this.points[i].X = points[i].X;
                    this.points[i].Y = points[i].Y;
                }
            this.A = Math.Sqrt((this.points[0].X - this.points[1].X) * (this.points[0].X - this.points[1].X) + (this.points[0].Y - this.points[1].Y) * (this.points[0].Y - this.points[1].Y));
            this.B = Math.Sqrt((this.points[0].X - this.points[2].X) * (this.points[0].X - this.points[2].X) + (this.points[0].Y - this.points[2].Y) * (this.points[0].Y - this.points[2].Y));
            this.C = Math.Sqrt((this.points[2].X - this.points[1].X) * (this.points[2].X - this.points[1].X) + (this.points[2].Y - this.points[1].Y) * (this.points[2].Y - this.points[1].Y));
        }

        public override  void Draw( Graphics myGraphics, SolidBrush myBrush, Pen myPen)
        {
            myPen.Width = 3;
            myGraphics.DrawLine(myPen, points[0].X, points[0].Y, points[1].X, points[1].Y);
            myGraphics.DrawLine(myPen, points[0].X, points[0].Y, points[2].X, points[2].Y);
            myGraphics.DrawLine(myPen, points[1].X, points[1].Y, points[2].X, points[2].Y);

        }
        public override void Fill(Graphics myGraphics, SolidBrush myBrush, Pen myPen)
        {
            myGraphics.FillPolygon(myBrush, points);

        }
        public override void Hatch(Graphics myGraphics, SolidBrush myBrush, Pen myPen)
        {
            myPen.Width = 0.6F;
            FillMode newFillMode = FillMode.Winding;
            myGraphics.FillPolygon(myBrush, points, newFillMode);
        }
        public override double Perimeter()
        {
            return (A + B + C);
        }
        public override double Area()
        {
            double p = (A + B + C) / 2;
            double s = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return s;
        }

    }
}
