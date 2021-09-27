using System;
using System.Collections.Generic;
using System.Text;

namespace Dot1
{
    public class Dot
    {
        private int x;
        public int X
        {
            get { return x; }
        }

        private int y;
        public int Y
        {
            get { return y; }
        }

        private string one;
        public string One
        {
            get { return one; }
        }

        public Dot(int x, int y, string str)
        {
            this.x = x;
            this.y = y;
            this.one = str;
        }
    }
}
