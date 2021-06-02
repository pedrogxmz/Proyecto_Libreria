using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    class Book
    {
        public int Id { get; }
        public int Copies { get; }
        public string Title { get; }
        public string Author { get; }
        public int EditorialId { get; }
        public int Edition { get; }
        public int Year { get; }

        public Book(int id, int copies, string title, string author, int editorialId, int edition, int year)
        {
            Id = id;
            Copies = copies;
            Title = title;
            Author = author;
            EditorialId = editorialId;
            Edition = edition;
            Year = year;
        }
    }
}
