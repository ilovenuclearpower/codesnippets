public class Solution {
    public string ShortestCompletingWord(string licensePlate, string[] words) {
        Dictionary<char, int> inputset = new Dictionary<char, int>();
        Dictionary<char, int> checkWord = new Dictionary<char, int>();
        string bestWord = "";
        int memoBestWord = Int32.MaxValue;
        var inputchararrayUpper = licensePlate.ToUpper().ToCharArray();
        
        for (int i = 0; i < inputchararrayUpper.Length; i++)
        {
            if(Char.IsNumber(inputchararrayUpper[i]) || (inputchararrayUpper[i] == ' '))
            {
                continue;
            }
            if(inputset.ContainsKey(inputchararrayUpper[i]))
            {
                inputset[inputchararrayUpper[i]]++;
            }
            else
            {
                inputset.Add(inputchararrayUpper[i], 1);
            }
        }
        //Constructs a dictionary of characters to values, minus numbers and spaces.
        
        for (int i = 0; i < words.Length; i++)
        {
            Dictionary<char, int> workingSet = new Dictionary<char, int>(inputset);
            words[i] = words[i].ToUpper();
            //Resets our workingSet dictionary and converts the current word to UPPER CASE
            for (int j = 0; j < words[i].Length; j++)
            {
                if(checkWord.ContainsKey(words[i][j]))
            {
                checkWord[words[i][j]]++;
            }
                else
            {
                checkWord.Add(words[i][j], 1);
            }
            //Builds a second dictionary of the current word characters to values. Thankfully no edge cases here.
            }
            foreach (KeyValuePair<char, int> character in checkWord)
            {
                if(workingSet.ContainsKey(character.Key))
                {
                    workingSet[character.Key] -= character.Value;
                    
                    if(workingSet[character.Key] <= 0)
                    {
                    workingSet.Remove(character.Key);
                    }
                }
            }
            //For every char in checkword, we subtract its value from the value in workingset.
            //If the value of a character in workingset is less than or equal to zero, we take it out.
            //(There aren't any more)
            if (workingSet.Count <= 0)
            {
                if(words[i].Length < memoBestWord)
                {
                    bestWord = words[i];
                    memoBestWord = bestWord.Length;
                }
            }
            //If workingset is empty, we found a match!
            //Now we check to see if it's the shortest match.
            checkWord = new Dictionary<char, int>();
            //Resetting our checkWord to a fresh Dict.
        }
        return bestWord.ToLower();
}
}

//Written by Connor Matza for https://leetcode.com/problems/shortest-completing-word/submissions/
//Runtime - O(N * C) where N is the number of words and C is the avg. number of characters in the words.
