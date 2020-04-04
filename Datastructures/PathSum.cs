using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures
{
    public class PathSum
    {
        public bool result = false;
        public bool HasPathSum(BNode root, int sum)
        {
            if (root == null)
                return false;

            Helper(root, sum);
            return result;
        }
        private void Helper(BNode root, int sum)
        {
            //Base case
            if (root.left == null && root.right == null)
            {
                if (sum == root.data)
                {
                    result = true;
                }
                return;
            }
            //Recursion
            if (root.left != null)
                Helper(root.left, sum - root.data);
            if (root.right != null)
                Helper(root.right, sum - root.data);
        }
    }
}
