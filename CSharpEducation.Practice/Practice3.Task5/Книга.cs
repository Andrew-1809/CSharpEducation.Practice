using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task5
{
    internal class Книга
    {
        public string Название;
        public string Автор;
        public int Год_издания;
               
        public Книга() : this("Неизвестно") { }
        public Книга(string name) : this(name, "Пушкин", 101) { }
        public Книга(string name, string author, int year)
        {
            Название = name;
            Автор = author;
            Год_издания = year;
        }
              

        public void Print()
        {
            Console.WriteLine($"Книга '{Название}' автора {Автор} {Год_издания} года издания.");
        }

    }
}
