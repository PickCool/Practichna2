using System;
using System.Collections.Generic;
using System.Text;
using Title1;
using Author1;
using Containing1;

namespace Book1
{
 
        public class Book
        {
            private Title title = null;
            private Author author = null;
            private Containing content = null;

            public void AddTitle(string title)
            {
                this.title = new Title(title);
            }

            public void AddAuthor(string author)
            {
                this.author = new Author(author);
            }

            public void AddContent(string content)
            {
                this.content = new Containing(content);
            }

            public void Show()
            {
                Console.WriteLine("Book:");

                ConsoleColor initialColor = Console.ForegroundColor;

                Console.ForegroundColor = ConsoleColor.Blue;
                title?.Show();

                Console.ForegroundColor = ConsoleColor.Yellow;
                author?.Show();

                Console.ForegroundColor = ConsoleColor.Red;
                content?.Show();

                Console.ForegroundColor = initialColor;
            }
        }
    


}
