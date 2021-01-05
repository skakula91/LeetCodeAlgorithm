using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPart2
{
    public class FindFruitCombs
    {
        public static int winPrize(String[][] codeList, String[] shoppingCart)
        {
            int i = 0;
            int j = 0;
            while (i < codeList.Length && j + codeList[i].Length < shoppingCart.Length)
            {
                bool match = true;
                for (int k = 0; k < codeList[i].Length; k++)
                {
                    if (codeList[i][k] != "anything" && shoppingCart[j + k] != codeList[i][k])
                    {
                        match = false;
                        break;
                    }
                }

                if (match)
                {
                    j += codeList[i].Length;
                    i++;
                }
                else
                {
                    j++;
                }
            }
            return (i == codeList.Length) ? 1 : 0;
        }
    }
}
