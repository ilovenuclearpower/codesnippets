public class Solution {
    public string[] UncommonFromSentences(string first, string second) {
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            CountWords(first, wordCounts);
            CountWords(second, wordCounts);

            var uncommon = wordCounts.Where(wc => wc.Value == 1).Select(w => w.Key);

            return uncommon.ToArray();
    }
    
    private static void CountWords(String sentence, Dictionary<string, int> wordCounts)
    {
        var words = sentence.Split(' ');

        foreach (var word in words)
        {
            if (wordCounts.ContainsKey(word))
            {
                wordCounts[word]++;
            }
            else
            {
                wordCounts.Add(word, 1);
            }
        }
    }
}