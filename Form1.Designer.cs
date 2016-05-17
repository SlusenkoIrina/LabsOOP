namespace лаба3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Box = new System.Windows.Forms.RichTextBox();
            this.Line = new System.Windows.Forms.RadioButton();
            this.Line3 = new System.Windows.Forms.RadioButton();
            this.ETriangle = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.RightTriangle = new System.Windows.Forms.RadioButton();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.tetrahedron = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Info1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Info2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1237, 381);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(-1, 260);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1243, 406);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Редактор";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(219, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Нажми меня";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Box
            // 
            this.Box.Location = new System.Drawing.Point(280, 25);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(184, 59);
            this.Box.TabIndex = 3;
            this.Box.Text = "";
            // 
            // Line
            // 
            this.Line.AutoSize = true;
            this.Line.Location = new System.Drawing.Point(37, 12);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(57, 17);
            this.Line.TabIndex = 4;
            this.Line.TabStop = true;
            this.Line.Text = "Линия";
            this.Line.UseVisualStyleBackColor = true;
            // 
            // Line3
            // 
            this.Line3.AutoSize = true;
            this.Line3.Location = new System.Drawing.Point(37, 36);
            this.Line3.Name = "Line3";
            this.Line3.Size = new System.Drawing.Size(90, 17);
            this.Line3.TabIndex = 5;
            this.Line3.TabStop = true;
            this.Line3.Text = "Треугольник";
            this.Line3.UseVisualStyleBackColor = true;
            // 
            // ETriangle
            // 
            this.ETriangle.AutoSize = true;
            this.ETriangle.Location = new System.Drawing.Point(37, 59);
            this.ETriangle.Name = "ETriangle";
            this.ETriangle.Size = new System.Drawing.Size(175, 17);
            this.ETriangle.TabIndex = 6;
            this.ETriangle.TabStop = true;
            this.ETriangle.Text = "Равносторонний треугольник";
            this.ETriangle.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(388, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 41);
            this.button2.TabIndex = 7;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RightTriangle
            // 
            this.RightTriangle.AutoSize = true;
            this.RightTriangle.Location = new System.Drawing.Point(37, 82);
            this.RightTriangle.Name = "RightTriangle";
            this.RightTriangle.Size = new System.Drawing.Size(173, 17);
            this.RightTriangle.TabIndex = 8;
            this.RightTriangle.TabStop = true;
            this.RightTriangle.Text = "Прямоугольный треугольник";
            this.RightTriangle.UseVisualStyleBackColor = true;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(280, 97);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(80, 17);
            this.checkBox.TabIndex = 9;
            this.checkBox.Text = "Закрасить";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // tetrahedron
            // 
            this.tetrahedron.AutoSize = true;
            this.tetrahedron.Location = new System.Drawing.Point(37, 106);
            this.tetrahedron.Name = "tetrahedron";
            this.tetrahedron.Size = new System.Drawing.Size(73, 17);
            this.tetrahedron.TabIndex = 10;
            this.tetrahedron.TabStop = true;
            this.tetrahedron.Text = "Тетраэдр";
            this.tetrahedron.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.NameClass,
            this.XY,
            this.Info1,
            this.Info2,
            this.Info});
            this.dataGridView1.Location = new System.Drawing.Point(525, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(675, 126);
            this.dataGridView1.TabIndex = 11;
            // 
            // Number
            // 
            this.Number.HeaderText = "Номер";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // NameClass
            // 
            this.NameClass.HeaderText = "Имя класса";
            this.NameClass.Name = "NameClass";
            this.NameClass.ReadOnly = true;
            // 
            // XY
            // 
            this.XY.HeaderText = "Информация о фигуре";
            this.XY.Name = "XY";
            this.XY.Width = 130;
            // 
            // Info1
            // 
            this.Info1.HeaderText = "Площадь";
            this.Info1.Name = "Info1";
            this.Info1.ReadOnly = true;
            // 
            // Info2
            // 
            this.Info2.HeaderText = "Периметр";
            this.Info2.Name = "Info2";
            this.Info2.ReadOnly = true;
            // 
            // Info
            // 
            this.Info.HeaderText = "Закрашеность";
            this.Info.Name = "Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(708, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Смещение:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(708, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Масштаб:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(854, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(61, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "№ фигуры";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(936, 176);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 15;
            this.textBox2.Text = "X,Y";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(854, 209);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(61, 20);
            this.textBox3.TabIndex = 16;
            this.textBox3.Text = "№ фигуры";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(936, 209);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(42, 20);
            this.textBox4.TabIndex = 17;
            this.textBox4.Text = "N";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Уменьшить",
            "Увеличить"});
            this.comboBox1.Location = new System.Drawing.Point(997, 207);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.Text = "Ув/Ум";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1091, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Сместить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1138, 205);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "Изменить";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 664);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tetrahedron);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.RightTriangle);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ETriangle);
            this.Controls.Add(this.Line3);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox Box;
        private System.Windows.Forms.RadioButton Line;
        private System.Windows.Forms.RadioButton Line3;
        private System.Windows.Forms.RadioButton ETriangle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton RightTriangle;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.RadioButton tetrahedron;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn XY;
        private System.Windows.Forms.DataGridViewTextBoxColumn Info1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Info2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

