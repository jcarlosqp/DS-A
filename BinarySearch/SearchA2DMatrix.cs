using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.BinarySearch.Leetcode
{
    //https://leetcode.com/problems/search-a-2d-matrix/
    public class SearchA2DMatrix
    {
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            int rows = matrix.Length, cols = matrix[0].Length;
            int l = 0, r = rows - 1, m, val;
            while (l <= r)
            {
                m = (l + r) / 2;
                val = matrix[m][0];
                if (val == target)
                    return true;
                else if (val < target)
                    if (target <= matrix[m][cols - 1])
                        return BSearch(matrix[m], target);
                    else
                        l = m + 1;
                else
                    r = m - 1;
            }
            return false;
        }
        public static void Test()
        {
            var matrix = new[]{
                new[]{1,3,5,7},
                new[]{10,11,16,20},
                new[]{23,30,34,60}
            };
            Console.WriteLine($"matrix = [[1,3,5,7],[10,11,16,20],[23,30,34,60]], target = 3, result: {SearchMatrix(matrix, 3)}");

        }
        private static bool BSearch(int[] matrix, int target)
        {
            int l = 0, r = matrix.Length - 1, m, val;
            while (l <= r)
            {
                m = (l + r) / 2;
                val = matrix[m];
                if (val == target)
                    return true;
                else if (val < target)
                    l = m + 1;
                else
                    r = m - 1;
            }
            return false;
        }
    }
}
