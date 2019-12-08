using System;
using System.Collections.Generic;
using System.Text;

namespace LeftJoinHashtables
{
    public class HashTable
    {
        public int Buckets { get; set; }

        public Node[] HashNode { get; set; }

        public HashTable(int buckets)
        {
            Buckets = buckets;
            HashNode = new Node[buckets];
        }

        public void AddNode(string key, string value)
        {
            for (int i = 0; i < HashNode.Length; i++)
            {
                if (HashNode[i] == null)
                {
                    Node newNode = new Node(key, value);
                    HashNode[i] = newNode;
                    break;
                }
            }
        }

        public int Contains(string key)
        {
            for (int i = 0; i < HashNode.Length; i++)
            {
                if (HashNode[i].Key == key)
                {
                    return i;
                }
            }
            return -1;
        }

        public string Get(string key)
        {
            for (int i = 0; i < HashNode.Length; i++)
            {
                if (HashNode[i].Key == key)
                {
                    return HashNode[i].Value;
                }
            }
            return "null";
        }

        public void PrintTable(HashTable hashtable)
        {
            Console.WriteLine($"There are {hashtable.Buckets} words in this table");
            Console.WriteLine("Keys:           Values:        ");
            for (int i = 0; i < hashtable.Buckets; i++)
            {
                Console.WriteLine(hashtable.HashNode[i].Key);
                Console.Write(hashtable.HashNode[i].Value);
            }
        }
    }
}
