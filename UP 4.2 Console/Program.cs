using System;

namespace UP_4._2_Console
{
    internal class Program
    {
        static void Function (int n)
        {
            if (n == 0) 
                return;
            else 
                Function(n - 1);

            Console.Write(n + " ");
        }
        static void Main(string[] args)
        {
            int N;
            Console.Write("Введите число N, большее или равное 1000: ");
            while (!int.TryParse(Console.ReadLine(), out N) || N < 1000)
                Console.Write("Введены некорректные данные! Введите N (>= 1000) еще раз: ");

            Console.WriteLine();
            Function(N);
        }
    }
}
