using System;

namespace Practice3.Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Книга book = new Книга() { Автор = "Гоголь", Название = "Вий" };
            book.Print();
        }
    }
}
