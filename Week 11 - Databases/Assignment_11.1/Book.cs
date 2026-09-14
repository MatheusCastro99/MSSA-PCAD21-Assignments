using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Assignment_11._1
{
    internal class Book
    {
        [Key]
        public int ISBN { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public string ShortDescription { get; set; }

        public override string ToString()
        {
            string body = $"Book Name - {Name}\nAuthor Name - {AuthorName}\nISBN - {ISBN}\nDescription:\n\t{ShortDescription}\n";
            return body;
        }
    }
}
