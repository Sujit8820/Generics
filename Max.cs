using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Max
    {
        public double max = 0;

        public void MaxInt(double firstNo, double secondNo, double thirdNo)
        {
            if (firstNo.CompareTo(secondNo) > 0 && firstNo.CompareTo(thirdNo) > 0 ||
               firstNo.CompareTo(secondNo) >= 0 && firstNo.CompareTo(thirdNo) > 0 ||
               firstNo.CompareTo(secondNo) > 0 && firstNo.CompareTo(thirdNo) >= 0)
            {
                max = firstNo;
            }
            if (secondNo.CompareTo(firstNo) > 0 && secondNo.CompareTo(thirdNo) > 0 ||
               secondNo.CompareTo(firstNo) >= 0 && secondNo.CompareTo(thirdNo) > 0 ||
               secondNo.CompareTo(firstNo) > 0 && secondNo.CompareTo(thirdNo) >= 0)
            {
                max = secondNo;
            }
            if (thirdNo.CompareTo(firstNo) > 0 && thirdNo.CompareTo(secondNo) > 0 ||
               thirdNo.CompareTo(firstNo) >= 0 && thirdNo.CompareTo(secondNo) > 0 ||
               thirdNo.CompareTo(firstNo) > 0 && thirdNo.CompareTo(secondNo) >= 0)
            {
                max = thirdNo;
            }
            Console.WriteLine($"\nMaximum value {max}");

        }
    }
}
