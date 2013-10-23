using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_3_pg._244
{
    class Monogram
    {
        public static void Main()
        {                 
            DisplayMonogram("J", "E", "L");
            DisplayMonogram("K", "W", "H");
            Console.ReadKey();            
        }
        public static void DisplayMonogram(string first, string middle, string last)
        {
            Console.WriteLine("** {0}. {1}. {2}. **", first, middle, last);
        }        
    }
}
