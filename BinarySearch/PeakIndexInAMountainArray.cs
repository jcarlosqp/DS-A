using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.BinarySearch.Leetcode
{
    //https://leetcode.com/problems/peak-index-in-a-mountain-array/
    class PeakIndexInAMountainArray
    {
        public static int PeakIndexInMountainArray(int[] arr)
        {

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[i - 1])
                    return i - 1;
            }
            return -1;
        }
        public static void Test()
        {
            var a = new[] { 0, 10, 5, 2};
            Console.WriteLine($"mountain array: [0, 10, 5, 2], result: {PeakIndexInMountainArray(a)}");

        }

    }
}
