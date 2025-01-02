using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Arrays.Codility
{
    public class FrogRiverOne
    {
        public static int solution(int X, int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            const int NoAbleJumpOtherSide = -1;
            if (A.Length == 1)
                return A[0] == 1 ? 0 : NoAbleJumpOtherSide;
            else if (A.Length < X)
                return NoAbleJumpOtherSide;

            var pos = new HashSet<int>();
            for (int i = 1; i <= X; i++)
                pos.Add(i);

            int value = 0;
            for (int i = 0; i < A.Length; i++)
            {
                value = A[i];
                if (pos.Contains(value))
                    pos.Remove(value);

                if (pos.Count == 0)
                    return i;
            }
            return NoAbleJumpOtherSide;
        }

        public static void Test()
        {

            //Console.WriteLine($"null value: {firstDuplicate(null)}");
            var a2 = new int[] { 2, 3 };
            Console.WriteLine($"[2, 3]: {solution(10, a2)}");
            var a3 = new int[] { 1, 3, 1, 4, 2, 3, 5, 4 };
            Console.WriteLine($"[1, 3, 1, 4, 2, 3, 5, 4]: {solution(5, a3)}");

        }
    }
}
