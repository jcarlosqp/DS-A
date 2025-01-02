using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DSA.Strings.HackerRank
{
    public class GameOfThronesI
    {
        //https://www.hackerrank.com/challenges/game-of-thrones/problem?isFullScreen=true
        public static string gameOfThrones(string s)
        {
            var values = new Dictionary<char, int>();
            foreach (var c in s)
                if (values.ContainsKey(c))
                    values[c]++;
                else
                    values.Add(c, 1);

            var odds = values.Count(v => v.Value % 2 != 0);
            return odds > 1 ? "NO" : "YES";
        }
        public static void Test()
        {
            string value = "aaabbbb";
            Console.WriteLine($"value:{value}, result: {gameOfThrones(value)}");
            
        }
    }
}
