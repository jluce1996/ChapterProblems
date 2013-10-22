using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_4_pg._195
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] areacode = new int[6] { 262, 414, 608, 715, 815, 920 };
            Double[] rate = new double[6] { .07, .10, .05, .16, .24, .14 };
            double price = 0;
            string input;
            string inputminutes;
            
            Console.WriteLine("Enter your area code");
            input = Console.ReadLine();
            Console.WriteLine("Enter your number of minutes");
            inputminutes = Console.ReadLine();

            for (int i = 0; i < areacode.Length; i++)
            {
                if (input == areacode[i].ToString())
                {
                    price = rate[i] * Convert.ToInt32(inputminutes);
                    Console.WriteLine("Your cost is" +     price.ToString("C"));
                    break;
                }
                else if (i == 5)
                {
                    Console.WriteLine("Entered an invalid area code.");
                }
            }
        }
    }
}
