
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    internal class Program
    {
        static double Calculate(double x)
        {
            return 2 * Math.Cos(1.0 / (x * x + 2))
                   / (x * x * x + 1);
        }

        static void Main(string[] args)
        {
            Console.Write("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            if (x == -1)
            {
                Console.WriteLine("Функция не определена при x = -1.");
            }
            else
            {
                double y = Calculate(x);
                Console.WriteLine("y = " + y);
            }

            Console.ReadKey();
        }
    }
}
