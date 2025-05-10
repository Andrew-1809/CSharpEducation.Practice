using System;

namespace Practice2.Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i > 0; i--)  //1a
            {
                Console.Write(i + " ");
            }

        Console.WriteLine(" ");           //Просто разрыв строки для удобства чтения результата в консоли

            int counter = 8;              //1b
            while (counter <= 20)
            {
                counter++;
                Console.Write(counter + " ");
            }

        Console.WriteLine(" ");           //Просто разрыв строки для удобства чтения результата в консоли

            int a = -20;                  //1c
            do
            {
                Console.Write(a + ", ");
                a++;
            }
            while (a <= -1);

        Console.WriteLine(" ");           //Просто разрыв строки для удобства чтения результата в консоли

            Console.WriteLine("Введите фразу из трех слов.");      //1d            
            Console.Write("Введите слово №1: ");
            string word1 = Console.ReadLine();
            Console.Write("Введите слово №2: ");
            string word2 = Console.ReadLine();
            Console.Write("Введите слово №3: ");
            string word3 = Console.ReadLine();
            string[] words = { word1, word2, word3 };

            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i] + " ");                
            }

        Console.WriteLine(" ");           //Просто разрыв строки для удобства чтения результата в консоли

            Console.WriteLine("Введите фразу из трех слов.");      //1e            
            Console.Write("Введите слово №1: ");
            string word11 = Console.ReadLine();
            Console.Write("Введите слово №2: ");
            string word22 = Console.ReadLine();
            Console.Write("Введите слово №3: ");
            string word33 = Console.ReadLine();
            string[] words2 = { word11, word22, word33 };

            int c = 0;
            while (c < words2.Length)
            {                
                Console.Write(words2[c] + " ");
                c++;
            }

        Console.WriteLine(" ");           //Просто разрыв строки для удобства чтения результата в консоли

            Console.WriteLine("Введите фразу из трех слов.");      //1e            
            Console.Write("Введите слово №1: ");
            string word01 = Console.ReadLine();
            Console.Write("Введите слово №2: ");
            string word02 = Console.ReadLine();
            Console.Write("Введите слово №3: ");
            string word03 = Console.ReadLine();
            string[] words3 = { word01, word02, word03 };

            int d = 0;
            do
            {
                Console.Write(words3[d] + " ");
                d++;
            }
            while (d < words3.Length);
        }
    }
}
