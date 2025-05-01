using System;

namespace Practice2.Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i > 0; i--)  //Цикл for
            {
                Console.Write(i + " ");
            }

        Console.WriteLine(" ");           //Просто разрыв строки для удобства чтения результата в консоли

            int counter = 8;              //Цикл while
            while (counter <= 20)
            {
                counter++;
                Console.Write(counter + " ");
            }

        Console.WriteLine(" ");           //Просто разрыв строки для удобства чтения результата в консоли

            int a = -20;                  //Цикл do while
            do
            {
                Console.Write(a + ", ");
                a ++;
            }
            while (a <= -1);

        Console.WriteLine(" ");           //Просто разрыв строки для удобства чтения результата в консоли


        }
    }
}
