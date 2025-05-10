using System;

namespace Practice2.Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычислим значение выражения (а + b — f / а) + f * a * a — (a + b)");

            Console.Write("Введите значение переменной a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение переменной b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение переменной f: ");
            double f = Convert.ToDouble(Console.ReadLine());

            //Исключим деление на ноль

            if (a == 0)
            {
                Console.WriteLine("На ноль делить нельзя! Введите значение переменной а, отоличное от нуля.");
            }
            else
            {
                double z = (a + b - f / a) + f * a * a - (a + b);
                Console.Write("Значение выражения равно: " + z);
            }
        }
    }
}
