﻿using System;
using System.Collections.Generic;

namespace Datastructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //BNode bnode = null;
            //BinaryTree bTree = new BinaryTree();
            //bnode = bTree.Insert(bnode, 4);
            //bnode = bTree.Insert(bnode, 2);
            //bnode = bTree.Insert(bnode, 1);
            //bnode = bTree.Insert(bnode, 3);
            //bnode = bTree.Insert(bnode, 5);

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
            //var dia = new DiameterBinaryTree().DiameterOfBinaryTree(bnode);
            //Console.WriteLine(dia);

            //7. Count Univalue Subtrees
            //var univalCount = new IsUnivalBTree().CountUnivalSubtrees(bnode);
            // Console.WriteLine(univalCount);

            //8. Construct Binary Tree from Preorder and Inorder Traversal
            //int[] preorder = { 3, 9, 20, 15, 7 };
            //int[] inorder = { 9, 3, 15, 20, 7 };
            //var node = new ConstructBinaryTree().BuildTree(preorder, inorder);

            //9. LRU cache
            //LRUPractice cache = new LRUPractice(2);

            //cache.Put(1, 1);
            //cache.Put(2, 2);
            //Console.WriteLine(cache.Get(1));       // returns 1
            //cache.Put(3, 3);    // evicts key 2
            //Console.WriteLine(cache.Get(2));       // returns -1 (not found)
            //cache.Put(4, 4);    // evicts key 1
            //Console.WriteLine(cache.Get(1));       // returns -1 (not found)
            //Console.WriteLine(cache.Get(3));       // returns 3
            //Console.WriteLine(cache.Get(4));


            // 10. Reverse a Linked List
            //ListNode lstNode = null;
            //LinkedList linkedList = new LinkedList();
            //lstNode = linkedList.Insert(lstNode, 1);
            //lstNode = linkedList.Insert(lstNode, 2);
            //lstNode = linkedList.Insert(lstNode, 4);
            //var lstNodeResult = new ReverseLinkedList().Reverse(lstNode);
            //while (lstNodeResult != null)
            //{
            //    Console.WriteLine(lstNodeResult.val);
            //    lstNodeResult = lstNodeResult.next;
            //}


            // 11. Reorder List
            //ListNode lstNode = null;
            //LinkedList linkedList = new LinkedList();
            //lstNode = linkedList.Insert(lstNode, 1);
            //lstNode = linkedList.Insert(lstNode, 2);
            //lstNode = linkedList.Insert(lstNode, 3);
            //lstNode = linkedList.Insert(lstNode, 4);
            ////lstNode = linkedList.Insert(lstNode, 5);
            ////lstNode = linkedList.Insert(lstNode, 6);
            //new ReorderList().Reorder(lstNode);
            //while (lstNode != null)
            //{
            //    Console.WriteLine(lstNode.val);
            //    lstNode = lstNode.next;
            //}


            //12. Delete Node in a BST
            //BNode bnode = null;
            //BinaryTree bTree = new BinaryTree();
            //bnode = bTree.Insert(bnode, 1);
            //bnode = bTree.Insert(bnode, 2);
            //var result = new DeleteNodeBST().DeleteNode(bnode, 1);

            //13. Unique Binary Search Trees II
            //var result = new UniquePathsII().GenerateTrees(3);

            // 14. Odd Even Linked List
            //ListNode lstNode = null;
            //LinkedList linkedList = new LinkedList();
            //lstNode = linkedList.Insert(lstNode, 1);
            //lstNode = linkedList.Insert(lstNode, 2);
            //lstNode = linkedList.Insert(lstNode, 3);
            //lstNode = linkedList.Insert(lstNode, 4);
            //lstNode = linkedList.Insert(lstNode, 5);
            //lstNode = linkedList.Insert(lstNode, 6);
            //var lstNodeResult = new OddEvenList().OddEven(lstNode);
            //while (lstNodeResult != null)
            //{
            //    Console.WriteLine(lstNodeResult.val);
            //    lstNodeResult = lstNodeResult.next;
            //}

            // 15.IPO
            //int[] profits = { 1, 2, 3 };
            //int[] capital = { 0, 1, 1 };
            //var result = new IPO().FindMaximizedCapital(2,0,profits,capital);

            // 16.The Skyline Problem
            int[][] buildings = { new int[] { 2, 9,10 }, new int[] { 3, 7 ,15 }, new int[] { 5, 12, 12 }, new int[] { 15, 20 ,10 }, new int[] { 19 ,24 ,8 } };
            var result = new TheSkyLineProblem().GetSkyline(buildings);
            Console.ReadKey();
        }
    }
}
