using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace AlgorithmPart2
{
    public class UtilizationChecks
    {
        public static int solution(int instances, List<int> utilizationUtil)
        {
            int limit = 2 * 100000000;
            int pastUtl = Int32.MaxValue;
            for (int i = 1; i < utilizationUtil.Count; i++)
            {
                if (utilizationUtil[i] < 25 && instances > 1)
                {
                    instances = (int) Math.Ceiling(instances * 1.0 / 2);
                    i += 10;
                }
                else if(utilizationUtil[i] > 65)
                {
                    int temp = instances * 2;
                    if (temp <= limit)
                    {
                        instances = temp;
                    }

                    i += 10;
                }
            }

            return instances;
        }
    }
}
