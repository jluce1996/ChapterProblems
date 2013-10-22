using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_7_pg._195
{
    class Program
    {
        static void Main(string[] args)
        {
            string carprice; 
            double price; 
            double commissions = 0;
            Console.Write("What is the price of the car?:");
            carprice = Console.ReadLine();
            price = Convert.ToDouble(carprice);
             

            if(price < 15000)
            {
                commissions = price * .05;
                Console.WriteLine("Your commissions are" + commissions.ToString("C"));
            }
            if (price > 15000 && price <= 24000)
            {
                commissions = price * .07;
                Console.WriteLine("Your commissions are" + commissions.ToString("C"));
            }
            if (price > 24000)
            {
                commissions = price * .10;
                Console.WriteLine("Your commissions are" + commissions.ToString("C"));
            }
        }
    }
}
