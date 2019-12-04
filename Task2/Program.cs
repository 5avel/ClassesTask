using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double side1;
            double side2;
           
            string numberDecimalSeparator = System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;
            string errorString = $"Formar error. Please try again.  simple: 1{numberDecimalSeparator}2 ";

            Console.WriteLine("Enter Side1:");
            while (false == Double.TryParse(Console.ReadLine(), out side1))
                Console.WriteLine(errorString);

            Console.WriteLine("Enter Side2:");
            while (false == Double.TryParse(Console.ReadLine(), out side2))
                Console.WriteLine(errorString);

            Rectangle rectangle = new Rectangle(side1: side1, side2: side2);
            Console.WriteLine($"Perimeter:{rectangle.Perimeter}\nArea:{rectangle.Area}");

            Console.ReadKey();


        }
    }
}
