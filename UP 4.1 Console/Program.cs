using System;

namespace UP_4._1_Console
{
    internal class Program
    {
        static int NOD(int a, int b)
        {
            if (a > b) return NOD(a - b, b);

            else if (a < b) return NOD(a, b - a);
            else return a;
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Введите целое положительное число a: ");
            while (!int.TryParse(Console.ReadLine(), out a) || a <= 0)
            {
                Console.WriteLine("Введены недопустимые значения! Попробуйте снова!");
                Console.Write("Введите целое положительное число а: ");
            }

            Console.Write("Введите целое положительное число b: ");
            while (!int.TryParse(Console.ReadLine(), out b) || b <= 0)
            {
                Console.WriteLine("Введены недопустимые значения! Попробуйте снова!");
                Console.Write("Введите целое положительное число b: ");
            }
            
            Console.WriteLine($"Наибольший общий делитель для чисел {a} и {b}: " + NOD(a, b));
        }
    }
}
