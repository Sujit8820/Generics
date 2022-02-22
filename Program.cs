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
            int firstNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Second value:");
            int SecondNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Third value:");
            int ThirdNo = Convert.ToInt32(Console.ReadLine());

            Max max = new Max();
            max.MaxInt(firstNo, SecondNo, ThirdNo);

        }
    }
}
