using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTaskConsole
{
  public  class Program
    {
     public  static void Main(string[] args)
        {
        }

        public static double Divide(double a, double b)
        {
            double result = 0;

            try
            {
                if (b != 0)
                {
                    result = a / b;
                }
                
            }
            catch (Exception)
            {
                throw new DivideByZeroException();
            }
            return result;

        }
    }
}
