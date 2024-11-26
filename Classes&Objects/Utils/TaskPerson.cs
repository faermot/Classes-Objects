using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objects.Utils
{
    internal class TaskPerson
    {
        string _name;
        int _age;

        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }

        public TaskPerson(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Print()
        {
            Console.WriteLine($"Имя: {Name} | Возраст: {Age}");
        }

    }
}
