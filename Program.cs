using System;


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

            LeetCode.addTwoNumbersTests();
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
