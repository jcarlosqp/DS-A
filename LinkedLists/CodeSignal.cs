using System;
using System.Collections.Generic;
using System.Text;

namespace DSA
{       
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
    
        public static bool isListPalindrome(ListNode<int> l) {
            var slow=l;
            var fast=l;
            while(fast!=null && fast.Next!=null){
                slow=slow.Next;
                fast=fast.Next.Next;
            }
            ListNode<int> reversed=reverseList(slow);
            while(reversed!=null){
                if(l.Value!=reversed.Value)
                    return false;
                    
                l=l.Next;
                reversed=reversed.Next;
            }
            return true;
        }
        private static ListNode<int> reverseList(ListNode<int> head){
            ListNode<int> prev=null;
            while(head!=null){
                ListNode<int> next=head.Next;
                head.Next=prev;
                prev=head;
                head=next;
            }
            return prev;
        }
    

        public static ListNode<int> mergeTwoLinkedLists(ListNode<int> l1, ListNode<int> l2) {

            ListNode<int> result = new ListNode<int>(0);
            ListNode<int> newNode = result;
            while(l1!=null && l2!=null) {
                if(l1.Value<l2.Value){
                    newNode.Next=new ListNode<int>(l1.Value);
                    l1=l1.Next;
                }else {
                    newNode.Next=new ListNode<int>(l2.Value);
                    l2=l2.Next;
                }
                newNode=newNode.Next;                
            }
            if(l1!=null) newNode.Next=l1;
            if(l2!=null) newNode.Next=l2;
            return result.Next;
        }
        public static void mergeTwoLinkedListsTests(){
            ListNode<int> l1 = new ListNode<int>(1);
            var node2 = new ListNode<int>(2);
            var node3 = new ListNode<int>(5);            
            l1.Next=node2;
            //node2.Next=node3;

            ListNode<int> l2 = new ListNode<int>(0);
            var node5 = new ListNode<int>(2);
            var node6 = new ListNode<int>(3);
            l2.Next=node5;
            node5.Next=node6;

            Console.WriteLine($"Input List1:");
            ListHelper<int>.PrintList(l1);
            Console.WriteLine($"Input List2:");
            ListHelper<int>.PrintList(l2);
            Console.WriteLine($"Sum List:");
            var result = mergeTwoLinkedLists(l1, l2);
            ListHelper<int>.PrintList(result);

        }

    }
}