public class Solution {
    public bool IsSubsequence(string s, string t) {
        string slice = t;
        int sCounter = 0;
        //Counter variable for how many characters we have found.
        if(String.IsNullOrEmpty(s))
        {
            return true;
            //Break out on null inputs.
        }
        for(int i = 0; i < t.Length; i++)
        {
            if(t[i] == s[sCounter])
            {
                sCounter++;
                //counter represents the character in s we're looking for, i represents the index in t that we're at.
                //If we find it, we increment sCounter.
            }
            if(sCounter >= s.Length)
            {
                return true;
                //If sCounter *ever* hits the length of s - we know this is true and break here (the way we add to sCount requires
                //the correct order.
            }
        }
        return false;
}
}

//Written by Connor Matza for problem https://leetcode.com/problems/is-subsequence/submissions/ runtime 116ms passing 14 text cases.
