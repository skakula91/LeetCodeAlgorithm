using System;
using System.Collections.Generic;
using System.Text;

namespace Graphs
{
    public class GravityMat
    {
        public void Matrix(char[][] matrix)
        {
            // How far figure will drop
            int maxdrop = GravityDrop(matrix);
            for (int i= matrix.Length-1; i >= 0; i--)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] != '#')
                    {
                        // if there are no obstacles at all
                        if (i - maxdrop < 0)
                        {
                            matrix[i][j] = '.';
                        }
                        if (i - maxdrop >= 0)
                        {
                            if (matrix[i - maxdrop][j] != '#')
                            {
                                matrix[i][j] = matrix[i - maxdrop][j];
                                matrix[i - maxdrop][j] = '.';
                            }
                            else
                            {
                                matrix[i][j] = '.';
                            }

                        }
                    }
                }
            }
        }

        public int GravityDrop(char[][] matrix)
        {
            int drop = matrix.Length - 1;
            for (int j = 0; j < matrix[0].Length; j++)
            {
                int obstaclePos = matrix.Length;
                int figurePos = 0;
                for (int i = 0; i < matrix.Length; i++)
                {
                    if (i <= obstaclePos)
                    {
                        if (matrix[i][j] == '#')
                        {
                            obstaclePos = Math.Min(obstaclePos, i);
                        }
                    }
                }

                drop = Math.Min(obstaclePos - figurePos - 1, drop);
            }

            return drop;
        }
    }
}
