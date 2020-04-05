using System;
using System.Collections.Generic;

namespace Datastructures
{
    class Program
    {
        static void Main(string[] args)
        {
            BNode bnode = null;
            BinaryTree bTree = new BinaryTree();
            bnode = bTree.Insert(bnode, 4);
            bnode = bTree.Insert(bnode, 2);
            bnode = bTree.Insert(bnode, 1);
            bnode = bTree.Insert(bnode, 3);
            bnode = bTree.Insert(bnode, 5);

            //bool isAvailable = bTree.Search(bnode, 22);
            //if (isAvailable)
            //    Console.WriteLine("Matching element found");
            //else
            //    Console.WriteLine("Matching element not found");

            //Traversal
            //bTree.InOrder(bnode);
            //bTree.PreOrder(bnode);
            //bTree.PostOrder(bnode);

            //min element
            // int value = bTree.MinElement(bnode);
            // int value = bTree.MaxElement(bnode);
            //Console.WriteLine(value);

            // Mirror Binary tree
            // bTree.PreOrder(bnode);
            // BNode mirrorNode = null;
            // mirrorNode = bTree.Mirror(bnode,mirrorNode);
            // bTree.PreOrder(mirrorNode);

            //ListNode lstNode = null;
            //LinkedList linkedList = new LinkedList();
            //lstNode = linkedList.Insert(lstNode, 4);
            //lstNode = linkedList.Insert(lstNode, 2);
            //lstNode = linkedList.Insert(lstNode, 1);

            //ListNode lstNode2 = null;
            //lstNode2 = linkedList.Insert(lstNode2, 3);
            //lstNode2 = linkedList.Insert(lstNode2, 5);
            //lstNode2 = linkedList.Insert(lstNode2, 1);

            //ListNode lstNode3 = null;
            //lstNode3 = linkedList.Insert(lstNode3, 2);
            //lstNode3 = linkedList.Insert(lstNode3, 6);
            //lstNode3 = linkedList.Insert(lstNode3, 1);

            ////lstNode = linkedList.RemoveElements(lstNode,1);
            //List<ListNode> lst = new List<ListNode>();
            //lst.Add(lstNode);
            //lst.Add(lstNode2);
            //lst.Add(lstNode3);

            //var sortedLstNode = MergeKsortedArrays.MergeKLists(lst.ToArray());

            //while (sortedLstNode != null)
            //{
            //    Console.WriteLine(sortedLstNode.val);
            //    sortedLstNode = sortedLstNode.next;
            //}

            //var height = bTree.FindHeight(bnode);
            //Console.WriteLine(height);

            //Level Order Traversal
            //var result = new LevelOrderTraversal().Traverse(bnode);
            //foreach(int i in result)
            //{
            //    Console.WriteLine(i);
            //}

            //1. Binary Tree Level Order Traversal 
            //var result = new LevelOrderTraversalI().Traverse(bnode);

            //2. Binary Tree Zigzag Level Order Traversal
            //var result = new ZigZagLevelOrderTraversal().ZigzagLevelOrder(bnode);

            ////3. Path Sum
            //var foundPath = new PathSum().HasPathSum(bnode,9);
            //Console.WriteLine(foundPath);

            //4. Path Sum II
            //var path = new PathSumII().PathSum(bnode, 9);

            //5. Is valid Binary tree
            //var isValid = new ValidBinaryTree().IsValidBST(bnode);
            //Console.WriteLine(isValid);

            //6. Diameter of Binary Tree
            var dia = new DiameterBinaryTree().DiameterOfBinaryTree(bnode);
            Console.WriteLine(dia);

            Console.ReadKey();
        }
    }
}
