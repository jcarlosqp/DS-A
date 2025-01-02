using System;

namespace DSA.Implementation.HackerRank
{
    //https://www.hackerrank.com/challenges/the-time-in-words/problem?isFullScreen=true
    class TheTimeInWords
    {
        public static string timeInWords(int h, int m)
        {
            var numbers = new string[]{
                        "zero", "one", "two", "three", "four", "five", "six", "seven",
                        "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen",
                        "fithteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty"
                        };

            string result = m switch
            {
                0 => numbers[h] + " o' clock",
                1 or 59 => "one minute",
                15 or 45 => "quarter",
                30 => "half",
                > 0 and <= 20 => numbers[m] + " minutes",
                > 20 and < 30 => numbers[20] + " " + numbers[m % 20] + " minutes",
                > 30 and < 40 => numbers[20] + " " + numbers[10 - m % 30] + " minutes",
                _ => numbers[60 - m] + " minutes"
            };

            if (m > 0 && m <= 30)
                result += " past " + numbers[h];
            else if (m > 30)
                result += " to " + numbers[h + 1];

            return result;
        }

        public static void Test()
        {
            Console.WriteLine($"Time: [5:47], result: {TheTimeInWords.timeInWords(5,47)}");

        }
    }
}
