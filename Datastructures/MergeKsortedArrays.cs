using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datastructures
{
    public class MergeKsortedArrays
    {
        public static ListNode MergeKLists(ListNode[] lists)
        {
            var fakehead = new ListNode(0);
            var lst = fakehead;
            SortedDictionary<int, List<ListNode>> sortedDist = new SortedDictionary<int, List<ListNode>>();
            foreach(var list in lists)
            {
                if (list != null)
                {
                    if (sortedDist.ContainsKey(list.val))
                    {
                        sortedDist[list.val].Add(list);
                    }
                    else
                    {
                        sortedDist.Add(list.val, new List<ListNode> { list });
                    }
                }
            }
            while(sortedDist.Any())
            {
                var top = sortedDist.First();
                var minnode = top.Value[0];

                lst.next = minnode;
                lst = lst.next;
                
                if (top.Value.Count == 1)
                {
                    sortedDist.Remove(minnode.val);
                }
                else
                {
                    top.Value.RemoveAt(0);
                }
                if (minnode.next != null)
                    {
                    if (sortedDist.ContainsKey(minnode.next.val))
                    {
                        sortedDist[minnode.next.val].Add(minnode.next);
                    }
                    else
                    {
                        sortedDist.Add(minnode.next.val, new List<ListNode> { minnode.next });
                    }
                }

            }

            return fakehead.next;
        }
    }
}
