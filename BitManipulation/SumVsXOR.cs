using System;
using System.Collections;
using System.Linq;

namespace DSA.BitManipulation.HackerRank
{
    public class SumVsXOR
    {
        //https://www.hackerrank.com/challenges/sum-vs-xor/problem?isFullScreen=true
        public static long sumXor(long n)
        {
            if (n == 0) return 1;
            var bitStr = Convert.ToString(n, 2);
            int zeros = bitStr.Count(b => b == '0');
            return (long)Math.Pow(2, zeros);
        }
        public static void Test()
        {
            Console.WriteLine($"n=10, result: {sumXor(10)}");
            
        }
    }
}
