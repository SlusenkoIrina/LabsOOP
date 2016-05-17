using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace лаба3
{
    class Right_Triangle : Triangle
    {
        public int LengthA { get; set; }
        public int LengthB { get; set; }

        public Right_Triangle(Point[] points, int lengthA, int lengthB) : base(points)
        {
            this.points[0] = new Point();
            this.points[0].X = points[0].X;
            this.points[0].Y = points[0].Y;
            this.points[1] = new Point();
            this.points[1].X = points[0].X + lengthA;
            this.points[1].Y = points[0].Y;
            this.points[2] = new Point();
            this.points[2].X = points[0].X;
            this.points[2].Y = points[0].Y - lengthB;
            LengthA = lengthA;
            LengthB = lengthB;
        }
        public override void Draw(Graphics myGraphics, SolidBrush myBrush, Pen myPen)
        {
            base.Draw(myGraphics, myBrush, myPen);
        }
        public override void Hatch(Graphics myGraphics, SolidBrush myBrush, Pen myPen)
        {
            base.Hatch(myGraphics, myBrush, myPen);
        }
        public override double Perimeter()
        {
            return LengthA+LengthB+Math.Sqrt(LengthA*LengthA+LengthB*LengthB);
        }
        public override double Area()
        {
            return LengthA * LengthB * 0.5;
        }
    }
}
