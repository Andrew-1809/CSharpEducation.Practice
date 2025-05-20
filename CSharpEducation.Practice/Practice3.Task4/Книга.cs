using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task4
{
    class Книга
    {
        public string Название = "нонейм";
        public string Автор = "ноубади";

        public Книга ()
        {
        }   

        public Книга(string name, string author)
        {
            Название = name;
            Автор = author;

        }
        
        public void Print()
        {
            Console.WriteLine($"Книга '{Название}' автора {Автор}");
        }

    }
}
