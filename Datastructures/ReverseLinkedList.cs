using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures
{
    public class ReverseLinkedList
    {
        public ListNode Reverse(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            ListNode curr = head;
            ListNode prev = null;
            while (curr != null)
            {
                ListNode curr_next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = curr_next;
            }

            return prev;
        }
    }
}

//head -> 1 -> 2 -> 3 -> 4
          