using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task3
{
    class Parrot : Animal, IFlyable
    {
        public string Color;
        public new void MakeSound()
        {
            Console.WriteLine("Parrot is talking");
        }

        public string message;
        public void MakeSound2()
        {
            Console.WriteLine($"Попугай в ответ: {message} !!!");
        }

        public void GetMessage()
        {
            Console.WriteLine("Parrot is flying");
        }
    }
}
