using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objects.Utils
{
    internal class TaskAnimal
    {
        string _name;
        string _species;

        public TaskAnimal(string name, string species)
        {
            Name = name;
            Species = species;
        }

        public string Name { get => _name; set => _name = value; }
        public string Species { get => _species; set => _species = value; }


        public void Print()
        {
            Console.WriteLine($"{Name} - {Species}");
        }
    }
}
