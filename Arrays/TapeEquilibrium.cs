using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays.Codility
{
    public class TapeEquilibrium
    {
        public static int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (A.Length == 2) return Math.Abs(A[0] - A[1]);

            int sum = A.Sum();
            int acc = 0, min = int.MaxValue, dif;
            for (int i = 0; i < A.Length; i++)
            {
                acc += A[i];
                dif = Math.Abs(acc - (sum - acc));
                min = Math.Min(min, dif);
            }
            return min;
        }

        public static void Test()
        {

            //Console.WriteLine($"null value: {firstDuplicate(null)}");
            var a2 = new int[] { 2, 3 };
            Console.WriteLine($"[2, 3]: {solution(a2)}");
            var a3 = new int[] { 3, 1, 2, 4, 3 };
            Console.WriteLine($"[3, 1, 2, 4, 3]: {solution(a3)}");

        }
    }
}
