using System;
using System.Collections.Generic;
namespace DSA
{
    public class CodeSignal
    {
        public static int firstDuplicate(int[] a) {
            
            if (a == null) throw new Exception("Argument is null");
            
            const int NoDuplicate = -1;
            int length = a.Length;
            if (length == 1) return NoDuplicate;

            if (length == 2 && a[0]==a[1]) return a[1];

            var values = new HashSet<int>();
            for (int i = 0; i < length; i++)
            {
                if (values.Contains(a[i]))
                    return a[i];
                 
                values.Add(a[i]);
            }

            return NoDuplicate;
        }

        public static void firstDuplicateTest(){

            //Console.WriteLine($"null value: {firstDuplicate(null)}");
            var a1 = new int[]{5};
            Console.WriteLine($"1 value: {firstDuplicate(a1)}");
            var a2 = new int[]{2, 2};
            Console.WriteLine($"2 values: {firstDuplicate(a2)}");
            var a3 = new int[]{2,1,3,5,3,2};
            Console.WriteLine($"2 values: {firstDuplicate(a3)}");
            var a4 = new int[]{2, 3, 5, 1};
            Console.WriteLine($"2 values: {firstDuplicate(a4)}");
        }

    }

}