using System;

namespace Practice2.Task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            int [] numbers = new int[x];
            
            Random R = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = R.Next(-10, +10);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }


        }
    }
}
