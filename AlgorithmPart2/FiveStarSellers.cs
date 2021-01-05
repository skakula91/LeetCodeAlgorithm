using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmPart2
{
    public class FiveStarSellers
    {
        public SortedDictionary<double, List<int>> dict = new SortedDictionary<double, List<int>>(Comparer<double>.Create((x, y) => y.CompareTo(x)));
        public int Solve(int[][] productRatings, int threshold)
        {
            int result = 0;
            for (int i = 0 ; i < productRatings.Length; i++)
            {
                Difference(productRatings[i], i);
            }

            double currRating = 0;
            foreach (var rating in productRatings)
            {
                currRating += (rating[0]*1.0* 100) / rating[1];
            }

            while (currRating < threshold*productRatings.Length)
            {
                result++;
                (double, int) val = GetVal();
                currRating = currRating + val.Item1;
                Remove(val.Item1);
                productRatings[val.Item2][0]++;
                productRatings[val.Item2][1]++;
                Difference(productRatings[val.Item2], val.Item2);
            }


            return result;
        }

        public (double,int) GetVal()
        {
            var val = dict.First().Key;
            var index = dict.First().Value[0];
            return (val, index);
        }

        public void Difference(int[] rating, int index)
        {
            double oldval = (rating[0] * 1.0 * 100) / (rating[1]);
            double newval = ((rating[0]+1) * 1.0 * 100) / (rating[1]+1);
            double diff = newval - oldval;
            Add(diff,index);
        }

        public void Add(double value, int index)
        {
            if (!dict.ContainsKey(value))
            {
                dict.Add(value,new List<int>{index});
            }
            else
            {
                dict[value].Add(index);
            }
        }

        public void Remove(double value)
        {
            if (dict[value].Count > 1)
            {
                dict[value].RemoveAt(0);
            }
            else
            {
                dict.Remove(value);
            }
        }
    }
}
