using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 6, 7, 8 };
        // Query expression.
        var elements = from element in array
                       orderby element descending
                       where element > 2
                       select element;
        // Don't get caught here - this isn't SQL!
        // The syntax is pretty familiar though, isn't it?
        // This is because .NET felt like offering extension methods
        // to allow imperative programmers to use declarative
        // programming to work with data sets.
        // Enumerate.
        foreach (var element in elements)
        {
            Console.Write(element);
            Console.Write(' ');
            //Outputs the elements.
        }
        Console.WriteLine();
    }
}
