using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objects.Utils
{
    internal class TaskMovie
    {
        string _title;
        int _directory;
        string _releaseYear;


        public string Title { get => _title; set => _title = value; }
        public int Directory { get => _directory; set => _directory = value; }
        public string ReleaseYear { get => _releaseYear; set => _releaseYear = value; }


        public TaskMovie(string title, int directory, string releaseYear)
        {
            Title = title;
            Directory = directory;
            ReleaseYear = releaseYear;
        }

        public void Print()
        {
            Console.WriteLine($"Название: {Title}, Директория: {Directory}, Год выпуска: {ReleaseYear}.");
        }
    }
}
