using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPart1
{
    class BinaryConvert
    {
        public void Convert1(int a)
        {
            for (int i = 4; i >= 0; i--)
            {
                Console.Write(a >> i);
                int bit = (a >> i) & 1;
                Console.WriteLine(bit);
                Console.WriteLine(Convert.ToString(a, 2));
            }
        }
    }
}
