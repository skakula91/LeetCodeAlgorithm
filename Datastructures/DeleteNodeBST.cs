using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures
{
    public class DeleteNodeBST
    {
        public BNode DeleteNode(BNode root, int key)
        {
            BNode curr = root;
            BNode prev = null;
            BNode child = null;
            BNode succ = null;
            while (curr != null)
            {
                if (curr.data == key)
                    break;
                else if (key < curr.data)
                {
                    prev = curr;
                    curr = curr.left;
                }
                else
                {
                    prev = curr;
                    curr = curr.right;
                }
            }

            //Key not found
            if (curr == null)
                return root;

            // If the deleted node is leaf node
            if (curr.left == null && curr.right == null)
            {
                if (prev == null)
                    return null;

                if (curr == prev.left)
                    prev.left = null;
                else
                    prev.right = null;
            }

            // If the deleted node has both right and left subtrees
            // Find successor of the key and copy it to the curr
            else if (curr.left != null && curr.right != null)
            {
                prev = curr;
                succ = curr.right;
                while (succ.left != null)
                {
                    prev = succ;
                    succ = succ.left;
                }
                curr.data = succ.data;

                if (prev.right == succ)
                {
                    prev.right = succ.right;
                }
                else
                {
                    prev.left = succ.right;
                }
            }

            // If the deleted node has only either right or left subtree
            else if (curr.left != null || curr.right != null)
            {
                if (curr.right != null)
                {
                    child = curr.right;
                }
                if (curr.left != null)
                {
                    child = curr.left;
                }

                // if root node itself is deleted
                if (prev == null)
                {
                    root = child;
                    return root;
                }

                if (curr == prev.left)
                    prev.left = child;
                else
                    prev.right = child;

            }
            
            return root;
        }
    }
}
