using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class MaxValue<T>
    {
        public T max;
       
        public T Max(T firstValue, T secondValue, T thirdValue)
        {
            if (Comparer<T>.Default.Compare (firstValue,secondValue) > 0 && Comparer<T>.Default.Compare(firstValue, thirdValue) > 0 ||
               Comparer<T>.Default.Compare(firstValue, secondValue) >= 0 && Comparer<T>.Default.Compare(firstValue, thirdValue) > 0 ||
               Comparer<T>.Default.Compare(firstValue, secondValue) > 0 && Comparer<T>.Default.Compare(firstValue, thirdValue) >= 0 )
            {
                max = firstValue;
            }
            if (Comparer<T>.Default.Compare(secondValue, firstValue) > 0 && Comparer<T>.Default.Compare(secondValue, thirdValue) > 0 ||
               Comparer<T>.Default.Compare(secondValue, firstValue) >= 0 && Comparer<T>.Default.Compare(secondValue, thirdValue) > 0 ||
              Comparer<T>.Default.Compare(secondValue, firstValue) > 0 && Comparer<T>.Default.Compare(secondValue, thirdValue) >= 0)
            {
                max = secondValue;
            }
            if (Comparer<T>.Default.Compare(thirdValue, firstValue) > 0 && Comparer<T>.Default.Compare(thirdValue, secondValue) > 0 ||
               Comparer<T>.Default.Compare(thirdValue, firstValue) >= 0 && Comparer<T>.Default.Compare(thirdValue, secondValue) > 0 ||
               Comparer<T>.Default.Compare(thirdValue, firstValue) > 0 && Comparer<T>.Default.Compare(thirdValue, secondValue) >= 0)
            {
                max = thirdValue;
            }
            Console.WriteLine(max);
            return max;
        }
    }
}
