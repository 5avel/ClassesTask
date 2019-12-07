using System;

namespace Task4
{
    class Program
    {
            /*Задание 4
                Требуется:
                Создать классы Point и Figure.
                Класс Point должен содержать два целочисленных поля и одно строковое поле.
                Создать три свойства с одним методом доступа get.
                Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями аргументов.

                Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point.
                Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину стороны
                многоугольника; void PerimeterCalculator(), который рассчитывает периметр многоугольника.
                Написать программу, которая выводит на экран название и периметр многоугольника.
         
             
             */
        static void Main(string[] args)
        {
            new Figure(
                new Point(1, 1, "A"), 
                new Point(1, 3, "B"), 
                new Point(3, 1, "C")
                ).PerimeterCalculator();

            new Figure(
                new Point(1, 1, "A"),
                new Point(1, 3, "B"),
                new Point(3, 3, "C"),
                new Point(3, 1, "D")
                ).PerimeterCalculator();

            new Figure(
                new Point(1, 1, "A"),
                new Point(1, 3, "B"),
                new Point(3, 3, "C"),
                new Point(3, 1, "D"),
                new Point(0, 2, "E")
                ).PerimeterCalculator();
        }
    }
}
