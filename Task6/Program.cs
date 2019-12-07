using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(23.8, 26.37, 0.375);

            converter.UanEur(500);
            converter.UanUsd(500);
            converter.UanRub(500);

            converter.EurUan(100);
            converter.UsdUan(100);
            converter.RubUan(100);

            Console.ReadKey();

        }
    }
}
