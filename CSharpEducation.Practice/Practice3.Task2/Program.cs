using System;

namespace Practice3.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Студент Андрей = new Студент();
            Андрей.name = "Андрей";
            Андрей.age = 33;
            Андрей.Средний_балл = 8;

            Андрей.Print();
            
        }
    }
}
