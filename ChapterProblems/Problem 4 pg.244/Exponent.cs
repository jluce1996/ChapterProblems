﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_4_pg._244
{
    class Exponent
    {
        public static void Main()
        {
            int integer;
            string input;
            Console.WriteLine("Yo, enter a number:");
            input = Console.ReadLine();
            integer = Convert.ToInt32(input);
            Square(integer);
            Cube(integer);
      
        }
        public static void Square(int number)
        {
            number = number * number;
            Console.WriteLine(number);
        }
        public static void Cube(int cubic)
        {
            cubic = cubic * cubic * cubic;
            Console.WriteLine(cubic);
        }
    }
}
