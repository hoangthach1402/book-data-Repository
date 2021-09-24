using System;
using System.Collections.Generic;
using System.Text;

namespace My_Book_Copy.Entity
{
    class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
