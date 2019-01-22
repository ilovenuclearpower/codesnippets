using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // List with duplicate elements.
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(3);
        list.Add(4);
        list.Add(4);
        list.Add(4);
        /*List<>.Add() adds the value of the argument to the list. This will extend the memory space of the list unlike in an array,
        whose memory will remain static and let you go "out of range". *\
        foreach (int value in list)
        {
            Console.WriteLine("Before: {0}", value);
        }
        /*The preceding is a simple for loop to print out every value in the list. You can't just use Console.WriteLine(list) as the value of
        list is System.Collections.List<int>*/
        // Get distinct elements and convert into a list again.
        List<int> distinct = list.Distinct().ToList();

        foreach (int value in distinct)
        {
            Console.WriteLine("After: {0}", value);
        }
    }
}

//Taken from Dot Net Pearls - url: https://www.dotnetperls.com/duplicates
