using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task8
{
    struct Прямоугольник
    {
        public double Ширина;
        public double Высота;

        public void Print()
        {
            Console.WriteLine($"Площадь прямоугольника равна {Ширина * Высота} кв. м.");
        }
    }
}
