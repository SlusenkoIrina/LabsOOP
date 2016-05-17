using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лаба3
{
    public partial class Form1 : Form
    {
        private SolidBrush myBrush;
        private Graphics myGraphics;
        private Pen myPen;
        public Form1()
        {
            InitializeComponent();

        }
        AllFigures MyList = new AllFigures("all");
        int CountDataGrid = 0;
        public void Form1_Load(object sender, EventArgs e)
        {
            myBrush = new SolidBrush(Color.Red);
            myPen = new Pen(Color.Red);
            myGraphics = panel1.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Line3.Checked) //Если выбран треугольник
            {

                string MyBoxtext = Box.Text;
                string Info = "Triangle" + MyBoxtext;
                MyList.Add(Info);
                dataGridView1.Rows.Add();
                dataGridView1.Rows[CountDataGrid].Cells[0].Value = Convert.ToString(CountDataGrid+1);
                dataGridView1.Rows[CountDataGrid].Cells[1].Value = Convert.ToString("Triangle");
                dataGridView1.Rows[CountDataGrid].Cells[2].Value = Convert.ToString(MyBoxtext);

                string[] PointsArray = MyBoxtext.Split(';'); //Текст из бокса заносим в массив
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
                    if (checkBox.Checked)
                    {
                        NewTriangle.Fill(myGraphics, myBrush, myPen);
                        dataGridView1.Rows[CountDataGrid].Cells[5].Value = Convert.ToString("YES");
                    }
                    else
                    {
                        NewTriangle.Draw(myGraphics, myBrush, myPen);
                        dataGridView1.Rows[CountDataGrid].Cells[5].Value = Convert.ToString("NO");
                    }
                    dataGridView1.Rows[CountDataGrid].Cells[4].Value = Convert.ToString(NewTriangle.Perimeter());
                    dataGridView1.Rows[CountDataGrid].Cells[3].Value = Convert.ToString(NewTriangle.Area());
                    CountDataGrid++;
                }
                else MessageBox.Show("Введите все данные");
            }
            else
            if (Line.Checked) //Если выбрана линия
            {

                string MyBoxtext = Box.Text;
                string Info = "Line" + MyBoxtext;
                MyList.Add(Info);
                dataGridView1.Rows.Add();
                dataGridView1.Rows[CountDataGrid].Cells[0].Value = Convert.ToString(CountDataGrid + 1);
                dataGridView1.Rows[CountDataGrid].Cells[1].Value = Convert.ToString("Line");
                dataGridView1.Rows[CountDataGrid].Cells[2].Value = Convert.ToString(MyBoxtext);
                string[] PointsArray = MyBoxtext.Split(';');
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
                    dataGridView1.Rows[CountDataGrid].Cells[5].Value = Convert.ToString("NO");
                    CountDataGrid++;

                }
                else MessageBox.Show("Введите все данные");
            }
            else
            if (ETriangle.Checked)
            {
                string MyBoxtext = Box.Text;
                string Info = "Equilateral_Triangle" + MyBoxtext;
                MyList.Add(Info);
                dataGridView1.Rows.Add();
                dataGridView1.Rows[CountDataGrid].Cells[0].Value = Convert.ToString(CountDataGrid + 1);
                dataGridView1.Rows[CountDataGrid].Cells[1].Value = Convert.ToString("Equilateral_Triangle");
                dataGridView1.Rows[CountDataGrid].Cells[2].Value = Convert.ToString(MyBoxtext);
                string[] PointsArray = MyBoxtext.Split(';');
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
                    if (checkBox.Checked)
                    {
                        NewETriangle.Fill(myGraphics, myBrush, myPen);
                        dataGridView1.Rows[CountDataGrid].Cells[5].Value = Convert.ToString("YES");
                    }
                    else
                    {
                        NewETriangle.Draw(myGraphics, myBrush, myPen);
                        dataGridView1.Rows[CountDataGrid].Cells[5].Value = Convert.ToString("NO");
                    }
                    dataGridView1.Rows[CountDataGrid].Cells[4].Value = Convert.ToString(NewETriangle.Perimeter());
                    dataGridView1.Rows[CountDataGrid].Cells[3].Value = Convert.ToString(NewETriangle.Area());
                    CountDataGrid++;
                }
                else MessageBox.Show("Введите все данные");
            }
            else
            if (RightTriangle.Checked)
            {
                string MyBoxtext = Box.Text;
                string Info = "Right_Triangle" + MyBoxtext;
                MyList.Add(Info);
                dataGridView1.Rows.Add();
                dataGridView1.Rows[CountDataGrid].Cells[0].Value = Convert.ToString(CountDataGrid + 1);
                dataGridView1.Rows[CountDataGrid].Cells[1].Value = Convert.ToString("Right_Triangle");
                dataGridView1.Rows[CountDataGrid].Cells[2].Value = Convert.ToString(MyBoxtext);
                string[] PointsArray = MyBoxtext.Split(';');
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
                    if (checkBox.Checked)
                    {
                        NewRTriangle.Fill(myGraphics, myBrush, myPen);
                        dataGridView1.Rows[CountDataGrid].Cells[5].Value = Convert.ToString("YES");
                    }
                    else
                    {
                        NewRTriangle.Draw(myGraphics, myBrush, myPen);
                        dataGridView1.Rows[CountDataGrid].Cells[5].Value = Convert.ToString("NO");
                    }
                    dataGridView1.Rows[CountDataGrid].Cells[4].Value = Convert.ToString(NewRTriangle.Perimeter());
                    dataGridView1.Rows[CountDataGrid].Cells[3].Value = Convert.ToString(NewRTriangle.Area());
                    CountDataGrid++;
                }
                else MessageBox.Show("Введите все данные");
            }
            else
            if (tetrahedron.Checked)
            {
                string MyBoxtext = Box.Text;
                string Info = "Tetrahedron" + MyBoxtext;
                MyList.Add(Info);
                dataGridView1.Rows.Add();
                dataGridView1.Rows[CountDataGrid].Cells[0].Value = Convert.ToString(CountDataGrid + 1);
                dataGridView1.Rows[CountDataGrid].Cells[1].Value = Convert.ToString("Tetrahedron");
                dataGridView1.Rows[CountDataGrid].Cells[2].Value = Convert.ToString(MyBoxtext);
                string[] PointsArray = MyBoxtext.Split(';');
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
                    NewTetrahedron.Draw (myGraphics, myBrush, myPen);
                    dataGridView1.Rows[CountDataGrid].Cells[5].Value = Convert.ToString("NO");
                    dataGridView1.Rows[CountDataGrid].Cells[4].Value = Convert.ToString(NewTetrahedron.Perimeter());
                    dataGridView1.Rows[CountDataGrid].Cells[3].Value = Convert.ToString(NewTetrahedron.Area());
                    CountDataGrid++;

                }
                else MessageBox.Show("Введите все данные");
            }
            else MessageBox.Show("Укажите фигуру");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myGraphics.Clear(Color.White);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int CountFigure = Convert.ToInt32(textBox1);
            string[] ArrayXY = new string[2];
            string textBox = textBox2.Text;
            ArrayXY = textBox.Split(',');
            int x = Convert.ToInt32(ArrayXY[0]);
            int y = Convert.ToInt32(ArrayXY[1]);
            

        }
    }
}
