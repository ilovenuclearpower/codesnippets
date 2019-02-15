/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public string SmallestFromLeaf(TreeNode root) {
        String smallestSequence = TreeTraverse(root);
        //Driver for the recursive method defined below.
        char[] smallestArray = smallestSequence.ToCharArray();
        Array.Reverse(smallestArray);
        string output = new string(smallestArray);
        return smallestSequence;

    }
    public string TreeTraverse(TreeNode node)
    {
        //Base case, in this case the end case. Nothing needs to be appended here.
        if(node == null)
        {
            return "";
        }
        
        //Recursive calls down the tree
        //Note: Will return the sequence in reverse order.
        
        string rightSequence = TreeTraverse(node.right);
        string leftSequence = TreeTraverse(node.left);

        string small;
        
        //Nullchecking.
        
        if(String.IsNullOrEmpty(leftSequence))
        {
            small = rightSequence;
        }
        else if (String.IsNullOrEmpty(rightSequence))
        {
            small = leftSequence;
        }
        
        //Lexicographic comparator function (thanks C# built in library)
        
        else
        {
            //Ternarys are hard.
            small = leftSequence.CompareTo(rightSequence) < 0 ? leftSequence : rightSequence;
        }
        
        //Stringbuilder lets me append one character at a time.
        
        StringBuilder sb = new StringBuilder();
        
        //Casting values here work great, since the a-z charset is in one range of int values and I know the values I care about are 1-26
        //I can just start them at the value of "a" and use the built-in cast.
        
        char rc = (char)('a' + node.val);
        sb.Append(small);
        sb.Append(rc);
        return sb.ToString();
    }
    }
    
    //Written by Connor Matza for https://leetcode.com/problems/smallest-string-starting-from-leaf/
