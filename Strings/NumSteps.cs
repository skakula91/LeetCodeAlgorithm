using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    public class NumSteps
    {
        public int Steps(string s)
        {
            if (s == null)
                return 0;

            int count = 0;
            int carry = 0;
            for (int i = s.Length - 1; i > 0; --i)
            {
                if (s[i] - '0' + carry == 1)
                {
                    count++;
                    carry = s[i] - '0' + carry;
                }
                count++;
            }

            return count + carry;
        }
    }
}
