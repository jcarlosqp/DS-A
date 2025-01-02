using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA.Arrays.Codility
{
    public class PermCheck
    {
        public static int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int n = A.Length;
            if (n == 1) return A[0] == 1 ? 1 : 0;

            var seq = new HashSet<int>();
            for (int i = 1; i <= n; i++)
                seq.Add(i);

            foreach (var e in A)
                if (seq.Contains(e))
                    seq.Remove(e);
                else
                    return 0;

            return seq.Count == 0 ? 1 : 0;
        }
        public static void Test()
        {
            var a2 = new int[] { 4, 1, 3 };
            Console.WriteLine($"[4, 1, 3]: {solution(a2)}");
            var a3 = new int[] { 4, 1, 3, 2 };
            Console.WriteLine($"[4, 1, 3, 2]: {solution(a3)}");

        }
    }
}
