using System;

namespace Practice2.Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество чисел, которое Вы хотите ввести: ");
            int z = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[z];

            Console.WriteLine("Введите по порядку целые числа.");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Введите число №" + (i + 1) + " : ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);                
            }

        }
    }
}
