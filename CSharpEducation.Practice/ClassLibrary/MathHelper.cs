namespace ClassLibrary
{
    public class MathHelper
    {
        public double A;
        public double B;
        double C;
        public void PrintPlus()
        {
            double C = A + B;
            Console.WriteLine($"Сумма чисел 'A' и 'B' равна {C}");
        }
        public void PrintMinus() 
        {
            double C = A - B;
            Console.WriteLine($"Разница чисел 'A' и 'B' равна {C}");
        }
        public void PrintMult()
        {
            double C = A * B;
            Console.WriteLine($"Произведение чисел 'A' и 'B' равно {C}");
        }
        public void PrintDiv()
        {
            double C = A / B;
            Console.WriteLine($"Частное чисел 'A' и 'B' равно {C}");
        }
    }
}
