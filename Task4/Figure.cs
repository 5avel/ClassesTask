using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    public class Figure
    {
        private readonly Point[] points;

        public Figure(Point point1, Point point2, Point point3)
        {
            this.points = new Point[] {point1, point2, point3 };
        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            this.points = new Point[] { point1, point2, point3, point4 };
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            this.points = new Point[] { point1, point2, point3, point4, point5 };
        }

        private double LengthSide(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }
    }
}
