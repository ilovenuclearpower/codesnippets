/*
 * C# Program to List all Substrings in a given String
 */
 //Will combinatorically generate all substrings of a given string.
using System;
namespace mismatch
{
    class Program
    {
        string value, substring;
        int j, i;
        string[] a = new string[5];
        void input()
        {
            Console.WriteLine("Enter the String : ");
            value = Console.ReadLine();
            Console.WriteLine("All Possible Substrings of the Given String are :");
            for (i = 1; i <=value.Length; i++)
            {
            //Nested loops guarantee all of the substring indices will be created.
            //This is runtime of O(n^2) in terms of number of characters.
                for (j = 0; j <= value.Length - i; j++)
                {
                    substring = value.Substring(j, i);
                    a[j] = substring;
                    Console.WriteLine(a[j]);
                }
            }
        }
        public static void Main()
        {
            Program pg = new Program();
            pg.input();
            Console.ReadLine();
        }
    }
