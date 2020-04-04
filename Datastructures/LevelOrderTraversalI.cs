using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures
{
    public class LevelOrderTraversalI
    {       
        public List<IList<int>> Traverse(BNode root)
        {
            if (root == null)
                return null;

            return BFS(root);
        }

        public List<IList<int>> BFS(BNode root)
        {
           List<IList<int>> result = new List<IList<int>>();
            Queue<BNode> q = new Queue<BNode>();
            q.Enqueue(root);
            while(q.Count != 0)
            {
                int qLen = q.Count;
                var temp = new List<int>();
                for (int i = 0; i < qLen; i++)
                {
                    var node = q.Dequeue();
                    temp.Add(node.data);
                    if (node.left != null)
                        q.Enqueue(node.left);
                    if (node.right != null)
                        q.Enqueue(node.right);
                }
                result.Add(new List<int>(temp));
            }

            return result;
        }
    }
}
