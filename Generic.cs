using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxValue
{
    class Generic<T>
    {
        public T[] array;

        public  Generic(T[] array)
        { 
            this.array = array; 
        }

        public T[] SortingArray(T[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);
            return array;
        }
      
        public void  TestMaximum()
        {
            T[] reversedArray = SortingArray(array);
            T maxValue = reversedArray[0];
            Console.WriteLine(maxValue);
        }  
    }   
}
