using System;
using System.Linq;

namespace Practice2.Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Задайте высоту треугольника: ");                                     //1a
            int h1 = Convert.ToInt32(Console.ReadLine());

           
            for (int i = 1; i <= h1; i++)
            {
                string result = string.Concat(Enumerable.Repeat("*", i));
                Console.WriteLine(result);
            }

        Console.WriteLine(" ");           //Просто разрыв строки для удобства чтения результата в консоли

            Console.Write("Задайте высоту треугольника: ");                                     //1b
            int h2 = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= h2; i++)
            {
                string result = string.Concat(Enumerable.Repeat(" ", h2 - i));
                Console.Write(result);

                string result2 = string.Concat(Enumerable.Repeat("*", i));
                Console.WriteLine(result2);
            }

        Console.WriteLine(" ");           //Просто разрыв строки для удобства чтения результата в консоли

            Console.Write("Задайте высоту треугольника: ");                                     //1c
            int h3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите символ, из которого сформируется треугольник: ");
            string s = Console.ReadLine();

            for (int i = 1; i <= h3; i++)
            {
                string result = string.Concat(Enumerable.Repeat(s, i));
                Console.WriteLine(result);
            }

        Console.WriteLine(" ");           //Просто разрыв строки для удобства чтения результата в консоли

            Console.Write("Задайте высоту треугольника: ");                                     //1b
            int h4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите символ, из которого сформируется треугольник: ");
            string s2 = Console.ReadLine();

            for (int i = 1; i <= h4; i++)
            {
                string result = string.Concat(Enumerable.Repeat(" ", h4 - i));
                Console.Write(result);

                string result2 = string.Concat(Enumerable.Repeat(s2, i));
                Console.WriteLine(result2);
            }

        }
    }
}
