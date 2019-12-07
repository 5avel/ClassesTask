using System;
using System.Collections.Generic;
using System.Text;

namespace Task7
{
    public class Employee
    {

        private readonly string name;
        public string Name => name;

        private readonly string lastname;
        public string LastName => lastname;


       private readonly double fee = 0.195;

        private string position;
        public string Position
        {
            get
            {
                if (position == null)
                    throw new NullReferenceException();

                return position;
            }
            set
            {
                if (value != null && value != position)
                {
                    position = value;
                }
            }
        }

        private int experience;
        public int Experience
        {
            get
            {
                return experience;
            }
            set
            {
                if (value >= 0)
                {
                    experience = value;
                }
            }
        }

        public Employee(string surname, string name)
        {
            this.lastname = surname;
            this.name = name;
        }

        public double CalcSalary()
        {
            double dirtySalary;

            switch (position)
            {
                case "DEVOps":
                    dirtySalary = 1500;
                    break;
                case "QA":
                    dirtySalary = 400;
                    break;
                case "Dev":
                    dirtySalary = 1900;
                    break;
                case "Manager":
                    dirtySalary = 1500;
                    break;
                default:
                    dirtySalary = 1;
                    break;
            }

            switch (experience)
            {
                case 0:
                    dirtySalary *= 1;
                    break;
                case 1:
                    dirtySalary *= 1.25;
                    break;
                case 2:
                    dirtySalary *= 1.4;
                    break;
                case 3:
                    dirtySalary *= 1.6;
                    break;
                case 4:
                    dirtySalary *= 1.8;
                    break;
                default:
                    dirtySalary *= 2;
                    break;
            }
            return dirtySalary;
        }

        public void ShowSalary()
        {
            Console.WriteLine($"Зарплата {CalcSalary()}, налог {CalcSalary() * fee}");
        }
    }
}
