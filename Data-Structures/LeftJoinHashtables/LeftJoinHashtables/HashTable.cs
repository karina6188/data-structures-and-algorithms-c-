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

        /// <summary>
        /// Takes in a key and a value of string type then loop through the total number of buckets in a hash table
        /// If the bucket is empty, add the key/value pair into the bucket
        /// Otherwise, move to the next available bucket then add the new node into the bucket
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
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

        /// <summary>
        /// Takes in a key then loop through all the buckets
        /// If the bucket is empty, return -1 to indicate the key is not found
        /// If the bucket has a node, check if the node's key matches with the finding key
        /// If yes, return the current index position of the bucket where the key is found
        /// </summary>
        /// <param name="key"></param>
        /// <returns>The index position of the buckets where the key is found. If not found, return -1</returns>
        public int Contains(string key)
        {
            for (int i = 0; i < HashNode.Length; i++)
            {
                if (HashNode[i] == null) return -1;
                if (HashNode[i].Key == key)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
