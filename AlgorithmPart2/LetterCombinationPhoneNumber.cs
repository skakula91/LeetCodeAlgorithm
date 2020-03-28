using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPart2
{
    public class LetterCombinationPhoneNumber
    {
        public List<string> result = new List<string>();
        public SortedDictionary<char, string> dict = new SortedDictionary<char, string>();
        public IList<string> LetterCombinations(string digits)
        {
            dict.Add('1', "1");
            dict.Add('2', "abc");
            dict.Add('3', "def");
            dict.Add('4', "ghi");
            dict.Add('5', "jkl");
            dict.Add('6', "mno");
            dict.Add('7', "pqrs");
            dict.Add('8', "tuv");
            dict.Add('9', "wxyz");
            dict.Add('0', "0");
            if (!string.IsNullOrWhiteSpace(digits))
            {
                Helper(digits, 0, new List<char>());
            }
            Helper(digits, 0, new List<char>());
            return result;

        }
        public void Helper(string digits, int index, List<char> slate)
        {
            if (digits.Length == index)
            {
                result.Add(new string(slate.ToArray()));
                return;
            }
            else
            {
                var str = dict[digits[index]];
                for (int j = 0; j < str.Length; j++)
                {
                    slate.Add(str[j]);
                    Helper(digits, index + 1, slate);
                    slate.RemoveAt(slate.Count - 1);
                }
            }
        }
    }
}
