using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address
            {
                Index = "123456",
                Country = "USA",
                City = "NewYork",
                Street = "raspberry",
                House = 32,
                Apartment = 13
            };
            Console.WriteLine($"{address.Index}/" +
                              $"{address.Country}/" +
                              $"{address.City}/" +
                              $"{address.Street}/" +
                              $"{address.House}/" +
                              $"{address.Apartment}");

            Console.ReadKey();
        }
    }
}
