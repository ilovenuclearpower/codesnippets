using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> birds = new Dictionary<string, int>()
        {
            { "crow", 10 }, { "robin", 5 }
        };

        // Use KeyValuePair to use foreach on Dictionary.
        foreach (KeyValuePair<string, int> bird in birds)
        {
            //Each KeyValuePair here holds two values, accessible by bird.Key and bird.Value;
            Console.WriteLine($"Pair here: {bird.Key}, {bird.Value}");
        }
    }
}
//Taken from: https://www.dotnetperls.com/keyvaluepair
