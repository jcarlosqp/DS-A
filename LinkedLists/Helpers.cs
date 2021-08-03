using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class ListHelper<T> {
        public static void PrintList(ListNode<T> list){
            var sb = new StringBuilder("LinkedList values: ");
            var node = list;
            while(node!=null){
                sb.Append($"{node.Value}->");
                node = node.Next;
            }
            Console.WriteLine(sb.ToString());
        }
    }
}