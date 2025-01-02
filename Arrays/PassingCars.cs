using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA.Arrays.Codility
{
    public class PassingCars
    {
        //https://app.codility.com/programmers/lessons/5-prefix_sums/passing_cars/
        public static int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int n = A.Length, counter = 0, pairs = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                if (A[i] == 1)
                    counter++;
                else
                    pairs += counter;

                if (pairs > 1000000000) return -1;
            }
            return pairs;
        }
        public static void Test()
        {
            var a2 = new int[] { 0, 1, 0, 1, 1 };
            Console.WriteLine($"[0, 1, 0, 1, 1]: {solution(a2)}");
            
        }
    }
}
