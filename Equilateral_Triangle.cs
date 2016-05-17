using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace лаба3
{
    class Equilateral_Triangle : Triangle 
    {
        public int Length { get; set; }
        public Equilateral_Triangle(Point[] points, int length) : base(points)
        {
            this.points[0] = new Point();
            this.points[0].X = points[0].X;
            this.points[0].Y = points[0].Y;
            this.points[1] = new Point();
            this.points[1].X = points[0].X+length;
            this.points[1].Y = points[0].Y;
            this.points[2] = new Point();
            this.points[2].X = points[0].X + length/2;
            this.points[2].Y = points[0].Y-Convert.ToInt32 ((1.7/2)*length);
            this.Length = length;
        }
        public override void Draw(Graphics myGraphics, SolidBrush myBrush, Pen myPen)
        {
            base.Draw(myGraphics, myBrush, myPen);
        }
        public override double Perimeter()
        {
            return 3 * Length;
        }
        public override double Area()
        {
            return (Length * Length * 1.7) / 4;
        }
    }
}
