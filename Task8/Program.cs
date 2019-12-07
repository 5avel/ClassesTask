using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice inv = new Invoice(33333, "Pavlo", "Citrus") { Article = "iMac", Quantity = 1 };

            inv.CostCalculation(true); 
            inv.CostCalculation(false);
        }
    }
}
