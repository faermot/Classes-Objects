using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objects.Utils
{
    internal class TaskRectangle
    {
        int _width;
        int _height;

        public int Width { get => _width; set => _width = value; }
        public int Height { get => _height; set => _height = value; }

        public TaskRectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void Calculate()
        {
            Console.WriteLine($"Площадь прямоугольника: {Width * Height}");
        }
    }
}
