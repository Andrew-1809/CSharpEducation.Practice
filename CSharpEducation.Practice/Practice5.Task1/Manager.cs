using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Practice5.Task1
{
    public class Manager : Employee
    {
        public int Teamsize;
        
        public Manager() { }
        public Manager(string Name, double Salary, int Teamsize) : base(Name, Salary)
        {
            this.Name = Name;
            this.Salary = Salary;
            this.Teamsize = Teamsize;
        }
        public void CalculateBonus()
        {
            if (Teamsize > 5)
            {
                Console.WriteLine($"Возврат сотруднику {Name} !!!дополнительного бонуса!!! в размере {Salary * 0.1 + Salary * 0.05} рублей!");
            }
            else
            {
                Console.WriteLine($"Возврат сотруднику {Name} бонуса 10% в размере {Salary * 0.1} рублей!");
            }
        }
    }
}
