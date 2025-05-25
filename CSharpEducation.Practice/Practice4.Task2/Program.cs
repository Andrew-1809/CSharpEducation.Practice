using System;
using ClassLibrary_Person;

namespace Practice4.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person Person_1 = new Person() { age = 21, name = "Ivan"};
            Person_1.Print();

            Person Person_2 = new Person();
            Person_2.Print();

            Person Person_3 = new Person() { age = 98, name = "Anatoly"};
            Person_3.Print();
        }
    }
}
