using System;
using ClassLibrary;

namespace Practice4.Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MathHelper math = new MathHelper() { A = 8, B = 4};
            math.PrintPlus();
            math.PrintMinus();
            math.PrintMult();
            math.PrintDiv();
        }
    }
}
