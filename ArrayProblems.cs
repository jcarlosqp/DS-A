using System.Text;
namespace DSA
{
    public class ArrayProblems
    {
        public static string Reverse(string value){            
            if (value == null) return null;
            if (value.Length <= 1) return value;

            var builder = new StringBuilder();
            for (int idx=value.Length-1; idx>=0;idx--){                
                builder.Append(value[idx]);
            }            
            return builder.ToString();
        }

        public static int[] MergeSortedArrays(int[] array1, int[] array2){  

            if (array1 == null) return array2;
            if (array2 == null) return array1;

            var array1Length=array1.Length;
            var array2Length=array2.Length;
            if (array1Length == 0) return array2;
            if (array2Length == 0) return array1;

            var result=new int[array1Length+array2Length];
            int idx1 = 0;
            int idx2 = 0;
            int idx = 0;

            while (idx1<array1Length || idx2<array2Length){
                if (idx2>=array2Length || (idx1<array1Length && array1[idx1]<array2[idx2])){
                    result[idx]=array1[idx1];
                    idx1++;
                } else {
                    result[idx]=array2[idx2];
                    idx2++;
                }
                idx++;
            }
            return result;
        }
    
        public static void MergeSortedTests() {
            // var array1 = new int[]{0,3,4,31};
            // var array2 = new int[]{4,30};
            // Print(ArrayProblems.MergeSortedArrays(null,null));
            // Print(ArrayProblems.MergeSortedArrays(array1,null));
            // Print(ArrayProblems.MergeSortedArrays(new int[]{},array2));
            // Print(ArrayProblems.MergeSortedArrays(array1,array2));
        }
    }
}