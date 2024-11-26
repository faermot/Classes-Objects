using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objects.Utils
{
    internal class TaskPoint
    {
        int _x;
        int _y;

        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }

        public TaskPoint(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int Sum()
        {
            return Y - X;
        }
        public void Print()
        {
            Console.WriteLine($"x: {X}, y: {Y}, Результат: {Sum()}");
        }
    }
}
