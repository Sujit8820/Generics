// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace MaxValue
{
    class program
    {

        public static void Main()
        {
            int[] arrayOfInt = { 2, 8, 4, 6, 1, 9, 7 };
            double[] arrayOfDouble = { 1.58, 5.89, 7.29, 4.28, 8.36, 7.65, 3.59 };
            string[] arrayOfString = { "sde", "wed", "rtd", "iuw", "pod", "aef", "erf" };

            Generic<int> maxInt = new Generic<int>(arrayOfInt);
            maxInt.PrintMax();

            Generic<double> maxDouble = new Generic<double>(arrayOfDouble);
            maxDouble.PrintMax();

            Generic<string> maxstring = new Generic<string>(arrayOfString);
            maxstring.PrintMax();

        }
    }
}
