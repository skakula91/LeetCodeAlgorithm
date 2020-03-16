using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures
{
    public class LinkedList
    {
        public ListNode Insert(ListNode root, int data)
        { 
            if(root == null)
            {
                var node = new ListNode(data);
                node.next = null;
                root = node;
            }
            else if(root != null && root.val > data)
            {
                ListNode temp = root;
                var node = new ListNode(data);
                node.next = root;
                root = node;
            }
            else
            {
                if (root.next == null ||  root.next.val <= data)
                {
                    root.next = Insert(root.next, data);
                }
                else
                {
                    ListNode temp = root.next;
                    root.next = new ListNode(data);
                    root.next.next = temp;
                }
            }

            return root;
        }

        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null)
                return head;
            var curr = new ListNode(0);
            curr.next = head;
            var pre = curr;
            while (pre != null)
            {
                if (pre.next != null && pre.next.val == val)
                {
                    pre.next = pre.next.next;
                }
                pre = pre.next;
            }
            return curr.next;

        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}
