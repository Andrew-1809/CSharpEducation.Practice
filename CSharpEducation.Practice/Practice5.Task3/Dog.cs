using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task3
{
    class Dog: Animal
    {
        string message = "Это Пёсель!";
        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
        public Dog() { }
        public Dog(string name, int age, string message) : base(name, age)
        {
            message = "Это Собака!";
        }

        public new void PrintMessage()
        {
            Console.WriteLine($"{message} Его зовут {Name}, а его возраст {Age} лет!");
        }

    }
}
