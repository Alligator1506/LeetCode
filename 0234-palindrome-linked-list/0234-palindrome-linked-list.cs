/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public bool IsPalindrome(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return true;
        }

        ListNode slow = head;
        ListNode fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        Stack<int> stack = new Stack<int>();
        ListNode current = slow;
        while (current != null)
        {
            stack.Push(current.val);
            current = current.next;
        }

        current = head;
        while (stack.Count > 0)
        {
            if (current.val != stack.Pop()) return false;
            current = current.next;
        }
        return true;
    }
}