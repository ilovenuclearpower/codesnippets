/*
 * C# Program to Swap two Numbers
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;
            Console.Write("\nEnter the First Number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the Second Number : ");
            num2 = int.Parse(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : "+num1);
            Console.Write("\nSecond Number : "+num2);
            Console.Read();
            // This is the most efficient way you can do swapping 
            // without using bit manipulation.
            
        }
        static void Swap<T>(ref T lhs, ref T rhs)
        {
        T temp;
        temp = lhs;
        lhs = rhs;
        rhs = temp;
        }
        // A generic implementation. However, since T is listed as a *reference* type and not a value type
        // Any value types you use as arguments to this method will be "boxed" and could hurt performance.
        // However, you can still run this method on arguments of any type, provided they are the same type.
    }
}



//Taken from sanfoundry https://www.sanfoundry.com/csharp-programs-generate-swap/
//Generic method from https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/generic-methods
