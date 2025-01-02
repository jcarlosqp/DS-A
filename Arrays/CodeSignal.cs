using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public partial class CodeSignal
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


        public static char firstNonRepeatingCharacter(string text) {
            if (string.IsNullOrEmpty(text)) throw new ArgumentNullException("Argument is null or empty");
            if (text.Length == 1) return text[0];

            const char NotFound = '_';
            var values = new Dictionary<char, bool>();
            foreach(char c in text) {
                values[c] = values.ContainsKey(c);
            }
            foreach(var item in values)
                if (!item.Value)  return item.Key;

            return NotFound;
        }

        public static void firstNonRepeatingCharacterTests() {
            Console.WriteLine($"1 value: {firstNonRepeatingCharacter("U")}");
            Console.WriteLine($"ccdefgdjked values: {firstNonRepeatingCharacter("ccdefgdjked")}");
            Console.WriteLine($"jaja value: {firstNonRepeatingCharacter("jaja")}");
            Console.WriteLine($"vocales values: {firstNonRepeatingCharacter("aeiou")}");
            Console.WriteLine($"aagcdefccb value: {firstNonRepeatingCharacter("aagcdefccb")}");
        }


        private static void swap(int val1, int val2) {
            int temp = val2;
            val2 = val1;
            val1 = temp;
        }
        public static void rotateImage(int[][] matrix) {
            int length = matrix.Length;
            if(length>1) {
                for (int row = 0; row < length; row++)
                    for (int col = row; col < length; col++) {
                        int temp = matrix[row][col];
                        matrix[row][col] = matrix[col][row];
                        matrix[col][row] = temp;
                    }
                
                for (int row = 0; row < length; row++)
                    for (int col = 0; col < length/2; col++) {
                        int temp = matrix[row][col];
                        matrix[row][col] = matrix[row][length-1-col];
                        matrix[row][length-1-col] = temp;
                    }
            }       

        }

        public static void rotateImagenTests() {
            int[][] matrix = {  new int[]{1,2,3},
                                new int[]{4,5,6}, 
                                new int[]{7,8,9}};
            Print(matrix);
            rotateImage(matrix);
            Print(matrix);
        }

        static void Print(int[][] values){
            Console.WriteLine("Array values:");
            foreach(var row in values) {
                foreach(var item in row)
                    Console.Write(item+" ");
                Console.WriteLine();
            }                
        }
    
        private static int deCrypt(string value, Dictionary<char, char> solution) {
            var sb = new StringBuilder();
            foreach(var c in value)             
                sb.Append(solution[c]);    

            int.TryParse(sb.ToString(), out int valor);
            return valor;
        }
        public static bool isCryptSolution(string[] crypt, char[][] solution) {
            if(crypt?.Length!=3) throw new ArgumentOutOfRangeException("Items should be 3");
            if(solution==null) throw new ArgumentNullException("Solution is null");

            var values = new Dictionary<char, char>();            
            foreach(var item in solution)
                values.Add(item[0], item[1]);

            if (values[crypt[0][0]]=='0' || values[crypt[1][0]]=='0' || values[crypt[2][0]]=='0') return false;
            
            int valor1 = deCrypt(crypt[0], values);
            int valor2 = deCrypt(crypt[1], values);
            int valor3 = deCrypt(crypt[2], values);
            Console.WriteLine($"valor1: {valor1}");
            Console.WriteLine($"valor2: {valor2}");
            Console.WriteLine($"valor3: {valor3}");
            return valor1+valor2==valor3;
        }

        public static void isCryptSolutionTests() {
            char[][] solution = {
                new char[]{'O','0'},
                new char[]{'M','1'},
                new char[]{'Y','2'},
                new char[]{'E','5'},
                new char[]{'N','6'},
                new char[]{'D','7'},
                new char[]{'R','8'},
                new char[]{'S','9'}
            };
            string[] crypt = {"SEND", "MORE", "MONEY"};
            var result = isCryptSolution(crypt, solution);
            Console.WriteLine($"Result: {result}");

            char[][] solution2 = {
                new char[]{'O','1'},
                new char[]{'T','0'},
                new char[]{'W','9'},
                new char[]{'E','5'},
                new char[]{'N','6'}
            };
            string[] crypt2 = {"TEN", "TWO", "ONE"};
            var result2 = isCryptSolution(crypt2, solution2);
            Console.WriteLine($"Result: {result2}");
        }
    
    }

}