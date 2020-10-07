using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPart1
{
    public class LargestTimeFromDigits
    {
        public string LargestTime(int[] A)
        {
            string result = string.Empty;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        if (i == j || j == k || k == i)
                            continue;

                        string hh = $"{A[i]}{A[j]}";
                        string mm = $"{A[k]}{A[6 - i - j - k]}";
                        string time = $"{hh}:{mm}:00";
                        DateTime date = DateTime.Parse(time);
                        DateTime temp = DateTime.MinValue;
                        if(!string.IsNullOrEmpty(result))
                            temp = DateTime.Parse($"{result}:00", System.Globalization.CultureInfo.CurrentCulture);

                        if (Convert.ToInt32(hh) < 24 && Convert.ToInt32(mm) < 60 && (temp == DateTime.MinValue || date > temp))
                        {
                            result = $"{A[i]}{A[j]}:{A[k]}{A[6 - i - j - k]}";
                        }
                    }
                }
            }
            return result;
        }
    }
}
