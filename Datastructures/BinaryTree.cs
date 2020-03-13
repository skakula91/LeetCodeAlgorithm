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
            else if (data <= root.data)
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
        // Traversals:
        // InOrder
        public void InOrder(BNode root)
        {
            if (root == null)
                return;
            InOrder(root.left);
            Console.WriteLine(root.data);
            InOrder(root.right);
        }

        // PreOrder
        public void PreOrder(BNode root)
        {
            if (root == null)
                return;
            Console.WriteLine(root.data);
            PreOrder(root.left);
            PreOrder(root.right);
        }

        // PostOrder
        public void PostOrder(BNode root)
        {
            if (root == null)
                return;
            PostOrder(root.left);
            PostOrder(root.right);
            Console.WriteLine(root.data);
        }

        // Find min element of binaryTree
        public int MinElement(BNode root)
        {
            while (root.left != null)
            {
                root = root.left;
            }
            return root.data;
        }

        // Find max element of binaryTree
        public int MaxElement(BNode root)
        {
            while (root.right != null)
            {
                root = root.right;
            }
            return root.data;
        }

        // Mirror Binary tree
        public BNode Mirror(BNode root, BNode mirrorNode)
        {
            if (root != null)
            {
                mirrorNode = InsertMirror(mirrorNode, root.data);
                Mirror(root.left, mirrorNode);
                Mirror(root.right, mirrorNode);
            }
            return mirrorNode;
        }

        public BNode InsertMirror(BNode root, int data)
        {
            if (root == null)
            {
                root = GetNewNode(data);
            }
            else if (data >= root.data)
            {
                root.left = InsertMirror(root.left, data);
            }
            else
            {
                root.right = InsertMirror(root.right, data);
            }
            return root;


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
