public class Solution {

            // Overall comment, if it works, it works!!
            // Duplicate code should indicate an opportunity
            // You used quite a few data structures, more with less when possible
            // Ex: You're using List<>, Dictionary, Hashset and KeyValuePair
            // You tend to data groom/transform, then pass it to your method
            // Try to build methods that take the data in its original form
            // Start using meaningful names and make that a habit
            // Example, change A and B to stringOne and stringTwo
    public string[] UncommonFromSentences(string A, string B) {

                // Duplicate efforts, if you do it twice move it to its
                // own method, or add it to an existing method
        var wordsinA = A.Split(" ");
        var wordsinB = B.Split(" ");
        //Generates all words in the phrase (separated by spaces).
        List<string> output = new List<string>();
        //Generating output var.
        
                // Here's an example of your data transform, pass the original string A and B
                // Essentially, you may only have to create the string[] or one other type
                // that you use during your transform
        Dictionary<string, int> uniqueA = new Dictionary<string, int>();
        HashSet<string> setinA = new HashSet<String>();
        
        Dictionary<string, int> uniqueB = new Dictionary<string, int>();
        HashSet<string> setinB = new HashSet<String>();
        
                // Comments go above code or on the end, not underneath
                // Objects are passed by reference, so it's not necessary
                // to use the keyword 'out' both Dictionary and HashSet
                // will be passed by address and you'll be modifying
                // the data of the object passed into the method.
                // Example: Use out for int32 (Not a rule, just technique)
        BuildUniqueWords(wordsinA, out uniqueA, out setinA);
        BuildUniqueWords(wordsinB, out uniqueB, out setinB);
        //This is probably more clever than it has to be.

                // Duplicate code, two foreach loops that do the same thing
                // By the way, glad to see the use of foreach, shows some experience
                // Consider using var for implied types. Readability goes down,
                // but reusability and fewer code changes during a refactor
                // In this case, KeyValuePair<string, int> would be replaced with var
        foreach (KeyValuePair<string, int> uniqueinA in uniqueA)
        {
            if(!setinB.Contains(uniqueinA.Key))
            {
                output.Add(uniqueinA.Key);
            }
        }
        
        foreach (KeyValuePair<string, int> uniqueinB in uniqueB)
        {
            if(!setinA.Contains(uniqueinB.Key))
            {
                output.Add(uniqueinB.Key);
            }
        }
        //If there's only one word in A and it doesn't exist in B, we found our word and add it to the list.
        //Same for B.
        return output.ToArray(); // This is good technique, combining a transformation on the return
        
    }
    
    static void BuildUniqueWords(string[] words, out Dictionary<string, int> uniquewords, out HashSet<string> wordsSeen)
    {
        //This is a little tricky, it builds both the set of all words in the passed string
        // and the set of words that only appear once at the same time.
        Dictionary<string, int> singlewords = new Dictionary<string, int>();
        HashSet<string> seenWords = new HashSet<string>();
        for(int i = 0; i < words.Length; i++)
            if (singlewords.ContainsKey(words[i]))
            {
                singlewords.Remove(words[i]);
                seenWords.Add(words[i]);
            }
            else if (!seenWords.Contains(words[i]))
            {
                singlewords.Add(words[i], 1);
                seenWords.Add(words[i]);
            }
        uniquewords = singlewords;
        wordsSeen = seenWords;
    }
}
//Written by Connor Matza for https://leetcode.com/problems/uncommon-words-from-two-sentences/
