using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{
    public class ListNode<T> {
        public T Value { get; set; }
        public ListNode<T> Next { get; set; }
        public ListNode(T value)
        {
            Value=value;
        }
    }
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
    public partial class CodeSignal
    {
        public static ListNode<int> remoteKFromList(ListNode<int> list, int K) {
            if(list==null) return null; //throw new ArgumentNullException("List is null");
            
            while(list?.Value==K){
                list = list.Next;
            }
            var currentNode = list;
            while(currentNode?.Next!=null) {
                if(currentNode.Next.Value==K){
                    currentNode.Next = currentNode.Next.Next;
                }
                else
                    currentNode = currentNode.Next;
            }
            return list;

        }
        public static void remoteKFromListTests(){
            int K=3;
            ListNode<int> list = new ListNode<int>(1);
            var node2 = new ListNode<int>(-3);
            var node3 = new ListNode<int>(32);
            list.Next=node2;
            node2.Next=node3;
            node3.Next = new ListNode<int>(3);
            Console.WriteLine($"Input List:");
            ListHelper<int>.PrintList(list);

            var result = remoteKFromList(list,K);
            Console.WriteLine($"Removed {K} from List:");
            ListHelper<int>.PrintList(result);

        }
    }
}