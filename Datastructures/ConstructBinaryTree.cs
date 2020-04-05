using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures
{
    public class ConstructBinaryTree
    {
        Dictionary<int, int> indexDict = new Dictionary<int, int>();
        public BNode BuildTree(int[] preorder, int[] inorder)
        {
            for (int i = 0; i < inorder.Length; i++)
            {
                indexDict.Add(inorder[i], i);
            }

            return Helper(preorder, 0, preorder.Length - 1, inorder, 0, inorder.Length - 1);
        }
        public BNode Helper(int[] preorder, int startp, int endp, int[] inorder, int starti, int endi)
        {
            if (startp > endp || starti > endi)
                return null;

            if (startp == endp)
                return new BNode(preorder[startp]);

            BNode root = new BNode(preorder[startp]);

            var index = indexDict[root.data];
            var numsleft = index - starti;
            var numsright = endi - index;

            root.left = Helper(preorder, startp + 1, startp + numsleft, inorder, starti, index - 1);
            root.right = Helper(preorder, startp + numsleft+1, endp, inorder, index + 1, endi);

            return root;
        }
    }
}
