namespace lab1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.adStep = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.adWeight = new System.Windows.Forms.NumericUpDown();
            this.adSize = new System.Windows.Forms.NumericUpDown();
            this.adSpeed = new System.Windows.Forms.NumericUpDown();
            this.adAngle = new System.Windows.Forms.NumericUpDown();
            this.adHeight = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Table1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.adStep);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.adWeight);
            this.panel1.Controls.Add(this.adSize);
            this.panel1.Controls.Add(this.adSpeed);
            this.panel1.Controls.Add(this.adAngle);
            this.panel1.Controls.Add(this.adHeight);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 123);
            this.panel1.TabIndex = 0;
            // 
            // adStep
            // 
            this.adStep.DecimalPlaces = 4;
            this.adStep.Location = new System.Drawing.Point(303, 78);
            this.adStep.Name = "adStep";
            this.adStep.Size = new System.Drawing.Size(120, 22);
            this.adStep.TabIndex = 12;
            this.adStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Step";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(473, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adWeight
            // 
            this.adWeight.DecimalPlaces = 2;
            this.adWeight.Location = new System.Drawing.Point(303, 47);
            this.adWeight.Name = "adWeight";
            this.adWeight.Size = new System.Drawing.Size(120, 22);
            this.adWeight.TabIndex = 9;
            this.adWeight.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // adSize
            // 
            this.adSize.DecimalPlaces = 2;
            this.adSize.Location = new System.Drawing.Point(303, 14);
            this.adSize.Name = "adSize";
            this.adSize.Size = new System.Drawing.Size(120, 22);
            this.adSize.TabIndex = 8;
            this.adSize.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.adSize.ValueChanged += new System.EventHandler(this.adSize_ValueChanged);
            // 
            // adSpeed
            // 
            this.adSpeed.DecimalPlaces = 2;
            this.adSpeed.Location = new System.Drawing.Point(75, 78);
            this.adSpeed.Name = "adSpeed";
            this.adSpeed.Size = new System.Drawing.Size(120, 22);
            this.adSpeed.TabIndex = 7;
            this.adSpeed.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // adAngle
            // 
            this.adAngle.DecimalPlaces = 2;
            this.adAngle.Location = new System.Drawing.Point(75, 47);
            this.adAngle.Name = "adAngle";
            this.adAngle.Size = new System.Drawing.Size(120, 22);
            this.adAngle.TabIndex = 6;
            this.adAngle.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // adHeight
            // 
            this.adHeight.DecimalPlaces = 2;
            this.adHeight.Location = new System.Drawing.Point(75, 14);
            this.adHeight.Name = "adHeight";
            this.adHeight.Size = new System.Drawing.Size(120, 22);
            this.adHeight.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Weight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Angle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Height";
            // 
            // Table1
            // 
            this.Table1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table1.Location = new System.Drawing.Point(15, 658);
            this.Table1.Name = "Table1";
            this.Table1.RowHeadersWidth = 51;
            this.Table1.RowTemplate.Height = 24;
            this.Table1.Size = new System.Drawing.Size(604, 173);
            this.Table1.TabIndex = 13;
            // 
            // chart1
            // 
            chartArea1.AxisX.Maximum = 25D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Maximum = 6D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(15, 142);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1045, 510);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 853);
            this.Controls.Add(this.Table1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Table1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown adWeight;
        private System.Windows.Forms.NumericUpDown adSize;
        private System.Windows.Forms.NumericUpDown adSpeed;
        private System.Windows.Forms.NumericUpDown adAngle;
        private System.Windows.Forms.NumericUpDown adHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown adStep;
        private System.Windows.Forms.DataGridView Table1;
    }
}

