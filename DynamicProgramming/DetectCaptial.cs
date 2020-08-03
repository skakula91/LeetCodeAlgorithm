using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DynamicProgramming
{
    public class DetectCaptial
    {
        // Ascii of A is 65 and a is 97
        public bool DetectCapitalUse(string word)
        {
            return word.All(x => x - 'A' < 26) || word.Skip(1).All(x => x - 'a' >= 0);
        }
    }
}
