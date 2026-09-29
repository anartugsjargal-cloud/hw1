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
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("А. С. Пушкин");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Я помню чудное мгновенье...");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Я помню чудное мгновенье:");
            Console.WriteLine("Передо мной явилась ты,");
            Console.WriteLine("Как мимолётное виденье,");
            Console.WriteLine("Как гений чистой красоты.");
            Console.ResetColor();

        }
    }
}
