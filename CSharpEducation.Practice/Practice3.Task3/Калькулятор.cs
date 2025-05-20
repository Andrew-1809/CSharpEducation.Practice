using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practice3.Task3
{
    class Калькулятор
    {
        public int Число_1 = 2;
        public int Число_2 = 6;

        private int Ответ;

        public void Деление()
        {
            Ответ = Число_1 / Число_2;
            Console.WriteLine($"{Число_1} разделить на {Число_2} равно {Ответ}");
        }

        public void Умножение()
        {
            Ответ = Число_1 * Число_2;
            Console.WriteLine($"{Число_1} умножить на {Число_2} равно {Ответ}");
        }

        public void Сумма()
        {
            Ответ = Число_1 + Число_2;
            Console.WriteLine($"{Число_1} плюс {Число_2} равно {Ответ}");
        }

        public void Разница()
        {
            Ответ = Число_1 - Число_2;
            Console.WriteLine($"{Число_1} минус {Число_2} равно {Ответ}");
        }
    }
}
