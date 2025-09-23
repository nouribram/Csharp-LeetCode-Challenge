// Problem: Merge Two Sorted Lists 
// ---------------------------------------------------------
// Task:
//   Merge two sorted linked lists into one sorted linked list,
//   and return the merged list.
//
// Example:
//   Input: l1 = [1,2,4], l2 = [1,3,4]
//   Output: [1,1,2,3,4,4]
//
//   Input: l1 = [], l2 = []
//   Output: []
//
//   Input: l1 = [], l2 = [0]
//   Output: [0]
//
// Approach:
//   - Use a dummy node to simplify handling the head of the new list.
//   - Use a pointer (current) to build the merged list.
//   - Compare values from l1 and l2 one by one, attach the smaller node to current.
//   - Move forward in the list from which the node was taken.
//   - When one list is finished, attach the remainder of the other list.
//   - Return dummy.next (skipping the dummy node).
//


using System;

// Definition for singly-linked list.
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        // Create a dummy node to simplify edge cases
        ListNode dummy = new ListNode(-1);
        ListNode current = dummy;

        // Traverse both lists until one is finished
        while (l1 != null && l2 != null)
        {
            if (l1.val <= l2.val)
            {
                current.next = l1; // Attach l1 node
                l1 = l1.next;      // Move forward in l1
            }
            else
            {
                current.next = l2; // Attach l2 node
                l2 = l2.next;      // Move forward in l2
            }
            current = current.next; // Move the pointer
        }

        // Attach any remaining nodes
        current.next = (l1 != null) ? l1 : l2;

        // Return the merged list (skipping dummy node)
        return dummy.next;
    }
}

// ---------- Example Usage ----------
public class Program
{
    public static void Main(string[] args)
    {
        // Example: l1 = [1,2,4], l2 = [1,3,4]
        ListNode l1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        ListNode l2 = new ListNode(1, new ListNode(3, new ListNode(4)));

        Solution sol = new Solution();
        ListNode merged = sol.MergeTwoLists(l1, l2);

        // Print merged list -> 1 -> 1 -> 2 -> 3 -> 4 -> 4
        while (merged != null)
        {
            Console.Write(merged.val + " ");
            merged = merged.next;
        }
    }
}
