using System;

namespace DSA.Dynamic.LeetCode
{
    //https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
    public class BestTimeBuySellStock
    {
        public static int MaxProfit(int[] prices)
        {
            int n = prices.Length, max = 0;
            var maxSell = new int[n];
            maxSell[n - 1] = 0;
            for (int i = n - 2; i >= 0; i--)
            {
                max = Math.Max(max, prices[i + 1]);
                maxSell[i] = max;
            }
            max = 0;
            for (int i = 0; i < n; i++)
            {
                max = Math.Max(max, maxSell[i] - prices[i]);
            }
            return max;
        }
        public static void Test()
        {
            var prices = new[]{7,1,5,3,6,4};
            Console.WriteLine($"matrix = [7,1,5,3,6,4], MaxProfit: {MaxProfit(prices)}");

        }
    }
}
