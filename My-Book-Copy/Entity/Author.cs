using System;
using System.Collections.Generic;
using System.Text;

namespace My_Book_Copy.Entity
{
    class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Book_Author> Book_Authors { get; set; }
        public string fullname => $"{FirstName} {LastName}";
    }
}
