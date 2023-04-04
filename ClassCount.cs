using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting18Pract;

namespace UnitTesting18Pract
{
    public class ClassCount
    {
        private double result = 0.0;

        public double GetResult()
        {
            return result;
        }

        public void Count(string[] args)
        {
            double a = 2.5; // replace with actual value
            double b = 1.2; // replace with actual value
            double c = 3.8; // replace with actual value
            double x = 4.0; // replace with actual value



            if (a < 0 & x != 0) { result = a * x * x + b * b * x; }
            if (x == 0 & a > 0) { result = x - (a / (x - c)); }
            else { result = 1 + (x / c); }

            // display the result
            Console.WriteLine("The value of the function F is: {0}", result);

            // wait for user input before closing the console window
            Console.ReadKey();


        }

    }
}
