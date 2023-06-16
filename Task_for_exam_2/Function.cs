using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_for_exam_2
{
    internal class Function
    {
        //private int a, b;
        //public int A { get { return a; } set { a = value; } }
        //public int B { get { return b; } set { b = value; } }
        //Decarts p;

        public double a, b, c;
        public double minY, maxY, minX, maxX;
        public string functionIntegral;

        public Function(double a, double b, double c, 
                        double minX = -10, double maxX = 10, double minY = -10, double maxY = 10)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.minY = minY;
            this.maxY = maxY;
            this.minX = minX;
            this.maxX = maxX;
        }

        public double func(double x)
        {
            return a * Math.Exp(b * x) + c * x;
        }

        public Decarts point(double x)
        {
            return new Decarts(x, func(x));
        }

    }
}
