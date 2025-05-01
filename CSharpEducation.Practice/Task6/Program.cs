using System;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Объявляем переменные
            const double π = 3.14;                      // переменная π - константа
            double R;                                   // переменная R - радиус круга

            //Ввести значение радиуса R:
            R = 2;

            //Вводим формулу площади круга S:
            double S;
            S = π * (R * R);

            Console.WriteLine(S);
        }
    }
}
