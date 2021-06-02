using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    class Borrow
    {
        public int UserId { get; }
        public int BookId { get; }

        public Borrow(int userId, int bookId)
        {
            UserId = userId;
            BookId = bookId;
        }
    }
}
