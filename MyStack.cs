using System;
namespace DSA {
    public class MyStack<T> {
        public Node<T> Top { get; private set; }
        public Node<T> Bottom { get; private set; }
        public int Count {get; private set;}
        public MyStack()
        {
            Top = null;
            Bottom = null;
            Count = 0;
        }

        public T Peek() {
            if (Top == null) throw new InvalidOperationException("Top is null");
            return Top.Value;
        }

        public void Push(T value) {
            var newNode = new Node<T>(value);
            if (Top == null) {
                Top = newNode;
                Bottom = newNode;
            } else {
                newNode.Next = Top;
                Top = newNode;
            }
            Count++;
        }

        public T Pop() {
            if (Top == null) throw new InvalidOperationException("Top is null");
            var value = Top.Value;
            Top = Top.Next;
            return value;
        }

        public static void Test() {
            var stack = new MyStack<string>();
            //stack.Peek();
            stack.Push("Adam");
            Console.WriteLine($" Peek: {stack.Peek()}");

            stack.Push("Billy");
            stack.Push("Carlos");
            Console.WriteLine($" Pop value: {stack.Pop()}");
            Console.WriteLine($" Peek: {stack.Peek()}");
        }
    }
}