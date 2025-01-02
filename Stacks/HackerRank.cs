using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA.Stacks
{
    public partial class HackerRank {
        public static long largestRectangle(List<int> h)
        {
            h.Add(0);
            int i=0, n=h.Count, area, maxArea=0;
            var stack = new Stack<int>();

            while(i<n){
                if(stack.Count==0 || stack.Peek()<h[i]){
                    stack.Push(i);
                    i++;
                }
                else{
                    var top = stack.Pop();
                    area = stack.Count > 0 ? (i-stack.Peek()-1) : i;
                    maxArea=Math.Max(maxArea, area);
                }
            }
            return maxArea;
        }

        public static bool BracketsWithStacks(string s){
            var stack = new Stack<char>();
            var b = new Dictionary<char, char>(){
                {'{', '}'},
                {'[', ']'},
                {'(', ')'}
            };

            char key, value;
            bool found, breakFound;
            foreach(char c in s)
                if(b.ContainsKey(c) || b.ContainsValue(c)){
                    found = stack.TryPeek(out key);
                    breakFound = b.TryGetValue(key, out value);
                    if(found && breakFound && c==value)
                        stack.Pop();
                    else
                        stack.Push(c);
                }            

            return stack.Count==0;
        }
    }
}