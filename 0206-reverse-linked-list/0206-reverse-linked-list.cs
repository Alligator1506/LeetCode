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
    public ListNode ReverseList(ListNode head) {
        ListNode newList = null;
        ListNode current = head;
        while (current != null) {
            ListNode next = current.next;
            current.next = newList;
            newList = current;
            current = next;
        }
        return newList;
    }
}