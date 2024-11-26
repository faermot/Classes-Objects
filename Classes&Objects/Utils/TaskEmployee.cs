using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objects.Utils
{
    internal class TaskEmployee
    {
        string _name;
        string _position;
        int _salary;

        public string Name { get => _name; set => _name = value; }
        public string Position { get => _position; set => _position = value; }
        public int Salary { get => _salary; set => _salary = value; }

        public TaskEmployee(string name, string position, int salary)
        {
            Name = name;
            Position = position;
            Salary = salary;
        }

        public void Print()
        {
            Console.WriteLine($"{Name} - '{Position}' | Зарплата - {Salary} р.");
        }


        public void UpgradeSalary(double percent)
        {
            double result = Salary * (percent / 100);
            Salary += Convert.ToInt32(result);
        }
    }
}
