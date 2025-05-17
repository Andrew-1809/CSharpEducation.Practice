using System;
using System.Diagnostics;

namespace Practice2.Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int z = 5;
            string[] words;

            words = new string[z];
            Console.WriteLine("Введите по порядку слова.");

            

            for (int i = 0; i < z; i++)
            {
                Console.WriteLine("Введите слово №" + (i + 1) + " . Для завершения введите 'стоп'.");
                words[i] = Console.ReadLine();
                
            }

        Console.WriteLine();

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
