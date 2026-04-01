namespace MulticastDegligate_and_Func
{
    internal class Program
    {
        public delegate string Notify(string Message);
        static void Main(string[] args)
        {

            //Func<double, double> calculateDiscount;
            //Func<double, double, double> calculateFinalPrice;
            //FuncDiscount f = new FuncDiscount();
            //calculateDiscount = f.Discount;
            //calculateFinalPrice = f.FinalPrice;
            //double dis = calculateDiscount(2000);
            //double result = calculateFinalPrice(f.discount,f.Price);
            //Console.WriteLine("your Discount "+ dis);
            //Console.WriteLine("your Final Price "+result);

            //------------------------------------------------------------
            MessageDelegate MD = new MessageDelegate();
            Notify notify;
            notify = MD.SendEmail;  
            notify += MD.SendSMS;    
            notify += MD.Whatsapp;   
            notify("Hello Kalyan");
        }
    }
}
