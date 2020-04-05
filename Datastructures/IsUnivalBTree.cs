using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures
{
    public class IsUnivalBTree
    {
        public int count = 0;
        public int CountUnivalSubtrees(BNode root)
        {
            if (root == null)
                return 0;

            IsUnival(root);
            return count;
        }
        private bool IsUnival(BNode node)
        {
            //Base
            if (node.left == null && node.right == null)
            {
                count = count + 1;
                return true;
            }

            bool isUnival = true;
            if (node.left != null)
            {
                bool bl = IsUnival(node.left);
                if (bl == false || node.data != node.left.data)
                {
                    isUnival = false;
                }
            }
            if (node.right != null)
            {
                bool br = IsUnival(node.right);
                if (br == false || node.data != node.right.data)
                {
                    isUnival = false;
                }
            }

            if (isUnival)
                count = count + 1;

            return isUnival;

        }
    }
}
