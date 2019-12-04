using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    public class Rectangle
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }

        public Rectangle(double side1, double side2)
        {
            this.Side1 = side1;
            this.Side2 = side2;
        }

        public double Area { 
            get => 
                this.AreaCalculator(); 
        }

        public double Perimeter { 
            get => 
                this.PerimeterCalculator();
        }


        private double PerimeterCalculator() =>
            (Side1 + Side2) * 2;

        private double AreaCalculator() =>
            Side1 * Side2;


    }
}
