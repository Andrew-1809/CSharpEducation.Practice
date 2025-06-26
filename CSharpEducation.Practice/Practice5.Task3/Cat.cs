using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task3
{
    class Cat: Animal
    {
        string message = "Это Кот!";
        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
        public Cat() { }
        public Cat(string name, int age, string message): base(name, age)
        {
            message = "Это Кошка!";
        }

        public new void PrintMessage()
        {
            Console.WriteLine($"{message} его зовут {Name} и ему {Age} лет!");
        }
    }
}
