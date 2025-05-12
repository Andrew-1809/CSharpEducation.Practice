using System;

namespace Practice2.Task6_c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args.Length);
            Console.Write("Введите любую фразу: ");                           //6c

            string s = Console.ReadLine();
            char[] string1 = s.ToCharArray();

            Console.Write("Введите необходимый символ: ");
            char z = Convert.ToChar(Console.ReadLine());

            int count1 = 0;
            int count2 = string1.Length;

            for (int i = 0; i < string1.Length; i++)
            {
                if (z == string1[i])
                {
                    count1++;
                }

            }

            Console.WriteLine("Число символов " + "'" + z + "'" + " в строке - " + count1 * 100 / count2 + "%");
        }
    }
}
