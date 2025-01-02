using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DSA.Strings.HackerRank
{
    public class SherlockAndValidString
    {
        //https://www.hackerrank.com/challenges/sherlock-and-valid-string/problem?isFullScreen=true
        public static string isValid(string s)
        {
            var frec = new Dictionary<char, int>();
            foreach (var c in s)
                if (frec.ContainsKey(c))
                    frec[c]++;
                else
                    frec.Add(c, 1);

            var dist = frec.Values.Distinct().ToArray();
            if (dist.Count() == 1)
                return "YES";
            else if (dist.Count() > 2)
                return "NO";
            else
            {
                int f0 = 0, f1 = 0;
                foreach (int v in frec.Values)
                    if (v == dist[0])
                        f0++;
                    else
                        f1++;

                return ((f0 == 1 || f1 == 1) && Math.Abs(dist[0] - dist[1]) == 1) ? "YES" : "NO";
            }

        }
        public static void Test()
        {
            string value = "aabbccddeefghi";
            Console.WriteLine($"value:{value}, result: {isValid(value)}");
            
        }
    }
}
