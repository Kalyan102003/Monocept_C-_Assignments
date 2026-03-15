using System;
using System.Collections.Generic;
using System.Text;

namespace _11_march_assignments
{
    
public class ProductDetails{
   public int id;
   public  string name;
   public int price;
   public double discountPrice;
   public double FinalPrice;
   
   public ProductDetails[] M = new ProductDetails[2];
   
   public void takeValues(){
       for(int i=0;i<M.Length;i++){
           M[i]  = new ProductDetails();
           Console.WriteLine($"enter product id {i+1}");
            M[i].id = int.Parse(Console.ReadLine());
           Console.WriteLine($"enter product name {i+1}");
              M[i].name = Console.ReadLine();
           Console.WriteLine($"enter product price {i+1}");
           M[i].price = int.Parse(Console.ReadLine());
           M[i].discountPrice = (int)(M[i].price*0.05);
           M[i].FinalPrice = (int)(M[i].price- M[i].discountPrice);
          
       }
   }
   
   public void GetValues(){
       for(int j=0;j<M.Length;j++){
           
Console.WriteLine("Product ID: " + M[j].id + 
                  " | Name: " + M[j].name + 
                  " | Price: " + M[j].price + 
                  " | Discount: " + M[j].discountPrice + 
                  " | Final Price: " + M[j].FinalPrice);
            }
       }
   }
}
