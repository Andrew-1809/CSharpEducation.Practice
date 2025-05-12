using System;

namespace Practice2.Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Напиши что-нибудь: ");                            //7a
            string a = Console.ReadLine();
            string b = a.ToUpper();

            Console.WriteLine(b);                     

        Console.WriteLine();                     //Просто разрыв строки для удобства чтения результата в консоли

            Console.Write("Напиши что-нибудь еще: ");                         //7b
            string c = Console.ReadLine();
            string d = c.ToLower();

            Console.WriteLine(d);

        Console.WriteLine();                     //Просто разрыв строки для удобства чтения результата в консоли

            Console.Write("Напиши что-нибудь еще, ну пожалуйста...: ");                           //7c

            string s = Console.ReadLine();
            char[] string1 = s.ToCharArray();

           
            for (int i = 0; i < string1.Length; i++)
            {
                if (i == 0)
                {
                    string z = Convert.ToString(string1[i]);
                    Console.Write(z.ToUpper());
                }
                else
                {
                    string z = Convert.ToString(string1[i]);
                    Console.Write(z);
                }
            }
                        
        }
    }
}
