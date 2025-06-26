using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task1
{
    class Contractor : Employee
    {
        public int HourlyRate;
        public Contractor() { }

        public Contractor(string Name, double Salary, int HourlyRate) : base(Name, Salary)
        {
            this.Name = Name;
            this.Salary = Salary;
            this.HourlyRate = HourlyRate;
        }
        public new void CalculateBonus()
        {
            if (HourlyRate > 20)
            {
                Console.WriteLine($"Возврат сотруднику {Name} бонуса в размере {Salary * 0.5} рублей!");
            }
            else
            {
                Console.WriteLine($"Cотрудник {Name} лодырь, оставить его без бонуса!");
            }
        }               

    }
}
