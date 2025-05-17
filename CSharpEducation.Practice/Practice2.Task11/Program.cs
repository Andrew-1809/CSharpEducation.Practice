using System;

namespace Practice2.Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int z = Convert.ToInt32(args[0]);

            int[] numbers = new int[z];

            Console.WriteLine("Введите по порядку целые числа.");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(args[1]);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
