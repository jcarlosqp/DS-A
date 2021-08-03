using System.Collections;
using System;
using System.Text;

namespace DSA{

    public class Node<T> {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
        public Node(T value)
        {
            this.Value = value;
            this.Next = null;
        }
    }

    public class MyLinkedList<T> {
        private Node<T> Head;
        private Node<T> Tail;
        public int Length { get; private set; }

        public MyLinkedList() {
            Head = null;
            Tail = null;
            Length = 0;
        }
        public MyLinkedList(T value)
        {
            AddFirstValue(value);
        }

        private void AddFirstValue(T value) {
            Head = new Node<T>(value);
            Tail = Head;
            this.Length = 1;
        }

        public bool Append(T value) {
            if (value != null) {
                if (Tail != null) {
                    var newNode = new Node<T>(value);
                    Tail.Next = newNode;
                    Tail = newNode;
                    Length++;
                } else {
                    AddFirstValue(value);
                }
                return true;
            }
            return false;
        }

        public bool Prepend(T value) {
            if (value != null) {
                if (Head != null) {
                    var newNode = new Node<T>(value);
                    newNode.Next = Head;
                    Head = newNode;
                    Length++;
                } else {
                    AddFirstValue(value);
                }
                return true;
            }
            return false;
        }
        private Node<T> GetNodeByIndex(int index) {
            var currentNode = Head;
            int currentIndex = 0;
            while(currentIndex<=index) {
                if (currentIndex==index) return currentNode;
                currentNode = currentNode.Next;
                currentIndex++;
            }
            return null;
        }
        public bool Insert(int index, T value) {
            if (value != null) {
                if (index==0) {
                    return Prepend(value);
                }
                if (index==Length-1) {
                    return Append(value);
                }

                if (index>0 && index<Length-1) {                    
                    var prevNode = GetNodeByIndex(index-1);
                    if (prevNode!=null){
                        var newNode = new Node<T>(value);
                        var nextNode=prevNode.Next;
                        prevNode.Next = newNode;
                        newNode.Next = nextNode;
                        Length++;
                        return true;
                    }
                } 
                
            }
            return false;
        }

        public string Print() {
            var current = Head;
            var sb = new StringBuilder($"Linked List values [{Length}]: ");

            while(current!=null) {
                sb.Append($"--> {current.Value} ");
                current = current.Next;
            }
            return sb.ToString();
        }

        public static void Test() {
            var myList = new MyLinkedList<int>();
            myList.Append(3);
            myList.Append(5);
            myList.Append(11);
            myList.Prepend(-101);
            myList.Insert(2, 4);
            myList.Insert(4, 44);
            myList.Insert(0, 0);
            Console.WriteLine(myList.Print());
        }
    }
}