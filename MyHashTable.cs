using System.Collections;
using System;

namespace DSA{
    public class HTNode{
        public string Key;
        public object Value;
        public HTNode Next;        

    }
    public class MyHashTable{

        private HTNode[] Table;
        private int Size;

        public MyHashTable(int size)
        {
            Size=size;
            Table = new HTNode[Size];
        }
        //Very simple hash function
        public int HashFunc(string key) {
            return key.Length % Size;
        }

        public bool Insert(string key, object value) {

            int index = HashFunc(key);
            if (Table[index] == null) {
                Table[index] = new HTNode() {Key=key, Value = value};
                return true;                
            }
            return false;
        }

        public object Get(string key) {
            int index = HashFunc(key);
            var node = Table[index];

            if (node != null) {
                if (node.Key == key) {
                    return node.Value;
                }
            }
            return null;
        }

        public static void Test() {
            var ht = new MyHashTable(10);
            ht.Insert("a",1);
            ht.Insert("bb",22);
            ht.Insert("ccc",333);
            var value = ht.Get("ccc");

            Console.WriteLine($"HashTable Value: {value}, {ht.Insert("ff",56)}");
        }
    }
}