class Solution
{
    static void Main(string[] args)
    {
        List<int> test = GetIndexOfNeedle("a", "abbbbabbbbbbbbbbba");
        
        foreach (int thing in test)
        {
            Console.WriteLine(thing);
        }
    }
    
    static List<int> GetIndexOfNeedle(string needle, string haystack)
    {
        double hash = GetStringHash(needle);
        //Hashes our needle value.
        double slidingwindowhash = GetStringHash(haystack.Substring(0, needle.Length));
        List<int> output = new List<int>();
        int pointer1 = 0;
        int pointer2 = needle.Length -1;
        
        while (pointer2 < haystack.Length -1)
        {
            if (slidingwindowhash == hash)
            {
                output.Add(pointer1);
                //If the hashes are equal, I add pointer1 to my index.
            }
            double pointer1hash = (int)haystack[pointer1] * Math.Pow(257, pointer2 - pointer1);
            slidingwindowhash -= pointer1hash;
            //Subtracts the left pointer from our running hash total.
            slidingwindowhash *= 257;
            //Shifts our hash one position to the left. (Remember we are using Base 257 for our string positions)
            pointer1++;
            pointer2++;
            double pointer2hash = (int)haystack[pointer2];
            slidingwindowhash += pointer2hash;
            //Adds the hashvalue of pointer2 (which is the character x 257^0, which is just the character value)
            //after updating pointer1 and pointer2.
            
        }
        if (slidingwindowhash == hash)
        {
                output.Add(pointer1);
        }
                                                
        return output;
    }
    
    static double GetStringHash(string s)
    {
        double hash = 0;
        for (int i = 0; i < s.Length; i++)
        {
            hash += (int)s[i] * Math.Pow(257, s.Length -1 - i);
            //Casting a (char) to (int) gives us the unicode value.
            //Multiplying it by 257^s.Length-1-i gives us it's relative "position"
            //in the string.
        }
        return hash;
    }
}

//This program will return the index location of every instance of string argument needle within the input string haystack.
//It conducts this search in O(N) time.
//It is only guaranteed to work with the ASCII alphabet. Unicode hashes are plausible but not implemented.
//You could potentially use FileStream or IOStream to produce strings of characters from a file.
//Written by Connor Alexander Matza for a mock interview
