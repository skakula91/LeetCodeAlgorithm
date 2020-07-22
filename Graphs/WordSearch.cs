using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public class WordSearch
    {
        public bool Exist(char[][] board, string word)
        {
            int rowLen = board.Length;
            int colLen = board[0].Length;
            bool result = false;
            var visited = new bool[rowLen, colLen];
            for (int i = 0; i < rowLen; i++)
            {
                for (int j = 0; j < colLen; j++)
                {
                    result = DFS(board, visited, i, j, word, 0);
                    if (result)
                        return result;
                }
            }
            return result;
        }
        public bool DFS(char[][] board, bool[,] visited, int x, int y, string word, int wordIndex)
        {
            if (wordIndex == word.Length)
                return true;
            if (x < 0 || y < 0 || x >= board.Length || y >= board[0].Length)
                return false;
            if (board[x][y] != word[wordIndex])
                return false;
            if (visited[x, y])
                return false;

            visited[x, y] = true;
            int[] delX = new int[] { 0, -1, 0, 1 };
            int[] delY = new int[] { -1, 0, 1, 0 };
            for (int i = 0; i < delX.Length; i++)
            {
                var result = DFS(board, visited, x + delX[i], y + delY[i], word, wordIndex + 1);
                if (result)
                    return result;

            }
            visited[x, y] = false;

            return false;
        }
    }
}
