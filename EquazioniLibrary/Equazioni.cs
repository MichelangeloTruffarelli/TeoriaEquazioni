using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class Equazioni
    {
        public static bool IsDeterminated(double a, double b)
        {
            if (a != 0 && b != 0)
            {
                return true;
            } else
            {
                return false;
            }
        }
        public static bool IsInconsisted(double a, double b)
        {
            if (a == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsDegree2(double a)
        {
            if (a != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static double Delta (double a, double b, double c)
        {
            double Delta;
            if ( a == 0)
            {
                return Delta = Double.NaN; 
            }
            else 
                 Delta = (b * b) - (4 * a * c);
            return Delta;
        }
        public static string EquationDegree1(double a , double b)
        {
            if ( a == 0 && b != 0)
            {
                return "indeterminata";
            }
            else if(a == 0 && b != 0)
            {
                return "impossibile";
            }
            string y;
            y = ((-b) / a).ToString();
            return y;
        }
    }
}
