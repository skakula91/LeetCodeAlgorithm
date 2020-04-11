﻿using System;

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
            //int[][] edges = { new int[] { 0, 1 }, new int[] { 0, 2 }, new int[] { 0, 3 }, new int[] { 1, 4 } };
            //bool isValidTree = new GraphValidTree().ValidTree(5, edges);
            //Console.WriteLine(isValidTree);

            //3. Graph Valid Tree
            //int[][] adjacencyList = { new int[] { 1, 3 }, new int[] { 0, 2 }, new int[] { 1, 3 }, new int[] { 0, 2 } };
            //bool isBipartiteGraph = new IsBipartite().IsBipartiteGraph(adjacencyList);
            //Console.WriteLine(isBipartiteGraph);

            //4. Number of Islands
            char[][] grid = { new char[] { '1', '1','0','0','0' }, new char[] { '1', '1','0', '0', '0' }, new char[] { '0', '0', '1', '0','0' }, new char[] { '0', '0', '0', '1','1' } };
            //char[][] grid = { new char[] { '1' }, new char[] { '1' } };
            int islandCount = new NumberOfIslands().NumIslands(grid);
            Console.WriteLine(islandCount);
            Console.Read();
        }
    }
}
