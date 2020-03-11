using System;

namespace Datastructures
{
    class Program
    {
        static void Main(string[] args)
        {
            BNode bnode = null;
            BinaryTree bTree = new BinaryTree();
            bnode =  bTree.Insert(bnode, 1);
            bnode = bTree.Insert(bnode, 10);
            bnode = bTree.Insert(bnode, 15);
            bnode = bTree.Insert(bnode, 2);
            bnode = bTree.Insert(bnode, 45);
            bnode = bTree.Insert(bnode, 32);

            bool isAvailable = bTree.Search(bnode, 22);
            if (isAvailable)
                Console.WriteLine("Matching element found");
            else
                Console.WriteLine("Matching element not found");

            Console.ReadKey();
        }
    }
}
