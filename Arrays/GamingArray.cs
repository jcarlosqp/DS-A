using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DSA.Arrays.HackerRank
{
    public partial class GamingArray
    {
        //https://www.hackerrank.com/challenges/an-interesting-game-1/problem?isFullScreen=true
        public static string gamingArray(List<int> arr)
        {
            const string andy = "ANDY";
            const string bob = "BOB";
            bool turn = false;
            int len = arr.Count;
            if (len==1) return bob;
            
            var values = new SortedDictionary<int, int>();
            for(int i=0; i<len; i++)
                values.Add(arr[i], i);
            
            var keys = values.Keys.ToArray();
            int key, index, limit=len;
            for(int i=len-1; i>=0; i--){
                key = keys[i];
                index = values[key];
                if (index<limit){                
                    turn = !turn;                
                    if(index==0) return turn ? bob : andy;                    
                    limit = index;
                } 
            }
            return turn ? bob : andy;
        }

        public static void Test()
        {
            int g = Convert.ToInt32(Console.ReadLine().Trim());

            for (int gItr = 0; gItr < g; gItr++)
            {
                int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

                List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

                string result = GamingArray.gamingArray(arr);

                Console.WriteLine(result);
            }

        }
    }
}