using System;
using System.Collections;
using System.Linq;

namespace DSA.BitManipulation.HackerRank
{
    public class CounterGame
    {
        //https://www.hackerrank.com/challenges/counter-game/problem?isFullScreen=true
        public static string counterGame(long n)
        {
            const string L = "Louise";
            const string R = "Richard";
            bool gamer = false;
            long lExp = 0;

            if (n == 1) return L;

            while (n > 1)
            {
                var exp = Math.Log(n, 2);
                lExp = (long)exp;
                if (exp > lExp)
                    n -= (long)Math.Pow(2, lExp);
                else
                    n /= 2;

                gamer = !gamer;
            }
            return !gamer ? R : L;
        }
        public static void Test()
        {
            Console.WriteLine($"n=6, winner: {counterGame(6)}");
            
        }
    }
}
