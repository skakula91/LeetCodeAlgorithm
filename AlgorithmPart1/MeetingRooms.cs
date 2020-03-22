using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlgorithmPart1
{
    public class MeetingRooms
    {
        public static bool CanAttendMeetings(int[][] intervals)
        {
            // Array.Sort(intervals, (a, b) => b[0] - b[0]);
            intervals = intervals.OrderBy(x => x[0]).ToArray();

            for (int i = 0; i< intervals.Length - 1; i++)
            {
                if (intervals[i + 1][0] < intervals[i][1])
                    return false;
            }
            return true;
        }
    }
}
