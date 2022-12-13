/*
You are given two non-empty linked lists representing two non-negative integers.
The digits are stored in reverse order, and each of their nodes contains a single digit.
Add the two numbers and return the sum as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself. 
*/

// Definition for singly-linked list.
public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }
 
public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2, bool next = false)
    {
        var val1 = l1?.val ?? 0;
        var val2 = l2?.val ?? 0;
        var sum = val1 + val2 + (next ? 1 : 0);
        var current = sum % 10;
        next = sum >= 10;

        if (l1?.next == null && l2?.next == null)
            return new ListNode(current, (next ? new ListNode(1) : null));

        var nextVal = AddTwoNumbers(l1?.next ?? null, l2?.next ?? null, next);

        return new ListNode(current, nextVal);
    }
}