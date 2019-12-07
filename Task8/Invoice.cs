using System;
using System.Collections.Generic;
using System.Text;

namespace Task8
{
    public class Invoice
    {
        public readonly int account = 0;
        public readonly int taxe = 20;
        public readonly string customer = null;
        public readonly string provider = null;

        public string Article { get; set; } 

        public int Quantity { get; set; } 

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        public void CostCalculation(bool withoutTaxe)
        {
            double cost;
            switch (Article)
            {
                case "iMac":
                    cost = 35000;
                    break;
                case "Lenovo g560":
                    cost = 8500;
                    break;
                case "MicroUSB":
                    cost = 95;
                    break;
                default:
                    Console.WriteLine("ТОвар не найден(");
                    return;
            }
            if (withoutTaxe) 
            {
                cost *= 0.8;
            }
            Console.WriteLine($"Цена {(withoutTaxe ? "без НДС" : "с НДС")}: {cost * Quantity}");
        }
    }
}
