﻿using System;
using System.Linq;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Number of Connected Components in an Undirected Graph
            //int[][] edges = { new int[] { 0, 1 }, new int[] { 1, 2 }, new int[] { 3, 4 } };
            //int numberOfComponents = new ConnectedComponents().CountComponents(5, edges);
            //Console.WriteLine(numberOfComponents);

            //2. Graph Valid Tree
            //int[][] edges = { new int[] { 0, 1 }, new int[] { 0, 2 }, new int[] { 0, 3 }, new int[] { 1, 4 } };
            //bool isValidTree = new GraphValidTree().ValidTree(5, edges);
            //Console.WriteLine(isValidTree);

            //3. Is Bipartite Graph
            //int[][] adjacencyList = { new int[] { 1, 3 }, new int[] { 0, 2 }, new int[] { 1, 3 }, new int[] { 0, 2 } };
            //bool isBipartiteGraph = new IsBipartite().IsBipartiteGraph(adjacencyList);
            //Console.WriteLine(isBipartiteGraph);

            //4. Number of Islands
            //char[][] grid = { new char[] { '1', '1','0','0','0' }, new char[] { '1', '1','0', '0', '0' }, new char[] { '0', '0', '1', '0','0' }, new char[] { '0', '0', '0', '1','1' } };
            ////char[][] grid = { new char[] { '1' }, new char[] { '1' } };
            //int islandCount = new NumberOfIslands().NumIslands(grid);
            //Console.WriteLine(islandCount);

            //5. Course Schedule
            //int[][] edges = { new int[] { 1, 0 }, new int[] { 0, 1 } };
            //bool canGetdegree = new CourseSchedule().CanFinish(2, edges);
            //Console.WriteLine(canGetdegree);

            //6. Critical Connections in a Network
            //int[][] edges = { new int[] { 1, 0 }, new int[] { 1, 2} ,new int[] { 2, 0 }, new int[] { 1, 3 } };
            //var criticalConnections = new CriticalConnections().CriticalConnectionsNetwork(4, edges);

            //7. Alien Dictionary
            //string[] words = {"abc",
            //    "ab"};
            //var order = new AlienDictionary().AlienOrder(words);
            //Console.WriteLine(order);

            //8. Eulerian Cycle - every vertex has a even degree
            // Eulerian Path - oddVertex == 0 || oddVertex == 2 -- every eulerian cycle is a eulerian path
            //int[][] edges =  {new int[] { 0, 1 }, new int[] { 0, 5 }, new int[] { 1, 5 },  new int[] { 0, 2 }, new int[] { 1, 3 }, new int[] { 2, 4 }, new int[] { 3, 4 } , new int[] { 0, 3 } , new int[] { 1, 2 }, new int[] { 2, 3} };
            //bool isEulerian = new HasEulerianCycle().Components(6, edges);
            //Console.WriteLine(isEulerian);

            //9. Number of pairs
            //string s = "11111111111111111111111111111111100001001";
            //long pairs = new NumberOfPairs().NumSub(s);
            //Console.WriteLine(pairs);

            //10. Minimum Knight Moves
            //int moves = new MinimumKnightMoves().MinKnightMoves(0,1);
            //Console.WriteLine(moves);

            //11. Word search
            //char[][] board = { new char[] { 'A', 'B', 'C', 'E' }, new char[] { 'S', 'F', 'C', 'S' }, new char[] { 'A', 'D', 'E', 'E' } };
            //char[][] board = { new char[] { 'A', 'B' } };
            //bool doesExist = new WordSearch().Exist(board, "SEE");
            //Console.WriteLine(doesExist);

            //12. Friend circles
            //int[][] M = { new int[] { 1,1,0}, new int[] {1,1,0 }, new int[] {0,0,1} };
            //int circles = new FriendCircle().FindCircleNum(M);
            //Console.WriteLine(circles);

            //13. All Paths From Source to Target
            //int[][] graph = { new int[] { 1,2}, new int[] {3 }, new int[] {3}, new int[] {}};
            //var lst = new AllPathSourcetoTarget().AllPathsSourceTarget(graph);

            //14. Rotten oranges
            //int[][] M = { new int[] {2,1,1}, new int[] {1,1,0 }, new int[] {0,1,1} };
            //int time = new RottenOranges().OrangesRotting(M);
            //Console.WriteLine(time);

            //15. Largest Component Size by Common Factor
            //int[] A = new int[] { 20, 50, 9, 63};
            //int components = new LargestComponenet().LargestComponentSize(A);
            //Console.WriteLine(components);

            //16. Word Ladder II
            //string beginWord = "hit";
            //string endWord = "cog";
            //string[] wordList = new string[] { "hot", "dot", "dog", "lot", "log", "cog" };
            //var result = new WordLadderII().FindLadders(beginWord,endWord,wordList.ToList());

            // 17.Gravity
            // . is empty space, # is obstacle, F is figure
            //char[][] board = {  new char[] { 'F', 'F', 'F'},
            //                    new char[] { '.', 'F', '.'},
            //                    new char[] { '.', 'F', 'F'},
            //                    new char[] { '#', 'F', '.'},
            //                    new char[] { 'F', 'F', '.'},
            //                    new char[] { '.', '.', '.'},
            //                    new char[] { '.', '.', '#'},
            //                    new char[] { '.', '.', '.'}};
            // new GravityMat().Matrix(board);
            //Console.WriteLine(doesExist);

            // 18. Connections
            //int[][] connections = {  new int[] {0,1,1},
            //                    new int[] { 1,2,4},
            //                    new int[] { 1,3,6},
            //                    new int[] { 3, 4, 5},
            //                    new int[]{2,4,1 }};
            //var result = new KruskalMST().MSTKruskal(5, connections);

            // 19. Shortest Bridge
            //int[][] M = { new int[] { 0,1 }, new int[] { 1, 0 }};
            // var result = new ShortestBridge().ShortestBridgeI(M);

            // 20.Number of Islands II
            int[][] M = { new int[] { 0,0 }, new int[] { 0, 1 }, new int[] { 1, 2 } , new int[] { 1, 2 } };
            var result = new NumberofIslandsII().NumIslands2(3,3,M);
            Console.Read();
        }
    }
}
