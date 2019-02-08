using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
    public class isPalindromePermutation
    {
        public bool isPalindrome(string str)
        {
            str.ToCharArray();
            List<char> charlist = str.ToList<char>();
            /*foreach(char letter in charlist)
            {
                Commenting this section out, it's possible you can just remove spaces from the dictionary after the char frequency dictionary is created.
                char space = ' ';
                if(letter == space)
                {
                    charlist.Remove(letter);
                }
            }*/
            Dictionary<char, int> letterfrequency = new Dictionary<char, int>();

            for(int i = 0; i < str.Length; i++)
            {
                //Iterate through every letter in my character array, adding one to the value in the dict if it finds the letter again. When it finds a letter for the first time, it adds that letter as a key with the value initialized to one.
                if(letterfrequency.ContainsKey(str[i]))
                {
                    letterfrequency[str[i]] += 1;
                }
                else
                {
                    letterfrequency.Add(str[i], 1);
                }
                //Note this does not create duplicate keys in the dictionary - it first checks (in constant time) if they key exists, and if it does it adds one to the integer value held by that key. Dicts do not accept duplicate keys.
            }
            letterfrequency.Remove(' '); 
            //Since I only created one instance of each letter key, I can just use the Remove method to remove it in O(n) time, reducing my complexity from O(n^2) to O(n).
            int odds = 0;
            foreach(KeyValuePair<char, int> key in letterfrequency)
            {
                if(key.Value % 2 == 0)
                {
                    odds++;
                }
            }
            if(odds > 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
    //source - written by Connor Alexander Matza
}

