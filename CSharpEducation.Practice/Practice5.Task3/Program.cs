using System;

namespace Practice5.Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal животное = new Animal() { Name = "Слон", Age = 100 };
            Cat кошка = new Cat() { Name = "Барсик", Age = 5};
            Dog собака = new Dog() { Name = "Шарик", Age = 8 };
            Parrot попугай = new Parrot();
            Eagle арёль = new Eagle();

            животное.MakeSound();
            кошка.MakeSound();
            собака.MakeSound();
            попугай.MakeSound();
                        
            Console.Write("Скажи чё-нить попугаю:");

            попугай.message = Console.ReadLine();
            попугай.MakeSound2();

            животное.PrintMessage();
            кошка.PrintMessage();
            собака.PrintMessage();
            попугай.PrintMessage();

            попугай.GetMessage();
            арёль.GetMessage();

            IFlyable[] flyables = new IFlyable[20];

            for (int i = 0; i < flyables.Length; i++)
                {
                if (i % 2 == 0)
                    flyables[i] = new Parrot();
                else
                    flyables[i] = new Eagle();
                }
            for (int i = 0; i < flyables.Length; i++)
            {
                flyables[i].GetMessage();
            }

        }
    }
}
