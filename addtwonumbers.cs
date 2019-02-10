/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int l1Length = 0;
        int l2Length = 0;
        ListNode node1 = l1;
        ListNode node2 = l2;
        ListNode node3 = new ListNode(-1);
        //The first node of the new linked list.
        ListNode curNode = node3;
        //Another pointer to the head node of the new linked list.
        int carry = 0;
        while((node1 != null) || (node2 != null))
        {
            //We only care about addition if we have valid nodes in both linked lists.
            if((node1 != null) && (node2 != null))
            {
                //Creates a new node pointed to by curNode.next. Then moves curNode to curNode.next (node3 points to the head.
                //
                curNode.next = new ListNode(((node1.val + node2.val + carry) % 10));
                carry = (node1.val + node2.val + carry)/10;
                curNode = curNode.next;
                node1 = node1.next;
                node2 = node2.next;
                
            }
            //If node1 is null, we've hit the end of the first linked list and can just add the second linked list nodes
            //and the carry int.
            else if(node1 == null)
            {
                curNode.next = new ListNode((node2.val + carry) % 10);
                carry = ((node2.val + carry) /10);
                curNode = curNode.next;
                node2 = node2.next;
            }
            //Replicated logic here for node2. I could probably replace with a fancy ternary.
            else
            {
                curNode.next = new ListNode((node1.val + carry) % 10);
                carry = ((node1.val + carry) /10);
                curNode = curNode.next;
                node1 = node1.next;
            }
        }
        if(carry > 0)
        {
            curNode.next = new ListNode(carry);
        }
        return node3.next;
        //node3 will still always equal -1 because of the way I created it.
    }
}

//Source: Connor Alexander Matza
