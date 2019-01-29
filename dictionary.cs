using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Version 1: create a Dictionary, then add 4 pairs to it.
        var dictionary = new Dictionary<string, int>();
        dictionary.Add("cat", 2);
        dictionary.Add("dog", 1);
        dictionary.Add("llama", 0);
        dictionary.Add("iguana", -1);
        // The dictionary has 4 pairs.
        Console.WriteLine("DICTIONARY 1: " + dictionary.Count);
        //Writes out the size of the second dictionary.

        // Version 2: create a Dictionary with an initializer.
        var dictionary2 = new Dictionary<string, int>()
        {
            { "cat", 2},
            { "dog", 1},
            { "llama", 0},
            { "iguana", -1}
        };
        // This dictionary has 4 pairs too.
        Console.WriteLine("DICTIONARY 2: " + dictionary2.Count);
        //Writes out the size of the second dictionary.
        //You could add:
        /* for each(var thing in dictionary2)
        {
        Console.WriteLine(thing.key + " " + thing.value); //You can't expect a dictionary to be ordered in any specific way.
        } */
    }
}
// Taken from DotNetPerls: https://www.dotnetperls.com/dictionary
