using System;

namespace Practice2.Task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(args[0]);                //Console.ReadLine()
            int y = Convert.ToInt32(args[1]);                //(args[0])

            int[,] numbers = new int[x, y];
            Random rand = new Random();
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                    numbers[i, j] = rand.Next(0, 20);

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write($"{numbers[i, j]} \t");
                }
                Console.WriteLine();
            }


        }
    }
}
