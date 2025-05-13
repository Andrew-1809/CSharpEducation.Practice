using System;
using System.Diagnostics.Metrics;

namespace Practice2.Task6_c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = args[0];                         //6c
            char[] string1 = s.ToCharArray();

            char z = Convert.ToChar(args[1]);

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
