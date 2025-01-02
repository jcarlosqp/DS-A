using System;
using System.Collections;
using System.Linq;

namespace DSA.BitManipulation.HackerRank
{
    public class XorSequence
    {
        //https://www.hackerrank.com/challenges/xor-se/problem?isFullScreen=true
        static long xorSequence(long l, long r)
        {
            long idx = l;
            long xorL = 0;
            while (idx % 4 != 0)
            {
                xorL ^= getV(idx);
                idx++;
            }
            //Console.WriteLine($"idx:{idx},xorL:{xorL}");

            long n4 = (r - idx) / 4;
            if (n4 % 2 != 0)
                xorL ^= 2;
            //Console.WriteLine($"n4:{n4},xorL:{xorL}");

            while (r % 4 != 0)
            {
                xorL ^= getV(r);
                r--;
            }
            xorL ^= getV(r);
            //Console.WriteLine($"r:{r},xorL:{xorL}");


            return xorL;
        }
        static long getV(long i)
        {
            var res = i % 4;
            var rep = i / 4;
            if (res == 0) return i;
            else if (res == 1) return 1;
            else if (res == 2) return 3 + 4 * rep;
            else return 0;
        }
        public static void Test()
        {
            Console.WriteLine($"l:15,r:20, result: {xorSequence(15, 20)}");
            
        }
    }
}
