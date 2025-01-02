using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Stacks
{
    public class MaximumElement
    {
        public static List<int> getMax(List<string> operations)
        {
            var stack = new Stack<(int Element, int MaxE)>();
            var result = new List<int>();
            var values = new SortedDictionary<int, int>();
            int max = 0;

            foreach (var op in operations)
            {
                if (op[0] == '1')
                {
                    var value = Convert.ToInt32(op.Substring(2));
                    if (stack.Count > 0)
                    {
                        max = Math.Max(stack.Peek().MaxE, value);
                    }
                    else
                    {
                        max = value;
                    }
                    stack.Push((value, max));

                }
                else if (op[0] == '2')
                {
                    stack.TryPop(out var deleted);
                }
                else if (op[0] == '3')
                {
                    result.Add(stack.Peek().MaxE);
                }
            }
            return result;
        }
        public static void Test()
        {
            var ops = new[] { "1 97", "2", "1 20", "2", "1 26", "1 20", "2", "3", "1 91", "3"};
            Console.WriteLine($"ops, result: {string.Join(" ",getMax(ops.ToList()))}");

        }
    }
}
