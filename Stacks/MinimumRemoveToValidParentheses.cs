using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Stacks.Leetcode
{
    public class MinimumRemoveToValidParentheses
    {
        //https://leetcode.com/problems/minimum-remove-to-make-valid-parentheses/
        public string MinRemoveToMakeValid(string s)
        {
            var stack = new Stack<int>();
            var chars = s.ToCharArray();

            for (int i = 0; i < chars.Count(); i++)
            {
                if (chars[i] == '(')
                    stack.Push(i);
                else if (chars[i] == ')')
                {
                    if (stack.Count > 0)
                        stack.Pop();
                    else
                        chars[i] = ' ';
                }
            }
            while (stack.Count > 0)
            {
                chars[stack.Pop()] = ' ';
            }
            var res = new string(chars);
            return res.Replace(" ", "");
        }
    }
}
