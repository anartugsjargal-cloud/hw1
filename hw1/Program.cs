using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону квадрата:");
            double a = Convert.ToDouble(Console.ReadLine());

            double S = a * a;
            double P = 4 * a;

            Console.WriteLine("Площадь квадрата: " + S);
            Console.WriteLine("Периметр квадрата: " + P);
        }
    }
}
