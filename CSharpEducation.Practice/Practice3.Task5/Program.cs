using System;

namespace Practice3.Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Книга Book_1 = new Книга();
            Book_1.Print();

            Книга Book_2 = new Книга() { Название = "Капитанская Дочка", Автор = "Пушкин", Год_издания = 1993 };
            Book_2.Print();

            Книга Book_3 = new Книга() { Название = "Капитанская Дочка", Автор = "Пушкин" };
            Book_3.Print();

        }
    }
}
