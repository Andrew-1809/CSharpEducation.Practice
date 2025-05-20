using System;

namespace Practice3.Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Книга book_1 = new Книга
            {
                Автор = "Пушкин",
                Название = "Капитанская Дочка"
            };
            book_1.Print();

            Книга book_2 = new Книга();       
            book_2.Print();
        }
    }
}
