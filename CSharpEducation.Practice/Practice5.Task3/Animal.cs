using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task3
{
    class Animal
    {
        public string Name;
        public int Age;
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
        public void Sleep()
        {
            Console.WriteLine("Animal is sleeping");
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic animal sound");
        }

        public Animal() { }
        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public void PrintMessage()
        {
            Console.WriteLine($"Это просто животное по имени {Name} возрастом {Age}");
        }
        
    }
}
