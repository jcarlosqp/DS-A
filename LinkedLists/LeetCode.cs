using System;
namespace DSA{
    public partial class LeetCode
    {
        public static ListNode<int> addTwoNumbers(ListNode<int> l1, ListNode<int> l2){
            int val1, val2, sum, digit, extra=0;
            ListNode<int> result=null, sumNode = null;
            while(l1!=null || l2!=null) {
                val1 = l1!=null ? l1.Value : 0;
                val2 = l2!=null ? l2.Value : 0;
                sum = val1+val2+extra;
                digit = sum % 10;
                extra = sum > 9 ? 1 : 0;

                if(result==null){
                    sumNode = new ListNode<int>(digit);
                    result=sumNode;
                }
                else{
                    sumNode.Next = new ListNode<int>(digit);
                    sumNode = sumNode.Next;
                }

                l1=l1?.Next;
                l2=l2?.Next;
            }
            if(extra>0)
                sumNode.Next = new ListNode<int>(extra);

            return result;
        }

        public static void addTwoNumbersTests(){
            ListNode<int> l1 = new ListNode<int>(1);
            var node2 = new ListNode<int>(5);
            var node3 = new ListNode<int>(3);            
            l1.Next=node2;
            node2.Next=node3;

            ListNode<int> l2 = new ListNode<int>(4);
            var node5 = new ListNode<int>(5);
            var node6 = new ListNode<int>(6);
            l2.Next=node5;
            //node5.Next=node6;

            Console.WriteLine($"Input List1:");
            ListHelper<int>.PrintList(l1);
            Console.WriteLine($"Input List2:");
            ListHelper<int>.PrintList(l2);
            Console.WriteLine($"Sum List:");
            var result = addTwoNumbers(l2, l1);
            ListHelper<int>.PrintList(result);

        }
    }
}