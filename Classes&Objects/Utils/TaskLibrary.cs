using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objects
{
    internal class TaskLibrary
    {
        List<string> _library = new List<string>(10);

        public List<string> Library { get => _library; set => _library = value; }

        public TaskLibrary()
        {
        }

        public TaskLibrary(List<string> library)
        {
            Library = library;
        }

        public void Print()
        {
            foreach (var book in Library) Console.WriteLine(book);
        }
        public void Add(string book)
        {
            Library.Add(book);
        }
    }
}
