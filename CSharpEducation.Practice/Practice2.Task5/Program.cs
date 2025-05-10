using System;

namespace Practice2.Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2 целых числа для сравнения.");

            Console.Write("Введите число А: ");
            int A = Convert.ToInt32(Console.ReadLine());
                        
            Console.Write("Введите число B: ");
            int B = Convert.ToInt32(Console.ReadLine());

            double q = Convert.ToDouble(A) / Convert.ToDouble(B);
            double w = Convert.ToDouble(B) / Convert.ToDouble(A);

            Console.WriteLine("Число A больше числа B в " + Math.Round (q,2) + " раз.");
            Console.WriteLine("Число B больше числа A в " + Math.Round (w,2) + " раз.");

        }
    }
}
