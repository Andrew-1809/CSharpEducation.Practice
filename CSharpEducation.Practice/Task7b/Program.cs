using System;

namespace Task7b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Объявление переменных:
            double a;                             //катет 1
            double b;                             //катет 2
            double c;                             //гипотенуза

            //Ввод значений для катета 1 и катета 2:
            a = 3;
            c = 5;

            //Формула вычисления катета
            b = Math.Sqrt((c*c)-(a*a));

            Console.WriteLine(b);
        }
    }
}
