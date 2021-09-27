using System;
using System.Collections.Generic;
using System.Text;

namespace Containing1
{
    public class Containing
    {
        private string containing;

        public Containing(string content)
        {
            this.containing = content;
        }

        public void Show()
        {
            Console.WriteLine($"Containing: {containing}");
        }
    }
}

