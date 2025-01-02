using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays.HackerRank
{
    public class CutTheSticks
    {
        //https://www.hackerrank.com/challenges/cut-the-sticks/problem?isFullScreen=true
        public static List<int> cutTheSticks(List<int> arr)
        {
            var result = new List<int>();
            int n = arr.Count;
            arr.Sort();
            result.Add(n);
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > arr[i - 1])
                {
                    result.Add(n - i);
                }
            }
            return result;
        }
        public static void Test()
        {
            var result = cutTheSticks(new List<int> { 1, 2, 3, 4, 3, 3, 2, 1 });
            Console.WriteLine($"[1, 2, 3, 4, 3, 3, 2, 1], result: {string.Join(' ', result)}");

        }
    }
}
