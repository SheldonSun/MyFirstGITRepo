using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExcelLibrary.SpreadSheet;
using System.Threading;

namespace GNN4PortfolioOptimizationClass
{
    public class GNN4PO
    {
        public double k { get; set; }
        public double R { get; set; }
        public double T { get; set; }
        public double w { get; set; }
        public double a { get; set; }

        const double r = 0.1;

        public static Random SingletonRrd = new Random();


        public GNN4PO()
        {
            k = NextDouble(0.0002, 0.0006);
            R = NextDouble(0.3, 1);
            T = NextDouble(2, 5);
            w = NextDouble(0, 2 * Math.PI);
           }

        public void CalculateA (double t)
        {
                 a = r + k * t + R * Math.Sin(t / T + w);
        }

        double NextDouble(double min, double max)
        {
            return min + (SingletonRrd.NextDouble() * (max - min));
        }




    }




}
