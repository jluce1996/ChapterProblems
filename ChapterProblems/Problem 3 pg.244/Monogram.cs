using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_3_pg._244
{
    class Monogram
    {
        static void Main()
        {
            string myfirst;
            string friendfirst;
            string mymiddle;
            string friendmiddle;
            string mylast;
            string friendlast;
            DisplayMonogram(myfirst, mymiddle, mylast);
            
        }
        public static void DisplayMonogram(string first, string middle, string last)
        {
            Console.WriteLine("** {0}. {1}. {2}. **", first, middle, last);


        }
        
    }
}
