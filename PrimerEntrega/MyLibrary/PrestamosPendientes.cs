using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    class PrestamosPendientes
    {
        public  User User { get; }
        public Book Book { get; }

        public PrestamosPendientes(User usuario, Book book)
        {
            User = usuario;
            Book = book;
        }
    }

}
