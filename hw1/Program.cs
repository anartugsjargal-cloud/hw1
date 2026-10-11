
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    internal class Program
    {
        static double Calculate(double a, double b)
        {
            return (Math.Sin(a) + Math.Sqrt(a)) /
                   (Math.Cos(b) + Math.Sqrt(b));
        }

        static void Main(string[] args)
        {
            double x = Calculate(3, 5) *
                       Calculate(3, 7) *
                       Calculate(5, 5);

            Console.WriteLine($"x = {x:F3}");
        }
    }
}
