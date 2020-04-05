using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures
{
    public class DiameterBinaryTree
    {
        public int result = 0;
        public int DiameterOfBinaryTree(BNode root)
        {
            if (root == null)
                return 0;

            Diameter(root);
            return result;
        }
        public int Diameter(BNode root)
        {
            int diameter = 0;
            int rightHeight = 0;
            int leftHeight = 0;
            if (root.left == null && root.right == null)
                return 0;

            if (root.left != null)
            {
                leftHeight = Diameter(root.left);
                diameter = diameter + leftHeight + 1;
            }
            if (root.right != null)
            {
                rightHeight = Diameter(root.right);
                diameter = diameter + rightHeight + 1;
            }
            result = Math.Max(result, diameter);

            return Math.Max(leftHeight, rightHeight) + 1;
        }

    }
}
