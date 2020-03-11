using System;
using System.Collections.Generic;
using System.Text;

namespace Datastructures
{
    class BinaryTree
    {
        public BNode GetNewNode(int data)
        {
            BNode newBnode = new BNode(data);
            newBnode.left = null;
            newBnode.right = null;
            return newBnode;
        }
        public BNode Insert(BNode root, int data)
        {
            if (root == null)
            {
                root = GetNewNode(data);              
            }
            else if(data <= root.data)
            {
                root.left = Insert(root.left, data);
            }
            else
            {
                root.right = Insert(root.right, data);
            }
            return root;
        }

        public bool Search(BNode root, int data)
        {
            if (root == null)
                return false;
            else if (root.data == data)
                return true;
            else if (root.data >= data) 
                return Search(root.left, data);
            else
                return Search(root.right, data);
        }
    }

    public class BNode
    {
        public int data;
        public BNode right;
        public BNode left;

        public BNode(int x)
        {
            data = x;
        }
    }
}
