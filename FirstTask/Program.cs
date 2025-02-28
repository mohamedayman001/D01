namespace FirstTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceSmall = 25.0;
            double priceLarge = 35.0;
            double tax_Rate = 0.06;
            Console.WriteLine("Islam's Carpet Cleaning Service\r\n    Charges:\r\n   " +
         "     $25 per small \r\n        $35 per large \r\n    Sales tax rate is 6%\r\n    Estimates are valid for 30 days\r\n");
            Console.WriteLine("Number of small carpets : ");
            int smallNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number of large carpets : ");            
            int largeNum = Convert.ToInt32(Console.ReadLine());
            double coast = Convert.ToDouble(smallNum * priceSmall) + (largeNum * priceLarge);        
            double tax =  tax_Rate * coast;
            double total = coast + tax;
            Console.WriteLine("Price per small carpet: $25");
            Console.WriteLine("Price per small carpet: $35");
            Console.WriteLine("Cost : $"+coast);
            Console.WriteLine("Tax : $"+tax);
            Console.WriteLine("===============================");
            Console.WriteLine("Total estimate : $" + total);
            Console.WriteLine("This estimate is valid for 30 days");



        }
    }
}
