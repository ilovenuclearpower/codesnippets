using System;

class Program
{
    static void Main()
    {
        string data = "there is a cat";
        // Split string on spaces (this will separate all the words).
        string[] words = data.Split('');
        // Splits the string by the delimiter character.
        // you could also specify the maximum number of substrings to create by data.Split(SomeInt, "");
        foreach (string word in words)
        {
            Console.WriteLine("WORD: " + word);
        }
    }
}
/*Output:
WORD: there
WORD: is
WORD: a
WORD: cat
*/

//Taken from: https://www.dotnetperls.com/split
