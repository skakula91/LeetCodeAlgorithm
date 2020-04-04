using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures
{
    public class PathSumII
    {
        public List<IList<int>> result = new List<IList<int>>();
        public IList<IList<int>> PathSum(BNode root, int sum)
        {
            if (root != null)
                Helper(root, sum, new List<int>());

            return result;
        }

        private void Helper(BNode root, int sum, List<int> slate)
        {
            if (root.left == null && root.right == null)
            {
                if (root.data == sum)
                {
                    slate.Add(root.data);
                    result.Add(new List<int>(slate));
                    slate.RemoveAt(slate.Count - 1);
                }
                return;
            }

            //Recursion
            slate.Add(root.data);
            if (root.left != null)
            {
                Helper(root.left, sum - root.data, slate);
            }
            if (root.right != null)
            {
                Helper(root.right, sum - root.data, slate);
            }
            slate.RemoveAt(slate.Count - 1);
        }

    }
}
