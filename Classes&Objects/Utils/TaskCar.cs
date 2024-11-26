using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objects.Utils
{
    internal class TaskCar
    {
        string _make;
        string _model;
        int _year;


        public string Make { get => _make; set => _make = value; }
        public string Model { get => _model; set => _model = value; }
        public int Year { get => _year; set => _year = value; }


        public TaskCar(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public void Print()
        {
            Console.WriteLine($"{Make} {Model} | {Year}");
        }

    }
}
