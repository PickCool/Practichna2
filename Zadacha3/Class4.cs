using System;
using System.Collections.Generic;
using System.Text;

namespace Author1
{
    public class Author
    {
        private string author;

        public Author(string author)
        {
            this.author = author;
        }

        public void Show()
        {
            Console.WriteLine($"Author: {author}");
        }
    }
}
