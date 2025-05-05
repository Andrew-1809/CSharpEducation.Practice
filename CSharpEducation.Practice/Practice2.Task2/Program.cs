using System;

namespace Practice2.Task2
{
    internal class Program
    {       
        static void Main(string[] args)
        {
            Console.Write("Введите расстояние в метрах: ");                              //2a
            double m = Convert.ToDouble(Console.ReadLine());
            Console.Write("Расстояние в километрах равно: " + (m/1000));

        Console.WriteLine();                                                             //Разрыв для красоты и удобства чтения

            Console.Write("Введите расстояние в километрах: ");                          //2b
            double km = Convert.ToDouble(Console.ReadLine());
            Console.Write("Расстояние в сантиметрах равно: " + (km * 100000));

        Console.WriteLine();                                                             //Разрыв для красоты и удобства чтения

            Console.Write("Введите скорость в метрах в секунду: ");                      //2c
            double v = Convert.ToDouble(Console.ReadLine());
            Console.Write("Скорость в километрах в час равна: " + (v * 3600 / 1000));

        Console.WriteLine();                                                             //Разрыв для красоты и удобства чтения

            Console.Write("Введите температуру в градусах Цельсия: ");                   //2d
            double t = Convert.ToDouble(Console.ReadLine());
            t = t * 1.8 + 32;
            Console.Write("Температура в градусах Фаренгейта равна : " + t);

        }
    }
}
