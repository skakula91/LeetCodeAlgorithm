using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures
{
    public class LevelOrderTraversal
    {      
        public List<int> Traverse(BNode root)
        {
            if (root == null)
                return null;

            return BFS(root);
        }

        public List<int> BFS(BNode root)
        {
            List<int> result = new List<int>();
            Queue<BNode> q = new Queue<BNode>();
            q.Enqueue(root);
            while(q.Count != 0)
            {
                var node = q.Dequeue();
                result.Add(node.data);
                if (node.left != null)
                    q.Enqueue(node.left);
                if (node.right != null)
                    q.Enqueue(node.right);
            }
            return result;
        }
    }
}
