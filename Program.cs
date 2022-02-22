// See https://aka.ms/new-console-template for more information
using System;
namespace Generics
{
    class program
    {
       
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter three value\n");
            Console.Write("First value:");
            double firstNo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Second value:");
            double SecondNo = Convert.ToDouble(Console.ReadLine());

            Console.Write("Third value:");
            double ThirdNo = Convert.ToDouble(Console.ReadLine());

            Max max = new Max();
            max.MaxInt(firstNo, SecondNo, ThirdNo);

        }
    }
}
