using System;
namespace Practice2.Task16
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            void Increment(ref int a)
            {
                int b = Convert.ToInt32(Console.ReadLine());
                a = -b;
                Console.WriteLine($"Теперь число 'b' равно: {b}");
            }
        }   
    }
}
