using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA.Arrays.Codility
{
    public class MissingInteger
    {
        //https://app.codility.com/programmers/lessons/4-counting_elements/missing_integer/
        public static int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int max = A.Max();
            var values = new HashSet<int>();
            if (max <= 0)
                values.Add(1);
            else
                values = new HashSet<int>(Enumerable.Range(1, max));

            foreach (var e in A)
                if (e > 0 && values.Contains(e))
                    values.Remove(e);
            
            if (values.Count == 0)
                return max + 1;
            else
                return values.Min();
        }
        public static void Test()
        {
            var a2 = new int[] { 1, 3, 6, 4, 1, 2 };
            Console.WriteLine($"[1, 3, 6, 4, 1, 2]: {solution(a2)}");
            var a3 = new int[] { 1, 2, 3 };
            Console.WriteLine($"[1, 2, 3]: {solution(a3)}");
            var a4 = new int[] { -1, -3 };
            Console.WriteLine($"[−1, −3]: {solution(a4)}");

        }
    }
}
