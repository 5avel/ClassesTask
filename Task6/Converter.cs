using System;
using System.Collections.Generic;
using System.Text;

namespace Task6
{
    public class Converter
    {
        
        double usd, eur, rub;

        
        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

     
        public void UanUsd(double uah)
        {
            Console.WriteLine(uah / this.usd);
        }

        
        public void UsdUan(double usd)
        {
            Console.WriteLine(usd * this.usd);
        }

       
        public void UanEur(double uah)
        {
            Console.WriteLine(uah / this.eur);
        }

        
        public void EurUan(double eur)
        {
            Console.WriteLine(eur * this.eur);
        }

        
        public void UanRub(double uah)
        {
            Console.WriteLine(uah / this.rub);
        }

        
        public void RubUan(double rub)
        {
            Console.WriteLine(rub * this.rub);
        }
    }
}
