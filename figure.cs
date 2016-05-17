using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace лаба3
{
    abstract class Figure
    {
        protected Point[] points = new Point[3];
        public virtual void  Draw(Graphics myGraphics, SolidBrush myBrush, Pen myPen)
        {
            
        }
        public virtual void Fill(Graphics myGraphics, SolidBrush myBrush, Pen myPen)
        {

        }
        public virtual void Hatch(Graphics myGraphics, SolidBrush myBrush, Pen myPen)
        {

        }
        public virtual double Perimeter()
        {
            return 0;
        }
        public virtual double Area()
        {
            return 0;
        }
    }
}
