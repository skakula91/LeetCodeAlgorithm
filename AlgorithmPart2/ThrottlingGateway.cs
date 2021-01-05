using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace AlgorithmPart2
{
    public class ThrottlingGateway
    {
        public static int MAX_PER_SECOND = 3;
        public static int MAX_TEN_SECONDS = 20;
        public static int MAX_PER_MINUTE = 60;
        public int DroppedConnections(int[] requestTime)
        {
            if (requestTime == null || requestTime.Length == 0)
                return 0;

            int drop = 0;
            Dictionary<int,int> dict = new Dictionary<int, int>();
            int lastReqTime = 0;

            for (int i = 0; i < requestTime.Length; i++)
            {
                int temp = 0;
                if (dict.ContainsKey(requestTime[i]))
                {
                    temp = dict[requestTime[i]];
                    dict[requestTime[i]] = temp + 1;
                }
                else
                {
                    dict.Add(requestTime[i], temp + 1);
                }

                lastReqTime = Math.Max(lastReqTime, requestTime[i]);
            }
            int[] nums = new int[lastReqTime + 1];
            for (int i = 1; i < nums.Length; ++i)
            {
                int temp = 0;
                if (dict.ContainsKey(i))
                {
                    temp = dict[i];
                }
                int numReqThisSecond = temp;
                nums[i] = nums[i - 1] + numReqThisSecond;
                if (numReqThisSecond == 0)
                {
                    continue;
                }
                int toDrop = 0;
                if (numReqThisSecond > MAX_PER_SECOND)
                {
                    toDrop = Math.Max(toDrop, numReqThisSecond - MAX_PER_SECOND);
                }

                int timeTenSecondsAgo = Math.Max(i - 10, 0);
                int numReqPastTenSecond = nums[i] - nums[timeTenSecondsAgo];
                if (numReqPastTenSecond > MAX_TEN_SECONDS)
                {
                    int numReqExceeded = Math.Min(numReqThisSecond, numReqPastTenSecond - MAX_TEN_SECONDS);
                    toDrop = Math.Max(toDrop, numReqExceeded);
                }

                int timeOneMinuteAgo = Math.Max(i - 60, 0);
                int numReqPastMinute = nums[i] - nums[timeOneMinuteAgo];
                if (numReqPastMinute > MAX_PER_MINUTE)
                {
                    int numReqExceeded = Math.Min(numReqThisSecond, numReqPastMinute - MAX_PER_MINUTE);
                    toDrop = Math.Max(toDrop, numReqExceeded);
                }
                drop += toDrop;
            }
            return drop;




            //int n = requestTime.Length;

            //if (n == 0)
            //    return n;

            //int result = 0;
            //int count = 1;
            //for (int i = 1; i < requestTime.Length; i++)
            //{
            //    if (requestTime[i - 1] == requestTime[i])
            //    {
            //        count++;
            //        if (count > 3)
            //        {
            //            result++;
            //            continue;
            //        }
            //    }
            //    else
            //    {
            //        count = 1;
            //    }

            //    if (i >= 20 && requestTime[i] - requestTime[i-20] < 10)
            //    {
            //        result++;
            //    }
            //    else if(i >= 60 && requestTime[i] - requestTime[i-60] < 60)
            //    {
            //        result++;
            //    }
            //}

           // return result;
        }
    }
}
