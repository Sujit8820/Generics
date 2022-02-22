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
            string firstNo = Console.ReadLine();

            Console.Write("Second value:");
            string SecondNo = Console.ReadLine();

            Console.Write("Third value:");
            string ThirdNo = Console.ReadLine();

            Max max = new Max();
            max.MaxInt(firstNo, SecondNo, ThirdNo);

        }
    }
}
