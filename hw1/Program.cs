using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    internal class Program
    {
        static bool Check(int m, int n)
        {
            return (m % 2 == 0) != (n % 2 == 0);
        }

        static void Main(string[] args)
        {
            Console.Write("Введите m: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());

            bool result = Check(m, n);

            Console.WriteLine("Результат: " + result);
            Console.ReadKey();
        }
    }
}
