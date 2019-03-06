public class Solution {
    public string[] UncommonFromSentences(string A, string B) {
        var wordsinA = A.Split(" ");
        var wordsinB = B.Split(" ");
        //Generates all words in the phrase (separated by spaces).
        List<string> output = new List<string>();
        //Generating output var.
        
        Dictionary<string, int> uniqueA = new Dictionary<string, int>();
        HashSet<string> setinA = new HashSet<String>();
        
        Dictionary<string, int> uniqueB = new Dictionary<string, int>();
        HashSet<string> setinB = new HashSet<String>();
        
        BuildUniqueWords(wordsinA, out uniqueA, out setinA);
        BuildUniqueWords(wordsinB, out uniqueB, out setinB);
        //This is probably more clever than it has to be.
        
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
        return output.ToArray();
        
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
