using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace лаба3
{
    public partial class Form1 : Form
    {
        private AllFigures MyList = new AllFigures("all");
        private int CountDataGrid = 0;
        //private IContainer components = (IContainer)null;
        private SolidBrush myBrush;
        private Graphics myGraphics;
        private Pen myPen;
        private Panel panel1;
        private GroupBox groupBox1;
        private Button button1;
        private RichTextBox Box;
        private RadioButton Line;
        private RadioButton Line3;
        private RadioButton ETriangle;
        private Button button2;
        private RadioButton RightTriangle;
        private CheckBox checkBox;
        private RadioButton tetrahedron;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn NameClass;
        private DataGridViewTextBoxColumn XY;
        private DataGridViewTextBoxColumn Info1;
        private DataGridViewTextBoxColumn Info2;
        private DataGridViewTextBoxColumn Info;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private Button button3;
        private Button button4;

        public Form1()
        {
            this.InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            this.myBrush = new SolidBrush(Color.Red);
            this.myPen = new Pen(Color.Red);
            this.myGraphics = this.panel1.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Line3.Checked)
            {
                string text = this.Box.Text;
                string str = "Triangle " + text + " ";
                this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[this.CountDataGrid].Cells[0].Value = (object)Convert.ToString(this.CountDataGrid + 1);
                this.dataGridView1.Rows[this.CountDataGrid].Cells[1].Value = (object)Convert.ToString("Triangle");
                this.dataGridView1.Rows[this.CountDataGrid].Cells[2].Value = (object)Convert.ToString(text);
                string[] strArray = text.Split(';');
                if (strArray.Length >= 6)
                {
                    Point[] points = new Point[3];
                    for (int index = 0; index <= 5; ++index)
                    {
                        if (index % 2 == 0)
                        {
                            points[index / 2] = new Point();
                            points[index / 2].X = Convert.ToInt32(strArray[index]);
                        }
                        else
                            points[index / 2].Y = Convert.ToInt32(strArray[index]);
                    }
                    Figure figure = (Figure)new Triangle(points);
                    string Info;
                    if (this.checkBox.Checked)
                    {
                        figure.Fill(this.myGraphics, this.myBrush, this.myPen);
                        this.dataGridView1.Rows[this.CountDataGrid].Cells[5].Value = (object)Convert.ToString("YES");
                        Info = str + "YES";
                    }
                    else
                    {
                        figure.Draw(this.myGraphics, this.myBrush, this.myPen);
                        this.dataGridView1.Rows[this.CountDataGrid].Cells[5].Value = (object)Convert.ToString("NO");
                        Info = str + "NO";
                    }
                    this.dataGridView1.Rows[this.CountDataGrid].Cells[4].Value = (object)Convert.ToString(figure.Perimeter());
                    this.dataGridView1.Rows[this.CountDataGrid].Cells[3].Value = (object)Convert.ToString(figure.Area());
                    this.CountDataGrid = this.CountDataGrid + 1;
                    this.MyList.Add(Info);
                }
                else
                {
                    int num = (int)MessageBox.Show("Введите все данные");
                }
            }
            else if (this.Line.Checked)
            {
                string text = this.Box.Text;
                string Info = "Line " + text;
                this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[this.CountDataGrid].Cells[0].Value = (object)Convert.ToString(this.CountDataGrid + 1);
                this.dataGridView1.Rows[this.CountDataGrid].Cells[1].Value = (object)Convert.ToString("Line");
                this.dataGridView1.Rows[this.CountDataGrid].Cells[2].Value = (object)Convert.ToString(text);
                string[] strArray = text.Split(';');
                if (strArray.Length >= 4)
                {
                    Point[] points = new Point[2];
                    for (int index = 0; index <= 3; ++index)
                    {
                        if (index % 2 == 0)
                        {
                            points[index / 2] = new Point();
                            points[index / 2].X = Convert.ToInt32(strArray[index]);
                        }
                        else
                            points[index / 2].Y = Convert.ToInt32(strArray[index]);
                    }
                    new лаба3.Line(points).Draw(this.myGraphics, this.myBrush, this.myPen);
                    this.dataGridView1.Rows[this.CountDataGrid].Cells[5].Value = (object)Convert.ToString("NO");
                    this.CountDataGrid = this.CountDataGrid + 1;
                    this.MyList.Add(Info);
                }
                else
                {
                    int num = (int)MessageBox.Show("Введите все данные");
                }
            }
            else if (this.ETriangle.Checked)
            {
                string text = this.Box.Text;
                string str = "Equilateral_Triangle;" + text + " ";
                this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[this.CountDataGrid].Cells[0].Value = (object)Convert.ToString(this.CountDataGrid + 1);
                this.dataGridView1.Rows[this.CountDataGrid].Cells[1].Value = (object)Convert.ToString("Equilateral_Triangle");
                this.dataGridView1.Rows[this.CountDataGrid].Cells[2].Value = (object)Convert.ToString(text);
                string[] strArray = text.Split(';');
                if (strArray.Length >= 3)
                {
                    Point[] points = new Point[1];
                    for (int index = 0; index <= 1; ++index)
                    {
                        if (index % 2 == 0)
                        {
                            points[index / 2] = new Point();
                            points[index / 2].X = Convert.ToInt32(strArray[index]);
                        }
                        else
                            points[index / 2].Y = Convert.ToInt32(strArray[index]);
                    }
                    Figure figure = (Figure)new Equilateral_Triangle(points, Convert.ToInt32(strArray[2]));
                    string Info;
                    if (this.checkBox.Checked)
                    {
                        figure.Fill(this.myGraphics, this.myBrush, this.myPen);
                        this.dataGridView1.Rows[this.CountDataGrid].Cells[5].Value = (object)Convert.ToString("YES");
                        Info = str + "YES";
                    }
                    else
                    {
                        figure.Draw(this.myGraphics, this.myBrush, this.myPen);
                        this.dataGridView1.Rows[this.CountDataGrid].Cells[5].Value = (object)Convert.ToString("NO");
                        Info = str + "NO";
                    }
                    this.dataGridView1.Rows[this.CountDataGrid].Cells[4].Value = (object)Convert.ToString(figure.Perimeter());
                    this.dataGridView1.Rows[this.CountDataGrid].Cells[3].Value = (object)Convert.ToString(figure.Area());
                    this.CountDataGrid = this.CountDataGrid + 1;
                    this.MyList.Add(Info);
                }
                else
                {
                    int num = (int)MessageBox.Show("Введите все данные");
                }
            }
            else if (this.RightTriangle.Checked)
            {
                string text = this.Box.Text;
                string str = "Right_Triangle " + text + " ";
                this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[this.CountDataGrid].Cells[0].Value = (object)Convert.ToString(this.CountDataGrid + 1);
                this.dataGridView1.Rows[this.CountDataGrid].Cells[1].Value = (object)Convert.ToString("Right_Triangle");
                this.dataGridView1.Rows[this.CountDataGrid].Cells[2].Value = (object)Convert.ToString(text);
                string[] strArray = text.Split(';');
                if (strArray.Length >= 4)
                {
                    Point[] points = new Point[1];
                    for (int index = 0; index <= 1; ++index)
                    {
                        if (index % 2 == 0)
                        {
                            points[index / 2] = new Point();
                            points[index / 2].X = Convert.ToInt32(strArray[index]);
                        }
                        else
                            points[index / 2].Y = Convert.ToInt32(strArray[index]);
                    }
                    Figure figure = (Figure)new Right_Triangle(points, Convert.ToInt32(strArray[2]), Convert.ToInt32(strArray[3]));
                    string Info;
                    if (this.checkBox.Checked)
                    {
                        figure.Fill(this.myGraphics, this.myBrush, this.myPen);
                        this.dataGridView1.Rows[this.CountDataGrid].Cells[5].Value = (object)Convert.ToString("YES");
                        Info = str + "YES";
                    }
                    else
                    {
                        figure.Draw(this.myGraphics, this.myBrush, this.myPen);
                        this.dataGridView1.Rows[this.CountDataGrid].Cells[5].Value = (object)Convert.ToString("NO");
                        Info = str + "NO";
                    }
                    this.dataGridView1.Rows[this.CountDataGrid].Cells[4].Value = (object)Convert.ToString(figure.Perimeter());
                    this.dataGridView1.Rows[this.CountDataGrid].Cells[3].Value = (object)Convert.ToString(figure.Area());
                    this.CountDataGrid = this.CountDataGrid + 1;
                    this.MyList.Add(Info);
                }
                else
                {
                    int num = (int)MessageBox.Show("Введите все данные");
                }
            }
            else if (this.tetrahedron.Checked)
            {
                string text = this.Box.Text;
                string Info = "Tetrahedron " + text;
                this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[this.CountDataGrid].Cells[0].Value = (object)Convert.ToString(this.CountDataGrid + 1);
                this.dataGridView1.Rows[this.CountDataGrid].Cells[1].Value = (object)Convert.ToString("Tetrahedron");
                this.dataGridView1.Rows[this.CountDataGrid].Cells[2].Value = (object)Convert.ToString(text);
                string[] strArray = text.Split(';');
                if (strArray.Length >= 8)
                {
                    Point[] point = new Point[4];
                    for (int index = 0; index <= 7; ++index)
                    {
                        if (index % 2 == 0)
                        {
                            point[index / 2] = new Point();
                            point[index / 2].X = Convert.ToInt32(strArray[index]);
                        }
                        else
                            point[index / 2].Y = Convert.ToInt32(strArray[index]);
                    }
                    Figure figure = (Figure)new Tetrahedron(point);
                    figure.Draw(this.myGraphics, this.myBrush, this.myPen);
                    this.dataGridView1.Rows[this.CountDataGrid].Cells[5].Value = (object)Convert.ToString("NO");
                    this.dataGridView1.Rows[this.CountDataGrid].Cells[4].Value = (object)Convert.ToString(figure.Perimeter());
                    this.dataGridView1.Rows[this.CountDataGrid].Cells[3].Value = (object)Convert.ToString(figure.Area());
                    this.CountDataGrid = this.CountDataGrid + 1;
                    this.MyList.Add(Info);
                }
                else
                {
                    int num = (int)MessageBox.Show("Введите все данные");
                }
            }
            else
            {
                int num1 = (int)MessageBox.Show("Укажите фигуру");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.MyList.Next = (AllFigures)null;
            this.dataGridView1.Rows.Clear();
            this.CountDataGrid = 0;
            this.myGraphics.Clear(Color.White);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int int32_1 = Convert.ToInt32(this.textBox1.Text);
            string[] strArray1 = new string[2];
            string[] strArray2 = this.textBox2.Text.Split(',');
            int int32_2 = Convert.ToInt32(strArray2[0]);
            int int32_3 = Convert.ToInt32(strArray2[1]);
            this.myGraphics.Clear(Color.White);
            string str1 = (string)this.dataGridView1["NameClass", int32_1 - 1].Value;
            AllFigures allFigures = this.MyList;
            int num1 = 0;
            if (allFigures.Next != null)
            {
                for (; num1 != int32_1; ++num1)
                    allFigures = allFigures.Next;
                string str2 = str1;
                if (!(str2 == "Line"))
                {
                    if (!(str2 == "Triangle"))
                    {
                        if (!(str2 == "Equilateral_Triangle"))
                        {
                            if (!(str2 == "Right_Triangle"))
                            {
                                if (str2 == "Tetrahedron")
                                {
                                    string[] strArray3 = ((string)this.dataGridView1["XY", int32_1 - 1].Value).Split(';');
                                    strArray3[0] = Convert.ToString(Convert.ToInt32(strArray3[0]) + int32_2);
                                    strArray3[2] = Convert.ToString(Convert.ToInt32(strArray3[2]) + int32_2);
                                    strArray3[1] = Convert.ToString(Convert.ToInt32(strArray3[1]) + int32_3);
                                    strArray3[3] = Convert.ToString(Convert.ToInt32(strArray3[3]) + int32_3);
                                    strArray3[4] = Convert.ToString(Convert.ToInt32(strArray3[4]) + int32_2);
                                    strArray3[5] = Convert.ToString(Convert.ToInt32(strArray3[5]) + int32_3);
                                    strArray3[6] = Convert.ToString(Convert.ToInt32(strArray3[6]) + int32_2);
                                    strArray3[7] = Convert.ToString(Convert.ToInt32(strArray3[7]) + int32_3);
                                    string str3 = "Tetrahedron " + strArray3[0] + ";" + strArray3[1] + ";" + strArray3[2] + ";" + strArray3[3] + ";" + strArray3[4] + ";" + strArray3[5] + ";" + strArray3[6] + ";" + strArray3[7];
                                    this.dataGridView1.Rows[this.CountDataGrid - 1].Cells[2].Value = (object)(strArray3[0] + ";" + strArray3[1] + ";" + strArray3[2] + ";" + strArray3[3] + ";" + strArray3[4] + ";" + strArray3[5] + ";" + strArray3[6] + ";" + strArray3[7]);
                                    allFigures.Info = str3;
                                }
                            }
                            else
                            {
                                string[] strArray3 = ((string)this.dataGridView1["XY", int32_1 - 1].Value).Split(';');
                                strArray3[0] = Convert.ToString(Convert.ToInt32(strArray3[0]) + int32_2);
                                strArray3[1] = Convert.ToString(Convert.ToInt32(strArray3[1]) + int32_2);
                                string str3 = "Right_Triangle " + strArray3[0] + ";" + strArray3[1] + ";" + strArray3[2] + ";" + strArray3[3] + " " + (string)this.dataGridView1["Info", int32_1 - 1].Value;
                                this.dataGridView1.Rows[this.CountDataGrid - 1].Cells[2].Value = (object)(strArray3[0] + ";" + strArray3[1] + ";" + strArray3[2] + ";" + strArray3[3]);
                                allFigures.Info = str3;
                            }
                        }
                        else
                        {
                            string[] strArray3 = ((string)this.dataGridView1["XY", int32_1 - 1].Value).Split(';');
                            strArray3[0] = Convert.ToString(Convert.ToInt32(strArray3[0]) + int32_2);
                            strArray3[1] = Convert.ToString(Convert.ToInt32(strArray3[1]) + int32_2);
                            string str3 = "Equilateral_Triangle " + strArray3[0] + ";" + strArray3[1] + ";" + strArray3[2] + " " + (string)this.dataGridView1["Info", int32_1 - 1].Value;
                            this.dataGridView1.Rows[this.CountDataGrid - 1].Cells[2].Value = (object)(strArray3[0] + ";" + strArray3[1] + ";" + strArray3[2]);
                            allFigures.Info = str3;
                        }
                    }
                    else
                    {
                        string[] strArray3 = ((string)this.dataGridView1["XY", int32_1 - 1].Value).Split(';');
                        strArray3[0] = Convert.ToString(Convert.ToInt32(strArray3[0]) + int32_2);
                        strArray3[2] = Convert.ToString(Convert.ToInt32(strArray3[2]) + int32_2);
                        strArray3[1] = Convert.ToString(Convert.ToInt32(strArray3[1]) + int32_3);
                        strArray3[3] = Convert.ToString(Convert.ToInt32(strArray3[3]) + int32_3);
                        strArray3[4] = Convert.ToString(Convert.ToInt32(strArray3[4]) + int32_2);
                        strArray3[5] = Convert.ToString(Convert.ToInt32(strArray3[5]) + int32_3);
                        string str3 = "Triangle " + strArray3[0] + ";" + strArray3[1] + ";" + strArray3[2] + ";" + strArray3[3] + ";" + strArray3[4] + ";" + strArray3[5] + " " + (string)this.dataGridView1["Info", int32_1 - 1].Value;
                        this.dataGridView1.Rows[this.CountDataGrid - 1].Cells[2].Value = (object)(strArray3[0] + ";" + strArray3[1] + ";" + strArray3[2] + ";" + strArray3[3] + ";" + strArray3[4] + ";" + strArray3[5]);
                        allFigures.Info = str3;
                    }
                }
                else
                {
                    string[] strArray3 = ((string)this.dataGridView1["XY", int32_1 - 1].Value).Split(';');
                    strArray3[0] = Convert.ToString(Convert.ToInt32(strArray3[0]) + int32_2);
                    strArray3[2] = Convert.ToString(Convert.ToInt32(strArray3[2]) + int32_2);
                    strArray3[1] = Convert.ToString(Convert.ToInt32(strArray3[1]) + int32_3);
                    strArray3[3] = Convert.ToString(Convert.ToInt32(strArray3[3]) + int32_3);
                    string str3 = "Line " + strArray3[0] + ";" + strArray3[1] + ";" + strArray3[2] + ";" + strArray3[3];
                    this.dataGridView1.Rows[this.CountDataGrid - 1].Cells[2].Value = (object)(strArray3[0] + ";" + strArray3[1] + ";" + strArray3[2] + ";" + strArray3[3]);
                    allFigures.Info = str3;
                }
                this.MyList.RePaint(this.myGraphics, this.myBrush, this.myPen);
            }
            else
            {
                int num2 = (int)MessageBox.Show("Список пуст");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.MyList.WriteFile();
        }
        /*
        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panel1 = new Panel();
            this.groupBox1 = new GroupBox();
            this.button1 = new Button();
            this.Box = new RichTextBox();
            this.Line = new RadioButton();
            this.Line3 = new RadioButton();
            this.ETriangle = new RadioButton();
            this.button2 = new Button();
            this.RightTriangle = new RadioButton();
            this.checkBox = new CheckBox();
            this.tetrahedron = new RadioButton();
            this.dataGridView1 = new DataGridView();
            this.Number = new DataGridViewTextBoxColumn();
            this.NameClass = new DataGridViewTextBoxColumn();
            this.XY = new DataGridViewTextBoxColumn();
            this.Info1 = new DataGridViewTextBoxColumn();
            this.Info2 = new DataGridViewTextBoxColumn();
            this.Info = new DataGridViewTextBoxColumn();
            this.label1 = new Label();
            this.label2 = new Label();
            this.textBox1 = new TextBox();
            this.textBox2 = new TextBox();
            this.textBox3 = new TextBox();
            this.textBox4 = new TextBox();
            this.comboBox1 = new ComboBox();
            this.button3 = new Button();
            this.button4 = new Button();
            this.groupBox1.SuspendLayout();
            ((ISupportInitialize)this.dataGridView1).BeginInit();
            this.SuspendLayout();
            this.panel1.BackColor = SystemColors.ButtonHighlight;
            this.panel1.Dock = DockStyle.Fill;
            this.panel1.Location = new Point(3, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new Size(1237, 381);
            this.panel1.TabIndex = 0;
            this.groupBox1.Controls.Add((Control)this.panel1);
            this.groupBox1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)204);
            this.groupBox1.Location = new Point(-1, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(1243, 406);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Редактор";
            this.button1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)204);
            this.button1.Location = new Point(219, 150);
            this.button1.Name = "button1";
            this.button1.Size = new Size(141, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Нажми меня";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.Box.Location = new Point(280, 25);
            this.Box.Name = "Box";
            this.Box.Size = new Size(184, 59);
            this.Box.TabIndex = 3;
            this.Box.Text = "";
            this.Line.AutoSize = true;
            this.Line.Location = new Point(37, 12);
            this.Line.Name = "Line";
            this.Line.Size = new Size(57, 17);
            this.Line.TabIndex = 4;
            this.Line.TabStop = true;
            this.Line.Text = "Линия";
            this.Line.UseVisualStyleBackColor = true;
            this.Line3.AutoSize = true;
            this.Line3.Location = new Point(37, 36);
            this.Line3.Name = "Line3";
            this.Line3.Size = new Size(90, 17);
            this.Line3.TabIndex = 5;
            this.Line3.TabStop = true;
            this.Line3.Text = "Треугольник";
            this.Line3.UseVisualStyleBackColor = true;
            this.ETriangle.AutoSize = true;
            this.ETriangle.Location = new Point(37, 59);
            this.ETriangle.Name = "ETriangle";
            this.ETriangle.Size = new Size(175, 17);
            this.ETriangle.TabIndex = 6;
            this.ETriangle.TabStop = true;
            this.ETriangle.Text = "Равносторонний треугольник";
            this.ETriangle.UseVisualStyleBackColor = true;
            this.button2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)204);
            this.button2.Location = new Point(388, 150);
            this.button2.Name = "button2";
            this.button2.Size = new Size(132, 41);
            this.button2.TabIndex = 7;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new EventHandler(this.button2_Click);
            this.RightTriangle.AutoSize = true;
            this.RightTriangle.Location = new Point(37, 82);
            this.RightTriangle.Name = "RightTriangle";
            this.RightTriangle.Size = new Size(173, 17);
            this.RightTriangle.TabIndex = 8;
            this.RightTriangle.TabStop = true;
            this.RightTriangle.Text = "Прямоугольный треугольник";
            this.RightTriangle.UseVisualStyleBackColor = true;
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new Point(280, 97);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new Size(80, 17);
            this.checkBox.TabIndex = 9;
            this.checkBox.Text = "Закрасить";
            this.checkBox.UseVisualStyleBackColor = true;
            this.tetrahedron.AutoSize = true;
            this.tetrahedron.Location = new Point(37, 106);
            this.tetrahedron.Name = "tetrahedron";
            this.tetrahedron.Size = new Size(73, 17);
            this.tetrahedron.TabIndex = 10;
            this.tetrahedron.TabStop = true;
            this.tetrahedron.Text = "Тетраэдр";
            this.tetrahedron.UseVisualStyleBackColor = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange((DataGridViewColumn)this.Number, (DataGridViewColumn)this.NameClass, (DataGridViewColumn)this.XY, (DataGridViewColumn)this.Info1, (DataGridViewColumn)this.Info2, (DataGridViewColumn)this.Info);
            this.dataGridView1.Location = new Point(525, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new Size(675, 126);
            this.dataGridView1.TabIndex = 11;
            this.Number.HeaderText = "Номер";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.NameClass.HeaderText = "Имя класса";
            this.NameClass.Name = "NameClass";
            this.NameClass.ReadOnly = true;
            this.XY.HeaderText = "Информация о фигуре";
            this.XY.Name = "XY";
            this.XY.Width = 130;
            this.Info1.HeaderText = "Площадь";
            this.Info1.Name = "Info1";
            this.Info1.ReadOnly = true;
            this.Info2.HeaderText = "Периметр";
            this.Info2.Name = "Info2";
            this.Info2.ReadOnly = true;
            this.Info.HeaderText = "Закрашеность";
            this.Info.Name = "Info";
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)204);
            this.label1.Location = new Point(708, 177);
            this.label1.Name = "label1";
            this.label1.Size = new Size(102, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Смещение:";
            this.label2.AutoSize = true;
            this.label2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte)204);
            this.label2.Location = new Point(708, 209);
            this.label2.Name = "label2";
            this.label2.Size = new Size(91, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Масштаб:";
            this.textBox1.Location = new Point(854, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(61, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "№ фигуры";
            this.textBox2.Location = new Point(936, 176);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(100, 20);
            this.textBox2.TabIndex = 15;
            this.textBox2.Text = "X,Y";
            this.textBox3.Location = new Point(854, 209);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Size(61, 20);
            this.textBox3.TabIndex = 16;
            this.textBox3.Text = "№ фигуры";
            this.textBox4.Location = new Point(936, 209);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Size(42, 20);
            this.textBox4.TabIndex = 17;
            this.textBox4.Text = "N";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[2]
            {
        (object) "Уменьшить",
        (object) "Увеличить"
            });
            this.comboBox1.Location = new Point(997, 207);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new Size(121, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.Text = "Ув/Ум";
            this.button3.Location = new Point(1091, 173);
            this.button3.Name = "button3";
            this.button3.Size = new Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Сместить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new EventHandler(this.button3_Click);
            this.button4.Location = new Point(1138, 205);
            this.button4.Name = "button4";
            this.button4.Size = new Size(75, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "Изменить";
            this.button4.UseVisualStyleBackColor = true;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1243, 664);
            this.Controls.Add((Control)this.button4);
            this.Controls.Add((Control)this.button3);
            this.Controls.Add((Control)this.comboBox1);
            this.Controls.Add((Control)this.textBox4);
            this.Controls.Add((Control)this.textBox3);
            this.Controls.Add((Control)this.textBox2);
            this.Controls.Add((Control)this.textBox1);
            this.Controls.Add((Control)this.label2);
            this.Controls.Add((Control)this.label1);
            this.Controls.Add((Control)this.dataGridView1);
            this.Controls.Add((Control)this.tetrahedron);
            this.Controls.Add((Control)this.checkBox);
            this.Controls.Add((Control)this.RightTriangle);
            this.Controls.Add((Control)this.button2);
            this.Controls.Add((Control)this.ETriangle);
            this.Controls.Add((Control)this.Line3);
            this.Controls.Add((Control)this.Line);
            this.Controls.Add((Control)this.Box);
            this.Controls.Add((Control)this.button1);
            this.Controls.Add((Control)this.groupBox1);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new EventHandler(this.Form1_Load);
            this.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            ((ISupportInitialize)this.dataGridView1).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        */
    }
}