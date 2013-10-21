using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChapterProblems
{
    class Furniture
    {
        static void Main(string[] args)
        {
            int price = 0;
            Console.WriteLine("(P)ine, (O)ak, (M)ahogany?");
            string input = Console.ReadLine();
            if (input == "P")
            {
                price += 100;
                Console.Write(Convert.ToInt32(price));
            }
            else if (input == "O")
            {
                price += 225;
                Console.Write(Convert.ToInt32(price));
            }
            else if (input == "M")
            {
                price += 310;
                Console.Write(Convert.ToInt32(price));
            }
            else
                price += 0;
        }
    } 
}
