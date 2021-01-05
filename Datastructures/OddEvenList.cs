using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures
{
    public class OddEvenList
    {
        public ListNode OddEven(ListNode head)
        {
            ListNode curr = head;
            ListNode prev = null;
            while (curr != null)
            {
                prev = curr;
                if (curr.val % 2 == 0)
                {
                    break;
                }
                curr = curr.next;
            }
            if (curr == null)
                return head;

            ListNode next = curr.next;

            while (next != null)
            {
                Console.WriteLine(next.val);
                if (next.val % 2 != 0)
                {
                    var tempnext = next.next;
                    prev.next = next;
                    next.next = curr;
                    


                }
                else
                {
                    next = next.next;
                }

            }

            return head;
        }
    }
}
