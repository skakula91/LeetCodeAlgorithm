using System;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Number of Connected Components in an Undirected Graph
            //int[][] edges =  {new int[] { 0, 1 }, new int[] { 1, 2 }, new int[] { 3, 4 } };
            //int numberOfComponents = new NumberofConnectedCompGraph().CountComponents(5, edges);
            //Console.WriteLine(numberOfComponents);

            //2. Graph Valid Tree
            int[][] edges = { new int[] { 0, 1 }, new int[] { 0, 2 }, new int[] { 0, 3 }, new int[] { 1, 4 } };
            bool isValidTree = new GraphValidTree().ValidTree(5, edges);
            Console.WriteLine(isValidTree);
            Console.Read();
        }
    }
}
