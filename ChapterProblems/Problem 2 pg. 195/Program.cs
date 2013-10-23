using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_2_pg._195
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ZipCodes = new int[10];
            ZipCodes[0] = 12345;
            ZipCodes[1] = 12346;
            ZipCodes[2] = 12347;
            ZipCodes[3] = 12348;
            ZipCodes[4] = 12349;
            ZipCodes[5] = 12340;
            ZipCodes[6] = 12341;
            ZipCodes[7] = 12342;
            ZipCodes[8] = 12343;
            ZipCodes[9] = 12344;

            Console.WriteLine("What is your zipcode?");
            string input = Console.ReadLine();   
            for (int i = 0; i < ZipCodes.Count(); i++)
            {
                if (input == ZipCodes[i].ToString())
                {
                    Console.WriteLine("We deliver to you!");
                    break;
                }
                else if (i == ZipCodes.Length - 1)
                {
                    Console.WriteLine("Sorry, we don't deliver to you");
                   
                }
            }

        }
    }
}
