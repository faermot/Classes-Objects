using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objects.Utils
{
    internal class TaskBook
    {
        string _title;
        string _author;
        int _pages;

        public string Title { get => _title; set => _title = value; }
        public string Author { get => _author; set => _author = value; }
        public int Pages { get => _pages; set => _pages = value; }

        public TaskBook(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
        }

        public void Print()
        {
            Console.WriteLine($"Книга '{Title}', Автор - {Author}, Страниц - {Pages}");
        }


    }
}
