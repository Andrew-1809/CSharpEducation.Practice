using System;

namespace Practice2.Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите переменную №1: ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите переменную №2: ");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите переменную №3: ");
            int C = Convert.ToInt32(Console.ReadLine());

            if (A == B)
            {
                Console.WriteLine("Переменная №1 равна переменной №2! Увеличим все переменные на 5:");
                Console.WriteLine("Переменная №1 равна: " + (A + 5));
                Console.WriteLine("Переменная №2 равна: " + (B + 5));
                Console.WriteLine("Переменная №3 равна: " + (C + 5));
            }
            else if (A == C)
            {
                Console.WriteLine("Переменная №1 равна переменной №3! Увеличим все переменные на 5:");
                Console.WriteLine("Переменная №1 равна: " + (A + 5));
                Console.WriteLine("Переменная №2 равна: " + (B + 5));
                Console.WriteLine("Переменная №3 равна: " + (C + 5));
            }
            else if (B == C)
            {
                Console.WriteLine("Переменная №2 равна переменной №3! Увеличим все переменные на 5:");
                Console.WriteLine("Переменная №1 равна: " + (A + 5));
                Console.WriteLine("Переменная №2 равна: " + (B + 5));
                Console.WriteLine("Переменная №3 равна: " + (C + 5));
            }
            else
            {
                Console.WriteLine("равных нет");
            }

        }
    }
}
