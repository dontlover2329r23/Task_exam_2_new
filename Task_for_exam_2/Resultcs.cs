using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task_for_exam_2
{
   public class Result
{
    public static double Integrate(Func<double, double> function, double aa, double bb, double epsilon,double max_step,double a,double b,double c)
    {
            double fa = function(aa);
            double fb = function(bb);
            int k = 0;
            double xm, fm;
            while((Math.Abs(bb-aa)> epsilon) &&(k < max_step)){
                xm=(aa + bb) / 2;
                fm = function(xm);
                if (fm == 0)
                {
                    return xm;
                }
                if(fa*fm <= 0)
                {
                    bb = xm;
                    fb = fm;

                }
                else
                {
                    aa = xm;
                    fa = fm;
                }
                k++;
            }

            return (aa + bb) / 2;
        }
    
    
}
}
