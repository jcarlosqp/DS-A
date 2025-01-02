using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DSA.GameTheory.HackerRank
{
    public class NewYearGame
    {
        //https://www.hackerrank.com/challenges/newyear-game/problem?isFullScreen=true
        private static string Play(List<int> a)
        {
            int n = a.Count;
            const string Balsa = "Balsa", Koca = "Koca";

            if (n == 1)
                return a[0] % 3 == 0 ? Koca : Balsa;
            else
            {
                var frecs = a.Select(e => e % 3).Where(e => e > 0);
                int f1 = 0, f2 = 0;
                foreach (var f in frecs)
                    if (f == 1)
                        f1++;
                    else
                        f2++;
                //Console.WriteLine($"f1:{f1}, f2:{f2}");     
                return (f1 % 2 == 0 && f2 % 2 == 0) ? Koca : Balsa;
            }
        }
        public static void Test()
        {
            var a = new[] { 1, 2, 2, 1, 3, 3, 3, 2, 3, 2 };
            Console.WriteLine($"[1 2 2 1 3 3 3 2 3 2], result: {Play(a.ToList())}");
            
        }
    }
}
