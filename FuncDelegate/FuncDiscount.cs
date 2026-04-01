using System;
using System.Collections.Generic;
using System.Text;

namespace MulticastDegligate_and_Func
{
    public class FuncDiscount
    {
       
        public double Price;
        public double discount;
        public double finalPrice;
        public  double Discount(double Price)
        {
            this.Price = Price;
            Console.WriteLine("Price "+Price);
            if (this.Price > 1000)
            {
                discount = this.Price * 0.15;
               
            }
            else
            {
                discount = this.Price * 0.05;
            }

            return discount;
        }

        public double FinalPrice(double Discount,double Price)
        {
            finalPrice = this.Price - Discount;
            return finalPrice;
        }
    }
}
