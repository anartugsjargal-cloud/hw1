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
            Console.WriteLine("Введите четырехзначное число: ");
            int number = int.Parse(Console.ReadLine());

            int a = number / 1000;
            int b = (number / 100) % 10;  
            int c = (number / 10) % 10;
            int d = number % 10;

            int reversed = d * 1000 + c * 100 + b * 10 + a;

            Console.WriteLine("Число с обратным порядком цифр: " + reversed);
        }
    }
}
