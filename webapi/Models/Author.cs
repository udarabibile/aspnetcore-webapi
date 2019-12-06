using System;
using System.Collections.Generic;

namespace webapi.Models
{
    public class Author : BaseEntity
    {
        public String Name { get; set; }
        public String Country { get; set; }
        public virtual ICollection<Book> Books { get; set; }

        public Author() { }
        public Author(String name, String country, ICollection<Book> books)
        {
            Name = name;
            Country = country;
            Books = books;
        }
    }
}