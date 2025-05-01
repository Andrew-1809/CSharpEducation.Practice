using System;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите Ваше имя: ");

            string userinput = Console.ReadLine();

            if (userinput == "Андрей")
                Console.WriteLine("Привет, Андрей!");
            else
                Console.WriteLine("Да пошел ты...");
        }
    }
}
