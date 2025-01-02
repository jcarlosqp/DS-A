using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.BinarySearch
{
    //https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/
    public class FindFirstAndLastPositionOfElement
    {
        public int[] SearchRange(int[] nums, int target)
        {
            var range = new[] { -1, -1 };
            int n = nums.Length;
            if (n == 0) return range;

            int l = 0, r = n - 1, m = -1, val, idx;
            bool found = false;
            while (l <= r)
            {
                m = l + (r - l) / 2;
                val = nums[m];
                if (val == target)
                {
                    found = true;
                    break;
                }
                else if (val > target)
                    r = m - 1;
                else
                    l = m + 1;
            }
            if (found)
            {
                idx = m;
                while (m >= 0 && nums[m] == target)
                    m--;

                range[0] = m + 1;

                while (idx < n && nums[idx] == target)
                    idx++;

                range[1] = idx - 1;
            }

            return range;
        }
    }
}
