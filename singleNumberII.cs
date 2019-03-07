public class Solution {
    public int SingleNumber(int[] nums) {
        //We create a dictionary to count every time a number is seen.
        Dictionary<int, int> count = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
        //When we see it, we add it to the dictionary or increase its value by one.
            if (count.ContainsKey(nums[i]))
            {
                count[nums[i]]++;
            }
            else
            {
                count.Add(nums[i], 1);
            }
        }
        //We scan the dictionary for the only number with a value of 1.
        foreach (KeyValuePair<int, int> number in count)
        {
            if(number.Value == 1)
            {
                return number.Key;
            }
        }
        return -1;
    }
    //There is an *extremely* clever solution involving bitwise manipulation
    //that requires no extra space - however as an interview question 
    //(done in leetcode mock interviews), I felt it better to come up with the
    // O(N) time and O(N) space solution in 3 minutes than spend an hour grokking
    // the complicated bitwise math.
}

//Written by Connor Matza as a solution to: https://leetcode.com/problems/single-number-ii/
