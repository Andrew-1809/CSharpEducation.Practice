using System;

namespace Practice2.Task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mas = { 1, -1, 9, 7, -4, 5, 0, 2, 15, -12 };

            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);

            }

            int quan = mas.Length;
            int mid = mas.Length / 2;
            int temp;

            for (int i = 0; i < mid; i++)
            {
                temp = mas[i];
                mas[i] = mas[quan - i - 1];
                mas[quan - i - 1] = temp;
            }

            Console.WriteLine();

            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);

            }
        }
    }
}
