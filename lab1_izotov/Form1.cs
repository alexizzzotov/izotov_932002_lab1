using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateTable();
        }

        const double g = 9.81, c = 0.15, rho = 1.29;

        double height, angle, weight, size, speed, dt, maxheight = 0.00;

        private void adSize_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        double cosa, sina, beta, k; 
        double t, x, y, vx, vy, vx_old, vy_old;

        public void CreateTable()
        {
            DataGridViewTextBoxColumn column0 = new DataGridViewTextBoxColumn();
            column0.Name = "TS";
            column0.HeaderText = "Time Step";
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.Name = "D";
            column1.HeaderText = "Distance";
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.Name = "MH";
            column2.HeaderText = "Max height";
            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.Name = "S";
            column3.HeaderText = "Speed at the end point";

            Table1.Columns.AddRange(column0, column1, column2, column3); 
        }

        private void addInfo()
        {
            DataGridViewCell ts0 = new DataGridViewTextBoxCell();
            DataGridViewCell d0 = new DataGridViewTextBoxCell();
            DataGridViewCell mh0 = new DataGridViewTextBoxCell();
            DataGridViewCell s0 = new DataGridViewTextBoxCell();
            DataGridViewRow row0 = new DataGridViewRow();

            ts0.Value = dt.ToString("0.0000");
            d0.Value = x.ToString("0.00");
            mh0.Value = maxheight.ToString("0.00");
            //s0.Value = (Math.Abs(vx_old - vx) / dt).ToString("0.00");
            s0.Value = Math.Sqrt((vx_old - vx) * (vx_old - vx) + (vy_old - vy) * (vy_old - vy)).ToString("0.00");
            row0.Cells.AddRange(ts0, d0, mh0, s0);
            Table1.Rows.Add(row0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maxheight = 0.0; 
            dt = (double)adStep.Value;
            height = (double)adHeight.Value;
            angle = (double)adAngle.Value;
            weight = (double)adWeight.Value;
            size = (double)adSize.Value;
            speed = (double)adSpeed.Value;

            cosa = Math.Cos(angle * Math.PI / 180);
            sina = Math.Cos(angle * Math.PI / 180);

            beta = 0.5 * c * size * rho;
            k = beta / weight;

            t = 0;
            x = 0;
            y = height;
            vx = speed * cosa;
            vy = speed * sina;

            chart1.Series[0].Points.AddXY(x, y);

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            vx_old = vx;
            vy_old = vy;
            double root = Math.Sqrt(vx * vx + vy * vy);

            if (y > maxheight) maxheight = y;

            t = t + dt;

            vx = vx_old - k * vx_old * root * dt; 
            vy = vy_old - (g + k * vy_old * root) * dt;

            x = x + vx * dt; 
            y = y + vy * dt;

            chart1.Series[0].Points.AddXY(x, y);

            if (y <= 0)
            {
                addInfo();
                timer1.Stop();
            } 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
