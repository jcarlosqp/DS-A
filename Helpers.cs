using System;

namespace DSA {
    public class Helper {
        public static void PrintArray(string[][] values){
            if (values == null) {
                Console.WriteLine("Null values");
                return;
            }
            foreach(var value in values) {
                Console.Write("[ ");
                foreach(var item in value)
                    Console.Write(item+", ");
                Console.WriteLine(" ]");
            }               

            Console.WriteLine();
        }
    }
}