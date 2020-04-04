using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmPart2
{
    public class NQueen
    {
        public List<IList<string>> result = new List<IList<string>>();
        public IList<IList<string>> SolveNQueens(int n)
        {
            SolveQueens(n,0,new List<int>());
            return result;
        }
        public void SolveQueens(int n, int row, List<int> positions)
        {
            if (n == row)
            {
                List<string> ans = new List<string>();
                foreach(var pos in positions)
                {
                    ans.Add(Buildstr(pos, n));
                }
                result.Add(ans);
            }
            else
            {
                for (int col = 0; col < n; col++)
                {
                    positions.Add(col);
                    if (IsValidPlacement(positions,col,row))
                    {                      
                        SolveQueens(n, row + 1, positions);                    
                    }
                    positions.RemoveAt(positions.Count - 1);
                }
            }

        }
        private bool IsValidPlacement(List<int> positions, int col, int row)
        {
            for(int i = 0; i < positions.Count-1; i++)
            {
                //check column
                if (positions[i] == col)
                {
                    return false;
                }
                // check diag
                if(i+positions[i] == col+row ||  positions[i] -i == col - row)
                {
                    return false;
                }
            }
            return true;
        }
        private string Buildstr(int column, int n)
        {
            StringBuilder sb = new StringBuilder(string.Concat(Enumerable.Repeat(".", n)));
            sb.Remove(column, 1);
            return sb.Insert(column, 'Q').ToString();
        }
    }
}
