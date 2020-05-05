using System;

namespace VendingMachine
{
    public class Options
    {
        public static void DisplayOptions() 
        {
            Console.WriteLine("");
            Console.WriteLine("Choose one of the following options:"); 
            Console.WriteLine("1. Buy item");
            Console.WriteLine("2. Look at my card statement");
            Console.WriteLine("3. Withdraw money from the bank");
        }
    }
    
}