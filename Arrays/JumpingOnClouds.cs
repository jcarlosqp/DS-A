using System;
using System.Collections.Generic;

namespace DSA.Arrays
{
    class JumpingOnClouds
    {
        //https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem?isFullScreen=true
        public static int jumpingOnClouds(List<int> c)
        {
            int n = c.Count;
            if (n == 2) return 1;

            int i = 0, jumps = 0;
            while (i < n - 1)
            {
                if (i + 2 < n && c[i + 2] == 0)
                    i += 2;
                else
                    i++;

                jumps++;
            }
            return jumps;
        }

        public static void Test()
        {
            var clouds = new List<int> { 0, 0, 1, 0, 0, 1, 0 };
            Console.WriteLine($"[0 0 1 0 0 1 0], result: {jumpingOnClouds(clouds)}");            

        }
    }
}
