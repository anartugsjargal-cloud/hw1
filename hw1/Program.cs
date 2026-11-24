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
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Введите x: ");
            double x = double.Parse(Console.ReadLine());

            double sum = 0;

            for (int i = 0; i <= n; i++)
            {
                sum += (double)(i + 1) / (i + 2) * Math.Pow(x, i);
            }

            Console.WriteLine("Сумма = " + sum);
    }
    }
}
