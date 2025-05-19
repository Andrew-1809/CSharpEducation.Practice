using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practice3.Task2
{
    class Студент
    {
        public string name = "Andrew";
        public int age = 31;

        int ср_балл;
        string error = "Средний балл должен быть от 0 до 5";
        public int Средний_балл
        {            
            set
            {
                if (value > 5 || value < 0)
                    ср_балл = 000;

                else
                    ср_балл = value;
            }
            get
            {
                return ср_балл;
            }
        }
        public void Print()
        {
            if (Средний_балл == 000)
                Console.WriteLine($"Имя: {name}  Возраст: {age} Средний балл должен быть в диапазоне от '0' до '5'!");
            else
                Console.WriteLine($"Имя: {name}  Возраст: {age} Средний балл: {Средний_балл}");
        }
    }
}
