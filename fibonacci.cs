/*
 * C#  Program to Generate Fibonacci Series
 */
 // Iterative solution - a recursive solution is possible.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace fibonaci
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, count, f1 = 0, f2 = 1, f3 = 0;
            Console.Write("Enter the Limit : ");
            count = int.Parse(Console.ReadLine());
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            for (i = 0; i <= count; i++)
            {
                f3 = f1 + f2;
                // expressing the new value in terms of the previous two values.
                Console.WriteLine(f3);
                f1 = f2;
                f2 = f3;
                // making the new value the inputs to the next iteration.
            }
            Console.ReadLine();
 
        }
    }
}
//Taken from: https://www.sanfoundry.com/csharp-program-generate-fibonocci-series/
