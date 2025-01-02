using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.BinarySearch.Leetcode
{
    //https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
    public class TwoSumII
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int v2, i2, n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                v2 = target - numbers[i];
                if (v2 >= numbers[i + 1] && v2 <= numbers[n - 1])
                {
                    i2 = BSearch(numbers, i + 1, n - 1, v2);
                    if (i2 >= 0)
                        return new[] { i + 1, i2 + 1 };
                }
            }
            return null;
        }
        private int BSearch(int[] numbers, int l, int r, int target)
        {
            int m = -1, val;
            while (l <= r)
            {
                m = (l + r) / 2;
                val = numbers[m];
                if (val == target) return m;
                else if (val < target) l = m + 1;
                else r = m - 1;
            }
            return -1;
        }
    }
}
