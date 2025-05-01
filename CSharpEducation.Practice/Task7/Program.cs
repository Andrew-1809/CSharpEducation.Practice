using System;
using System.Data.SqlTypes;
using System.Security.Cryptography.X509Certificates;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Объявление переменных:
            double a;                             //катет 1
            double b;                             //катет 2
            double c;                             //гипотенуза

            //Ввод значений для катета 1 и катета 2:
            a = 3;
            b = 4;

            //Формула вычисления гипотенузы
            c = Math.Sqrt((a*a) + (b*b));

            Console.WriteLine(c);
        }
    }
}
