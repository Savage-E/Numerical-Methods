using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicImplementation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Right part of y'=f(x,y)
        static public double func(double x, double y)
        {
            // return x * x - 2 * y;
            return Math.Tan(x + 2 * y) / (x * x + y);
        }

        private double a, b; //The range on which is being calculating y(x).
        private double h; // Step.
        private int n; // Amount of points on which are being calculated the decision.

        private double[] x;
        private double[] y;
        private double[] f;

        public PlotView pv = new PlotView
        {
            Location = new Point(0, 0),
            Size = new Size(700, 500),
            Model = new PlotModel { Title = "f(x,y)=tan(x+2y)/(x^2-y)  y(1)=1 " },
        };

        private void Modified_Euler_CheckedChanged(object sender, EventArgs e)
        {
            dv.Rows.Clear();

            pv.Model = new PlotModel { Title = "f(x,y)=tan(x+2y)/(x^2-y)  y(1)=1 Midified Euler" };
            FunctionSeries fs = new FunctionSeries();
            pv.Model.Series.Add(fs);
            fs.Color = OxyColors.Black;
            fs.MarkerStroke = OxyColors.Red;
            fs.MarkerType = MarkerType.Cross;
            fs.MarkerSize = 5;

            x = new double[n];
            y = new double[n];

            //x[0] = 0;
            //y[0] = 1;
            x[0] = 1;
            y[0] = 1;
            fs.Points.Add(new DataPoint(x[0], y[0]));

            double y12;
            for (int i = 0; i < n - 1; i++)
            {
                y12 = y[i] + h / 2 * func(x[i], y[i]);
                y[i + 1] = y[i] + h * func(x[i] + h / 2, y12);
                x[i + 1] = x[i] + h;
                fs.Points.Add(new DataPoint(x[i + 1], y[i + 1]));
            }
            ShowPoints();
        }

        private void Euler_CheckedChanged(object sender, EventArgs e)
        {
            pv.Model = new PlotModel { Title = "f(x,y)=tan(x+2y)/(x^2-y)  y(1)=1 Euler" };
            dv.Rows.Clear();
            FunctionSeries fs = new FunctionSeries();
            pv.Model.Series.Add(fs);
            fs.Color = OxyColors.Black;
            fs.MarkerStroke = OxyColors.Red;
            fs.MarkerType = MarkerType.Cross;
            fs.MarkerSize = 5;

            x = new double[n];
            y = new double[n];

            // x[0] = 0;
            // y[0] = 1;
            x[0] = 1;
            y[0] = 1;
            fs.Points.Add(new DataPoint(x[0], y[0]));

            double yii;
            for (int i = 0; i < n - 1; i++)
            {
                yii = y[i] + h * func(x[i], y[i]);
                y[i + 1] = y[i] + h / 2 * (func(x[i], y[i]) + func(x[i] + h, yii));
                x[i + 1] = x[i] + h;
                fs.Points.Add(new DataPoint(x[i + 1], y[i + 1]));
            }

            ShowPoints();
        }

        private void Euler_w_Right_CheckedChanged(object sender, EventArgs e)
        {
            pv.Model = new PlotModel { Title = "f(x,y)=tan(x+2y)/(x^2-y)  y(1)=1 Euler with right difference" };
            dv.Rows.Clear();
            FunctionSeries fs = new FunctionSeries();
            pv.Model.Series.Add(fs);
            fs.Color = OxyColors.Black;
            fs.MarkerStroke = OxyColors.Red;
            fs.MarkerType = MarkerType.Cross;
            fs.MarkerSize = 5;

            x = new double[n];
            y = new double[n];

            x[0] = 1;
            y[0] = 1;

            fs.Points.Add(new DataPoint(x[0], y[0]));

            for (int i = 0; i < n - 1; i++)
            {
                y[i + 1] = y[i] + h * func(x[i], y[i]);
                x[i + 1] = x[i] + h;
                fs.Points.Add(new DataPoint(x[i + 1], y[i + 1]));
            }

            ShowPoints();
        }

        private void Euler_central_CheckedChanged(object sender, EventArgs e)
        {
            pv.Model = new PlotModel { Title = "f(x,y)=tan(x+2y)/(x^2-y)  y(1)=1 Euler with cental difference" };
            dv.Rows.Clear();
            FunctionSeries fs = new FunctionSeries();
            pv.Model.Series.Add(fs);
            fs.Color = OxyColors.Black;
            fs.MarkerStroke = OxyColors.Red;
            fs.MarkerType = MarkerType.Cross;
            fs.MarkerSize = 5;

            x = new double[n];
            y = new double[n];

            x[0] = 1;
            y[0] = 1;

            fs.Points.Add(new DataPoint(x[0], y[0]));

            y[1] = y[0] + h * func(x[0], y[0]);
            x[1] = x[0] + h;

            fs.Points.Add(new DataPoint(x[1], y[1]));

            for (int i = 1; i < n - 1; i++)
            {
                y[i + 1] = y[i - 1] + 2 * h * func(x[i], y[i]);
                x[i + 1] = x[i] + h;
                fs.Points.Add(new DataPoint(x[i + 1], y[i + 1]));
            }

            ShowPoints();
        }

        private void GraphicsForm_Load(object sender, EventArgs e)
        {
            Controls.Add(pv);
            //a = 0;
            // b = 1;
            a = 1;
            b = 2;
            h = 0.01;
            n = (int)Math.Ceiling((b - a) / h) + 1;
            x = new double[n];
            y = new double[n];

            //x[0] = 0;
            //y[0]=1
            x[0] = 1;
            y[0] = 1;
        }

        private void Rugle_Kutte_CheckedChanged(object sender, EventArgs e)
        {
            pv.Model = new PlotModel { Title = "f(x,y)=tan(x+2y)/(x^2-y)  y(1)=1 Runge-Kutta" };
            dv.Rows.Clear();
            FunctionSeries fs = new FunctionSeries();
            pv.Model.Series.Add(fs);
            fs.Color = OxyColors.Black;
            fs.MarkerStroke = OxyColors.Red;
            fs.MarkerType = MarkerType.Cross;
            fs.MarkerSize = 5;

            x = new double[n];
            y = new double[n];

            //            x[0] = 0;
            //          y[0] = 1;

            x[0] = 1;
            y[0] = 1;
            double k0, k1, k2, k3;

            fs.Points.Add(new DataPoint(x[0], y[0]));

            for (int i = 0; i < n - 1; i++)
            {
                k0 = func(x[i], y[i]);
                k1 = func(x[i] + h / 2, y[i] + h * k0 / 2);
                k2 = func(x[i] + h / 2, y[i] + h * k1 / 2);
                k3 = func(x[i] + h, y[i] + h * k2);
                y[i + 1] = y[i] + h / 6 * (k0 + 2 * k1 + 2 * k2 + k3);
                x[i + 1] = x[i] + h;
                fs.Points.Add(new DataPoint(x[i + 1], y[i + 1]));
            }

            ShowPoints();
        }

        private void Adams_CheckedChanged(object sender, EventArgs e)
        {
            pv.Model = new PlotModel { Title = "f(x,y)=tan(x+2y)/(x^2-y)  y(1)=1 Adams" };
            dv.Rows.Clear();
            FunctionSeries fs = new FunctionSeries();
            pv.Model.Series.Add(fs);
            fs.Color = OxyColors.Black;
            fs.MarkerStroke = OxyColors.Red;
            fs.MarkerType = MarkerType.Cross;
            fs.MarkerSize = 5;

            x = new double[n];
            y = new double[n];
            f = new double[n];

            //x[0] = 0;

            //y[0] = 1;
            x[0] = 1;
            y[0] = 1;
            f[0] = func(x[0], y[0]);

            fs.Points.Add(new DataPoint(x[0], y[0]));


            //Calculating the approximate value in the 1st point by Euler's method.
            x[1] = x[0] + h;
            y[1] = y[0] + h * f[0];
            f[1] = func(x[1], y[1]);

            fs.Points.Add(new DataPoint(x[1], y[1]));

            //Calculating the approximate value in the 2nd point by 2nd order Adams method.
            x[2] = x[1] + h;
            y[2] = y[1] + h * (3 / 2 * f[1] - 1 / 2 * f[0]);
            f[2] = func(x[2], y[2]);
            fs.Points.Add(new DataPoint(x[2], y[2]));


            //Calculating the approximate value in the 3rd point by 3rd order Adams method.
            x[3] = x[2] + h;
            y[3] = y[2] + h / 12 * (23 * f[2] - 16 * f[1] + 5 * f[0]);
            f[3] = func(x[3], y[3]);

            fs.Points.Add(new DataPoint(x[3], y[3]));

            //Calculating approximate values in subsequent points by 4th order Adams method.
            for (int i = 3; i < n - 1; i++)
            {
                y[i + 1] = y[i] + h / 24 * (55 * f[i] - 59 * f[i - 1] + 37 * f[i - 2] - 9 * f[i - 3]);
                x[i + 1] = x[i] + h;
                f[i + 1] = func(x[i + 1], y[i + 1]);
                fs.Points.Add(new DataPoint(x[i + 1], y[i + 1]));
            }
            ShowPoints();
        }

        /// <summary>
        /// Showing points in the grid.
        /// </summary>
        private void ShowPoints()
        {
            for (int i = 0; i < n ; i++)
            {
                dv.Rows.Add();
                dv.Rows[i].Cells["Xi"].Value = x[i];
                dv.Rows[i].Cells["Yi"].Value = y[i];
            }
        }
    }
}