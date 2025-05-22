using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3.Task6
{
    struct Точка
    {
        public int X1;
        public int Y1;
        public int X2;
        public int Y2;
        

        
        public Точка(int X1, int Y1, int X2, int Y2)
        {
            this.X1 = X1;
            this.Y1 = Y1;
            this.X2 = X2;
            this.Y2 = Y2;
        }

        //private int Z = Math.Sqrt((X2 - X1)*(X2 - X1)+(Y2 - Y1)*(Y2 - Y1));
        public void Print()
        {
            Console.WriteLine($"Расстояние между точками равно {Math.Sqrt((X2 - X1) * (X2 - X1) + (Y2 - Y1) * (Y2 - Y1))}");
        }

    }
}
