using System;
using System.Linq.Expressions;

namespace Practice5.Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee man_1 = new Manager() { Name = "Andrew", Salary = 50000};
            Manager man_2 = (Manager)man_1;
            
            man_1.CalculateBonus();
            man_2.CalculateBonus();
                        

            Contractor man_333 = new Contractor() { Name = "Tom", Salary = 45000, HourlyRate = 15 };

            Employee man_44 = new Employee() { Name = "Bob", Salary = 90000 };

            Manager man_544 = new Manager() { Name = "Nick", Salary = 110000, Teamsize = 30 };

            Contractor man_621 = new Contractor() { Name = "Isaak", Salary = 130000, HourlyRate = 50 };

            man_333.CalculateBonus();
            man_44.CalculateBonus();
            man_544.CalculateBonus();
            man_621.CalculateBonus();

            

            


        }
    }
}
