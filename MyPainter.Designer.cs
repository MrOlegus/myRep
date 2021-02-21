
namespace Lab1
{
    partial class MyPainter
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
            this.components = new System.ComponentModel.Container();
            this.Canvas = new System.Windows.Forms.PictureBox();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPolygon = new System.Windows.Forms.Button();
            this.btnPolyline = new System.Windows.Forms.Button();
            this.colorDialogFill = new System.Windows.Forms.ColorDialog();
            this.spinDepth = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelColorOutline = new System.Windows.Forms.Panel();
            this.panelColorFill = new System.Windows.Forms.Panel();
            this.btnOutline = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.labelDepth = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinDepth)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Canvas.BackColor = System.Drawing.SystemColors.Window;
            this.Canvas.Location = new System.Drawing.Point(12, 12);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(927, 729);
            this.Canvas.TabIndex = 0;
            this.Canvas.TabStop = false;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.Canvas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDoubleClick);
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRectangle.Location = new System.Drawing.Point(3, 333);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(217, 49);
            this.btnRectangle.TabIndex = 2;
            this.btnRectangle.Text = "Прямоугольник";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.DefineFigure);
            // 
            // btnSquare
            // 
            this.btnSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSquare.Location = new System.Drawing.Point(3, 278);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(217, 49);
            this.btnSquare.TabIndex = 3;
            this.btnSquare.Text = "Квадрат";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.DefineFigure);
            // 
            // btnLine
            // 
            this.btnLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLine.Location = new System.Drawing.Point(3, 3);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(217, 49);
            this.btnLine.TabIndex = 4;
            this.btnLine.Text = "Отрезок";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.DefineFigure);
            // 
            // btnEllipse
            // 
            this.btnEllipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEllipse.Location = new System.Drawing.Point(3, 223);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(217, 49);
            this.btnEllipse.TabIndex = 5;
            this.btnEllipse.Text = "Эллипс";
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.DefineFigure);
            // 
            // btnCircle
            // 
            this.btnCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCircle.Location = new System.Drawing.Point(3, 168);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(217, 49);
            this.btnCircle.TabIndex = 6;
            this.btnCircle.Text = "Окружность";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.DefineFigure);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnPolygon);
            this.panel1.Controls.Add(this.btnPolyline);
            this.panel1.Controls.Add(this.btnRectangle);
            this.panel1.Controls.Add(this.btnCircle);
            this.panel1.Controls.Add(this.btnSquare);
            this.panel1.Controls.Add(this.btnEllipse);
            this.panel1.Controls.Add(this.btnLine);
            this.panel1.Location = new System.Drawing.Point(945, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 388);
            this.panel1.TabIndex = 7;
            // 
            // btnPolygon
            // 
            this.btnPolygon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPolygon.Location = new System.Drawing.Point(3, 113);
            this.btnPolygon.Name = "btnPolygon";
            this.btnPolygon.Size = new System.Drawing.Size(217, 49);
            this.btnPolygon.TabIndex = 8;
            this.btnPolygon.Text = "Многоугольник";
            this.btnPolygon.UseVisualStyleBackColor = true;
            this.btnPolygon.Click += new System.EventHandler(this.DefineFigure);
            // 
            // btnPolyline
            // 
            this.btnPolyline.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPolyline.Location = new System.Drawing.Point(3, 58);
            this.btnPolyline.Name = "btnPolyline";
            this.btnPolyline.Size = new System.Drawing.Size(217, 49);
            this.btnPolyline.TabIndex = 7;
            this.btnPolyline.Text = "Ломаная";
            this.btnPolyline.UseVisualStyleBackColor = true;
            this.btnPolyline.Click += new System.EventHandler(this.DefineFigure);
            // 
            // spinDepth
            // 
            this.spinDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spinDepth.Location = new System.Drawing.Point(165, 150);
            this.spinDepth.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.spinDepth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinDepth.Name = "spinDepth";
            this.spinDepth.Size = new System.Drawing.Size(57, 36);
            this.spinDepth.TabIndex = 9;
            this.spinDepth.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.spinDepth.ValueChanged += new System.EventHandler(this.SpinDepth_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.panelColorOutline);
            this.panel2.Controls.Add(this.panelColorFill);
            this.panel2.Controls.Add(this.btnOutline);
            this.panel2.Controls.Add(this.btnFill);
            this.panel2.Controls.Add(this.labelDepth);
            this.panel2.Controls.Add(this.spinDepth);
            this.panel2.Location = new System.Drawing.Point(945, 547);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 194);
            this.panel2.TabIndex = 10;
            // 
            // panelColorOutline
            // 
            this.panelColorOutline.BackColor = System.Drawing.Color.Black;
            this.panelColorOutline.Location = new System.Drawing.Point(165, 84);
            this.panelColorOutline.Name = "panelColorOutline";
            this.panelColorOutline.Size = new System.Drawing.Size(41, 41);
            this.panelColorOutline.TabIndex = 12;
            // 
            // panelColorFill
            // 
            this.panelColorFill.BackColor = System.Drawing.Color.White;
            this.panelColorFill.Location = new System.Drawing.Point(165, 12);
            this.panelColorFill.Name = "panelColorFill";
            this.panelColorFill.Size = new System.Drawing.Size(41, 41);
            this.panelColorFill.TabIndex = 11;
            // 
            // btnOutline
            // 
            this.btnOutline.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOutline.Location = new System.Drawing.Point(8, 84);
            this.btnOutline.Name = "btnOutline";
            this.btnOutline.Size = new System.Drawing.Size(150, 41);
            this.btnOutline.TabIndex = 12;
            this.btnOutline.Text = "Контур";
            this.btnOutline.UseVisualStyleBackColor = true;
            this.btnOutline.Click += new System.EventHandler(this.BtnOutline_Click);
            // 
            // btnFill
            // 
            this.btnFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFill.Location = new System.Drawing.Point(8, 12);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(150, 41);
            this.btnFill.TabIndex = 9;
            this.btnFill.Text = "Заливка";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.BtnFill_Click);
            // 
            // labelDepth
            // 
            this.labelDepth.AutoSize = true;
            this.labelDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDepth.Location = new System.Drawing.Point(3, 157);
            this.labelDepth.Name = "labelDepth";
            this.labelDepth.Size = new System.Drawing.Size(126, 29);
            this.labelDepth.TabIndex = 11;
            this.labelDepth.Text = "Толщина:";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 10;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // MyPainter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Canvas);
            this.DoubleBuffered = true;
            this.Name = "MyPainter";
            this.Text = "MyPainter";
            ((System.ComponentModel.ISupportInitialize)(this.Canvas)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spinDepth)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox Canvas;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPolyline;
        private System.Windows.Forms.Button btnPolygon;
        private System.Windows.Forms.NumericUpDown spinDepth;
        private System.Windows.Forms.ColorDialog colorDialogFill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Button btnOutline;
        private System.Windows.Forms.Panel panelColorOutline;
        private System.Windows.Forms.Panel panelColorFill;
        private System.Windows.Forms.Label labelDepth;
        private System.Windows.Forms.Timer Timer;
    }
}

