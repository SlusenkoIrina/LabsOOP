using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace лаба3
{
    class AllFigures
    {
        public string Info { get; set; }
        public AllFigures Next { get; set; }
        public AllFigures(string name)
        {
            Info = name;
            Next = null;
        }
        private void Add(AllFigures  a, string Info)
        {
            if (a.Next == null)
            {
                a.Next = new AllFigures(Info);
                return;
            }
            Add(a.Next, Info);
        }
        public void Add(string Info)
        {
            Add(this, Info);
        }
        public void WriteFile()
        {
            TextWriter writer = new StreamWriter("111.txt");
            var point = this.Next;
            while(point.Next != null)
            {
                writer.WriteLine(point.Info);
                point = point.Next;
            }
            writer.WriteLine(point.Info);
            writer.Close();
        }
        public void RePaint(Graphics myGraphics, SolidBrush myBrush, Pen myPen)
        {
            var point = this.Next;
            while (point != null)
            {
                string[] ArrayOfFigure = point.Info.Split(' ');
                switch (ArrayOfFigure[0])
                {
                    case "Line": //Если строка описывает линию, строим линию
                        {
                            string[] PointsArray = ArrayOfFigure[1].Split(';');
                            if (PointsArray.Length >= 4)
                            {
                                Point[] points = new Point[2];
                                for (int i = 0; i <= 3; i++)
                                {

                                    if (i % 2 == 0)
                                    {
                                        points[i / 2] = new Point(); points[i / 2].X = Convert.ToInt32(PointsArray[i]);
                                    }
                                    else points[i / 2].Y = Convert.ToInt32(PointsArray[i]);
                                }
                                Figure NewLine = new Line(points);
                                NewLine.Draw(myGraphics, myBrush, myPen);

                            }
                            break;
                        }
                    case "Triangle": //Если в строке описан треуголник
                        {
                            string[] PointsArray = ArrayOfFigure[1].Split(';'); 
                            if (PointsArray.Length >= 6)
                            {
                                //Из массива формируем массив экземпляров класса point
                                Point[] points = new Point[3];
                                for (int i = 0; i <= 5; i++)
                                {

                                    if (i % 2 == 0)
                                    {
                                        points[i / 2] = new Point(); points[i / 2].X = Convert.ToInt32(PointsArray[i]);
                                    }
                                    else points[i / 2].Y = Convert.ToInt32(PointsArray[i]);
                                }
                                // Рисуем треугольник
                                Figure NewTriangle = new Triangle(points);
                                if (ArrayOfFigure[2]=="YES")
                                {
                                    NewTriangle.Fill(myGraphics, myBrush, myPen);
                                }
                                else
                                {
                                    NewTriangle.Draw(myGraphics, myBrush, myPen);
                                }
                            }
                            break;
                        }
                    case "Equilateral_Triangle": //Если описан правильный треугольник
                        {
                            string[] PointsArray = ArrayOfFigure[1].Split(';');
                            if (PointsArray.Length >= 3)
                            {
                                Point[] points = new Point[1];
                                for (int i = 0; i <= 1; i++)
                                {

                                    if (i % 2 == 0)
                                    {
                                        points[i / 2] = new Point(); points[i / 2].X = Convert.ToInt32(PointsArray[i]);
                                    }
                                    else points[i / 2].Y = Convert.ToInt32(PointsArray[i]);
                                }
                                Figure NewETriangle = new Equilateral_Triangle(points, Convert.ToInt32(PointsArray[2]));
                                if (ArrayOfFigure[2] == "YES")
                                {
                                    NewETriangle.Fill(myGraphics, myBrush, myPen);

                                }
                                else
                                {
                                    NewETriangle.Draw(myGraphics, myBrush, myPen);

                                }

                            }
                            break;
                        }
                    case "Right_Triangle"://Если описан прмоуголный треугольник
                        {
                            string[] PointsArray = ArrayOfFigure[1].Split(';');
                            if (PointsArray.Length >= 4)
                            {
                                Point[] points = new Point[1];
                                for (int i = 0; i <= 1; i++)
                                {

                                    if (i % 2 == 0)
                                    {
                                        points[i / 2] = new Point(); points[i / 2].X = Convert.ToInt32(PointsArray[i]);
                                    }
                                    else points[i / 2].Y = Convert.ToInt32(PointsArray[i]);
                                }
                                Figure NewRTriangle = new Right_Triangle(points, Convert.ToInt32(PointsArray[2]), Convert.ToInt32(PointsArray[3]));
                                if (ArrayOfFigure[2] == "YES")
                                {
                                    NewRTriangle.Fill(myGraphics, myBrush, myPen);
                                }
                                else
                                {
                                    NewRTriangle.Draw(myGraphics, myBrush, myPen);
                                }
                            }
                            break;
                        }
                    case "Tetrahedron"://Если описан тетраэдр
                        {
                            string[] PointsArray = ArrayOfFigure[1].Split(';');
                            if (PointsArray.Length >= 8)
                            {
                                Point[] points = new Point[4];
                                for (int i = 0; i <= 7; i++)
                                {

                                    if (i % 2 == 0)
                                    {
                                        points[i / 2] = new Point(); points[i / 2].X = Convert.ToInt32(PointsArray[i]);
                                    }
                                    else points[i / 2].Y = Convert.ToInt32(PointsArray[i]);
                                }
                                Figure NewTetrahedron = new Tetrahedron(points);
                                NewTetrahedron.Draw(myGraphics, myBrush, myPen);
                            }
                            break;
                        }


                }
                point = point.Next;
            }
        }
    }
}
