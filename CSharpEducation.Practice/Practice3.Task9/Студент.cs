using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task9
{
    class Студент
    {
        public string Name = "Безродный";
        public int Age;
        public void Print()
        {
            Console.WriteLine($"Студента зовут {Name}, его возраст - {Age}");
        }
    }
}
