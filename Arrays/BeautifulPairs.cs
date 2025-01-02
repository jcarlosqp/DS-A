using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DSA.Arrays.HackerRank
{
    public partial class BeautifulPairs
    {
        //https://www.hackerrank.com/challenges/beautiful-pairs/problem?isFullScreen=true
        public static int beautifulPairs(List<int> A, List<int> B)
        {
            int counter = 0, key = 0, n = A.Count;
            if (n == 1) return 0;

            var valuesA = new Dictionary<int, Stack<int>>();
            for (int i = 0; i < n; i++)
            {
                key = A[i];
                if (valuesA.ContainsKey(key))
                    valuesA[key].Push(i);
                else
                    valuesA.Add(key, new Stack<int>(new []{ i }));
            }

            for (int i = 0; i < n; i++)
            {
                key = B[i];
                if (valuesA.ContainsKey(key))
                {
                    counter++;
                    valuesA[key].Pop();
                    if (valuesA[key].Count == 0)
                        valuesA.Remove(key);
                }

            }
            if (counter < n)
                counter++;

            return counter;

        }
        public static void Test()
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> A = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(ATemp => Convert.ToInt32(ATemp)).ToList();

            List<int> B = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(BTemp => Convert.ToInt32(BTemp)).ToList();

            int result = beautifulPairs(A, B);

            Console.WriteLine(result);

        }
    }
}