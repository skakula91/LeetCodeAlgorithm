using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPart2
{
    public class TowersOfHanoii
    {
        public static void Towers(int disks, char src, char aux, char dest)
        {
            if(disks == 1)
            {
                Console.WriteLine("Disk moved from" + src + "to" + dest);
                return;
            }
            Towers(disks-1, src, dest, aux);
            Console.WriteLine("Disk moved from" + src + "to" + dest);
            Towers(disks - 1, aux, src, dest);
        }
    }
}
