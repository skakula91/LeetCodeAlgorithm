using System;

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
            bTree.PreOrder(bnode);
            BNode mirrorNode = null;
            mirrorNode = bTree.Mirror(bnode,mirrorNode);
            bTree.PreOrder(mirrorNode);
            Console.ReadKey();
        }
    }
}
