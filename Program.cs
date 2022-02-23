// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace MaxValue
{
    class program
    {
     
        public  static void Main()
        {
            Generic<int> maxInt = new Generic<int>(10,20,30);
           Console.WriteLine( maxInt.TestMaximum());

            Generic<double> maxDouble = new Generic<double>(50.68,78.53,83.94);
            Console.WriteLine(maxDouble.TestMaximum());


            Generic<string> maxstring = new Generic<string>("fged","wpod","zedt");
            Console.WriteLine(maxstring.TestMaximum());


        }


    }
}
