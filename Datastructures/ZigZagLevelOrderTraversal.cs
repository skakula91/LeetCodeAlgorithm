using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures
{
    public class ZigZagLevelOrderTraversal
    {
        public IList<IList<int>> ZigzagLevelOrder(BNode root)
        {
            if (root == null)
                return new List<IList<int>>();

            return Helper(root);
        }
        public IList<IList<int>> Helper(BNode root)
        {
            List<IList<int>> result = new List<IList<int>>();
            Queue<BNode> q = new Queue<BNode>();
            q.Enqueue(root);
            bool isReverse = false;
            while (q.Count != 0)
            {
                int qlen = q.Count;
                var temp = new List<int>();
                for (int i = 0; i < qlen; i++)
                {
                    var node = q.Dequeue();
                    temp.Add(node.data);
                    if (node.left != null)
                        q.Enqueue(node.left);
                    if (node.right != null)
                        q.Enqueue(node.right);
                }
                if (isReverse)
                {
                    temp.Reverse();
                    result.Add(new List<int>(temp));
                    isReverse = false;
                }
                else
                {
                    result.Add(new List<int>(temp));
                    isReverse = true;
                }
            }
            return result;
        }
    }


}
