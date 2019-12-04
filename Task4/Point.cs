using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    public class Point
    {
        private int x;
        public int X { get => x; }

        private int y;
        public int Y { get => y; }

        private string name;
        public string Name { get => name; }

        public Figure(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
    }
}
