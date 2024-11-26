using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objects.Utils
{
    internal class TaskStudent
    {
        string _name;
        string _grade;
        int _id;

        public string Name { get => _name; set => _name = value; }
        public string Grade { get => _grade; set => _grade = value; }
        public int Id { get => _id; set => _id = value; }

        public TaskStudent(string name, string grade, int id)
        {
            Name = name;
            Grade = grade;
            Id = id;
        }

        public void Print()
        {
            Console.WriteLine($"{Name} - '{Grade}' | {Id}");
        }

    }
}
