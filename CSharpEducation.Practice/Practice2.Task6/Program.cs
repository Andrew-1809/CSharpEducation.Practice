using System;

namespace Practice2.Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "А роза упала на лапу Азора";                         //6a
            char[] string1 = s.ToCharArray();
                       
            char z = 'а';

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

        Console.WriteLine(" ");           //Просто разрыв строки для удобства чтения результата в консоли

            Console.Write("Введите любую фразу: ");                           //6b
                       
            string ss = Console.ReadLine();
            char[] string2 = ss.ToCharArray();

            Console.Write("Введите необходимый символ: ");
            char zz = Convert.ToChar(Console.ReadLine());

            int count11 = 0;
            int count22 = string1.Length;

            for (int i = 0; i < string2.Length; i++)
            {
                if (zz == string2[i])
                {
                    count11++;
                }

            }

            Console.WriteLine("Число символов " + "'" + zz + "'" + " в строке - " + count11 * 100 / count22 + "%");
                                           
        }
    }
}
