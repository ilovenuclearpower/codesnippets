public class Solution {
    public bool IsPowerOfTwo(int n) {
        //there are no powers of two that are less than 0. This is an awful hack to avoid overflow errors.
        if(n < 0)
            return false;
       return (n != 0) && ((n & (n-1)) == 0);
       //The second method returns a false positive for n = 0, so I excluded it as a special case.
       //If n is a number that is a power of two, only one bit will be in the "on position" 
       //EX: 0000 0000 1000 0000 0000 0000 0000 0000
       // In that case, n - 1 ==
       //    0000 0000 0111 1111 1111 1111 1111 1111 
       // THUS n & (n - 1) = 0.
    }
}


//Written by Connor Matza for LeetCode problem https://leetcode.com/problems/power-of-two
