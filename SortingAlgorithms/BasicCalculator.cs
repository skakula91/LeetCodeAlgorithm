using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    public class BasicCalculator
    {
        Stack<int> value = new Stack<int>();
        Stack<char> symbol = new Stack<char>();
        Dictionary<char, int> dict = new Dictionary<char, int>();
        public int Calculate(string s)
        {
            dict.Add('+', 1);
            dict.Add('-', 1);
            dict.Add('*', 2);
            dict.Add('/', 2);
            dict.Add('(', 0);
            int num = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                    continue;

                if (char.IsDigit(s[i]))
                {
                    while (i < s.Length && char.IsDigit(s[i]))
                    {
                        num = num * 10 + (s[i] - '0');
                        i++;
                    }
                    value.Push(num);
                    num = 0;
                    i--;
                }
                else
                {
                    if (s[i] == '(')
                    {
                        symbol.Push(s[i]);
                    }
                    else if (s[i] == '+')
                    {
                        
                        LoopElements(s[i]);
                        symbol.Push(s[i]);
                    }
                    else if (s[i] == '-')
                    {
                        LoopElements(s[i]);
                        symbol.Push(s[i]);
                    }
                    else if (s[i] == '*')
                    {
                        LoopElements(s[i]);
                        symbol.Push(s[i]);
                    }
                    else if (s[i] == '/')
                    {
                        LoopElements(s[i]);
                        symbol.Push(s[i]);
                    }
                    else if (s[i] == ')')
                    {
                        while (symbol.Count != 0 && symbol.Peek() != '(')
                        {
                            Operation();
                        }

                        symbol.Pop();
                    }
                }
            }

            while (symbol.Count != 0)
            {
                Operation();
            }
            return value.Pop();
        }

        public void LoopElements(char oper)
        {
            while (symbol.Count != 0 && dict[symbol.Peek()] >= dict[oper])
            {
                Operation();
            }
        }

        public void Operation()
        {
            int x = value.Pop();
            int y = value.Pop();
            char sym = symbol.Pop();

            if (sym == '+')
            {
                value.Push(x + y);
            }
            else if (sym == '-')
            {
                value.Push(x - y);
            }
            else if (sym == '*')
            {
                value.Push(x * y);
            }
            else if (sym == '/')
            {
                value.Push(x / y);
            }
        }
    }
}
