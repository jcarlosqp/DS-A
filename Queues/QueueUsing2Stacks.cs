using System;
using System.Collections.Generic;

namespace DSA.Queues.HackerRank
{
    //https://www.hackerrank.com/challenges/queue-using-two-stacks/problem?isFullScreen=true
    public class QueueUsingTwoStacks
    {
        static void RefillS2(Stack<int> s1, Stack<int> s2)
        {
            int poped = 0;
            if (s2.Count == 0)
                while (s1.TryPop(out poped))
                    s2.Push(poped);
        }
        static void QueueUsing2Stacks(List<string> operations)
        {
            var s1 = new Stack<int>();
            var s2 = new Stack<int>();
            int poped = 0;

            foreach (var op in operations)
            {
                if (op[0] == '1')
                {
                    int val = Convert.ToInt32(op.Substring(2));
                    s1.Push(val);
                }
                else if (op[0] == '2')
                {
                    RefillS2(s1, s2);
                    s2.TryPop(out poped);
                }
                else if (op[0] == '3')
                {
                    RefillS2(s1, s2);
                    if (s2.TryPeek(out int result))
                        Console.WriteLine(result);
                }
            }

        }
        public static void Test()
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<string> ops = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string opsItem = Console.ReadLine();
                ops.Add(opsItem);
            }

            QueueUsing2Stacks(ops);

        }
    }
}
