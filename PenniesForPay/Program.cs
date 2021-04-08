using System;

namespace PenniesForPay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int numberPennies = 1; 
            int days = 1;

            
            while (userInput>=days) 
            {
                
                userInput = userInput * 2;
                
                
                Console.WriteLine("ammount of pennies earned for day "+days+": "+numberPennies);
                days++;

            }
        }
    }
}
