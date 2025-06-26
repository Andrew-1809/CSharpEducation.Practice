using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5.Task1
{
    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public Employee()
        {
        }

        public void CalculateBonus()
        {
            Console.WriteLine($"Возврат сотруднику {Name} бонуса {Salary * 0.1} рублей!");
        }
    }
}
