using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace лаба3
{
    class Tetrahedron : Triangle 
    {
        Point MyPoint = new Point();
        public Tetrahedron(Point[] point)
        {
            for (int i = 0; i < point.Length-1; i++)
            {
                this.points[i] = new Point(); 
                this.points[i].X = point[i].X;
                this.points[i].Y = point[i].Y;
                this.A = Math.Sqrt((this.points[0].X - this.points[1].X) * (this.points[0].X - this.points[1].X) + (this.points[0].Y - this.points[1].Y) * (this.points[0].Y - this.points[1].Y));
                this.B = Math.Sqrt((this.points[0].X - this.points[2].X) * (this.points[0].X - this.points[2].X) + (this.points[0].Y - this.points[2].Y) * (this.points[0].Y - this.points[2].Y));
                this.C = Math.Sqrt((this.points[2].X - this.points[1].X) * (this.points[2].X - this.points[1].X) + (this.points[2].Y - this.points[1].Y) * (this.points[2].Y - this.points[1].Y));
            }
            MyPoint = point[point.Length-1]; 
        }

        public override void Draw(Graphics myGraphics, SolidBrush myBrush, Pen myPen)
        {
            myPen.Width = 3;
            Figure NewTriangle = new Triangle(points);
            NewTriangle.Draw(myGraphics, myBrush, myPen);
            myGraphics.DrawLine(myPen, points[0].X, points[0].Y, MyPoint.X, MyPoint.Y);
            myGraphics.DrawLine(myPen, MyPoint.X, MyPoint.Y, points[2].X, points[2].Y);
            myGraphics.DrawLine(myPen, points[1].X, points[1].Y, MyPoint.X, MyPoint.Y);

        }
        public override double Perimeter()
        {
            double a = Math.Sqrt((this.points[0].X - this.MyPoint.X) * (this.points[0].X - this.MyPoint.X) + (this.points[0].Y - this.MyPoint.Y) * (this.points[0].Y - this.MyPoint.Y));
            double b = Math.Sqrt((this.MyPoint.X - this.points[2].X) * (this.MyPoint.X - this.points[2].X) + (this.MyPoint.Y - this.points[2].Y) * (this.MyPoint.Y - this.points[2].Y));
            double c = Math.Sqrt((this.MyPoint.X - this.points[1].X) * (this.MyPoint.X - this.points[1].X) + (this.MyPoint.Y - this.points[1].Y) * (this.MyPoint.Y - this.points[1].Y));
            return base.Perimeter() + a + b + c;
        }
        public override double Area()
        {
            Figure NewTriangle1 = new Triangle(points);
            Figure NewTriangle2 = new Triangle(points[0], points[1], MyPoint);
            Figure NewTriangle3 = new Triangle(points[0], points[2], MyPoint);
            Figure NewTriangle4 = new Triangle(points[2], points[1], MyPoint);
            return NewTriangle1.Area() + NewTriangle2.Area() + NewTriangle3.Area() + NewTriangle4.Area();

        }
    }
}
