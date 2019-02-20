/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
 
 //The basic method here is to in-place create a new Linked List by taking the *smallest value* of the three linked lists.
 //Then incrementing the "pointer" node to the next node in its linked list. Rinse, repeat.
 //Time complexity is O(kN) where k is the number of linked lists and N is the number of total elements.
 //Space complexity is O(N) for the output array.
 //There is a logarithmic class solution to this problem using a priority queue - want to work on priority queues next!
public class Solution {
    public ListNode MergeKLists(ListNode[] lists) {
        //Creates an array of our "pointer" variables pointing to the head nodes of the supplied lists.
        ListNode[] pointers = new ListNode[lists.Length];
        
        for (var i = 0; i < pointers.Length; i++)
        {
            pointers[i] = lists[i];
        }
        
        //Creates a new linked list with two pointers. This will wind up being a Sentinel node.
        ListNode head = new ListNode(-1);
        ListNode cur = head;
        
        while (pointerListisNotNull(pointers))
        {
            int min = Int32.MaxValue;
            int currentSeen = 0;
            int indexofSmallest = 0;
            
            for (var i = 0; i < pointers.Length; i++)
            {
                //If we have a null node, that means the list is empty. It might be optimal
                //to remove the linked list at this point.
                if(pointers[i] == null)
                {
                    continue;
                }
                currentSeen = pointers[i].val;
                
                //I used an if statement here instead of Math.Min to be able to save the index of the smallest node seen.
                if (currentSeen < min)
                {
                    indexofSmallest = i;
                    min = currentSeen;
                }
            }
            cur.next = new ListNode(min);
            cur = cur.next;
            pointers[indexofSmallest] = pointers[indexofSmallest].next;
            
        }
        return head.next;
    }
    
    //Helper method that answers the question - "Did we reach the end of *all* lists"?
    public bool pointerListisNotNull(ListNode[] pointers)
    {
        bool output = false;
        
        for(var i = 0; i < pointers.Length; i++)
        {
            if(pointers[i] != null)
            {
                output = true;
            }
        } 
        return output;
    }
}
//Written by Connor Matza as a solution to https://leetcode.com/problems/merge-k-sorted-lists/
