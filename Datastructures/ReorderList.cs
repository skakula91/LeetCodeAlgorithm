using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures
{
    public class ReorderList
    {
        public void Reorder(ListNode head)
        {
            if(head == null || head.next == null)
                return;

            //pointer to point start l1
            ListNode l1 = head;
            // pointer to point end l1
            ListNode prev = null;
            //pointer to point start l2
            ListNode slow = head;
            //pointer to point end l2;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                prev = slow;
                slow = slow.next;
                fast = fast.next.next;
            }

            prev.next = null;

            ListNode l2 = ReverseList(slow);
            Merge(l1,l2);
        }

        public ListNode ReverseList(ListNode head)
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

        public void Merge(ListNode l1, ListNode l2)
        {
            while (l1 != null)
            {
                ListNode l1_next = l1.next;
                ListNode l2_next = l2.next;

                l1.next = l2;
                if (l1_next == null)
                    break;

                l2.next = l1_next;
                l1 = l1_next;
                l2 = l2_next;
            }
        }
    }
}
// 1->2->3
// 4->5->6