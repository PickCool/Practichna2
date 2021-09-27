using System;

namespace Title1
{
    public class Title
    {
        private string title;

        public Title(string title)
        {
            this.title = title;
        }

        public void Show()
        {
            Console.WriteLine($"Title: {title}");
        }
    }
}