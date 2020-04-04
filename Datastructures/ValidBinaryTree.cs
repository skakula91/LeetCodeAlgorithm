using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures
{
    public class ValidBinaryTree
    {
        public bool IsValidBST(BNode root)
        {
            return Helper(root, int.MinValue, int.MaxValue);
        }
        public bool Helper(BNode node, long min, long max)
        {
            if (node == null)
                return true;

            if (node.data > min && node.data < max)
            {
                var left = Helper(node.left, min, node.data);
                var right = Helper(node.right, node.data, max);
                return left && right;
            }

            return false;
        }
    }
}
