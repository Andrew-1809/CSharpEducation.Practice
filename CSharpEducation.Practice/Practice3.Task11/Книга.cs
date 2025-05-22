using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task11
{
    class Книга
    {
        public string Название = "Без_названия";
        public string Автор = "Аноним";
        public void Print()
        {
            Console.WriteLine($"Книга с названием {Название} автора {Автор}");
        }
    }
}
