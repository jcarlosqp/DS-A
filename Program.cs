using DSA.Arrays.Codility;
using DSA.Arrays.HackerRank;
using DSA.BinarySearch.Leetcode;
using DSA.BitManipulation.HackerRank;
using DSA.Dynamic.LeetCode;
using DSA.GameTheory.HackerRank;
using DSA.Implementation.HackerRank;
using DSA.Queues;
using DSA.Queues.HackerRank;
using DSA.Stacks;
using DSA.Strings.HackerRank;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DSA
{
    class Program
    {
        
        static void Main(string[] args)
        {

            //CodeSignal.firstDuplicateTest();
            //CodeSignal.firstNonRepeatingCharacterTests();
            //CodeSignal.rotateImagenTests();
            //CodeSignal.isCryptSolutionTests();
            //CodeSignal.remoteKFromListTests();

            //LeetCode.addTwoNumbersTests();
            //CodeSignal.mergeTwoLinkedListsTests();
            //CodeSignal.groupingDishesTests();
            //Console.WriteLine('c'-'a');

            //GamingArray.Test();
            //BeautifulPairs.Test();
            //TapeEquilibrium.Test();
            //FrogRiverOne.Test();
            //PermCheck.Test();
            //MissingInteger.Test();
            //PassingCars.Test();
            //CounterGame.Test();
            //SumVsXOR.Test();
            //XorSequence.Test();
            //GameOfThronesI.Test();
            //SherlockAndValidString.Test();
            //NewYearGame.Test();
            //MaximumElement.Test();
            //QueueUsingTwoStacks.Test();
            //CutTheSticks.Test();
            //PeakIndexInAMountainArray.Test();
            //SearchA2DMatrix.Test();
            BestTimeBuySellStock.Test();
        }

        public static string reverse(string value) {
            if(value==null) return null;
            char[] a=value.ToCharArray();
            Array.Reverse(a);
            return String.Join("",a);
        }
        static string reverseInParentheses(string inputString) {
            
            int lastOpen=inputString.LastIndexOf('(');
            int firstClose=-1;

            while(lastOpen>=0) {
                firstClose=inputString.IndexOf(')',lastOpen);
                string toReverse = inputString.Substring(lastOpen+1, firstClose-lastOpen-1 );
                string reversed = reverse(toReverse);
                Console.WriteLine($"toReverse, reversed: {toReverse}{reversed}"); 
                inputString.Replace("("+toReverse+")","("+reversed+")");            
                lastOpen=inputString.LastIndexOf('(');
            }

            return inputString;
        }

        static void Print(int[] values){
            if (values == null) {
                Console.WriteLine("Null values");
                return;
            }
            foreach(var val in values)
                Console.Write(val+" ");

            Console.WriteLine();
        }

    }


}
