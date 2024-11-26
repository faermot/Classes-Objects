using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objects.Utils
{
    internal class TaskCircle
    {
        int _radius;

        public int Radius { get => _radius; set => _radius = value; }

        public TaskCircle(int radiusl)
        {
            Radius = radiusl;
        }

        public void Calculate()
        {
            Console.WriteLine($"Площадь круга: {Math.PI * Math.Pow(Radius, 2)}");
        }
    }
}
