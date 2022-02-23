// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace Generics
{
    class program
    {
     
        public  static void Main()
        {
            

            MaxValue<int> maxInt = new MaxValue<int>();
            maxInt.Max(10,20,30);

            MaxValue<double> maxDouble = new MaxValue<double>();
            maxDouble.Max(10.58,30.89,88.97);

            MaxValue<string> maxString = new MaxValue<string>();
            maxString.Max("asd","erg","yrs");

        }

       
    }
}
