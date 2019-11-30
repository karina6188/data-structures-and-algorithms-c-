using System;
using System.Collections.Generic;
using System.Text;

namespace HashTables
{
    class Hashtable
    {
        /// <summary>
        /// Set how many buckets are there in the hashtable
        /// </summary>
        public int Buckets { get; set; }

        /// <summary>
        /// Create a Node array to store multitple key/value pairs in each bucket
        /// </summary>
        public Node[] HashNode { get; set; }

        /// <summary>
        /// Hashtable constructor to set up the quantity for buckets and set up the same amount of node arrays to match the bucket quantity
        /// </summary>
        /// <param name="buckets"></param>
        public Hashtable(int buckets)
        {
            Buckets = buckets;
            HashNode = new Node[buckets];
        }

        /// <summary>
        /// Takes in a key and a value.
        /// First, it calls Hash() method and sends over the key to get an index position inside the hashtable.
        /// Check if the index position already has the key. If yes, print to console window that the key already exists. Otherwise, stores the key/value pair data to the corresponding bucket and into the next available node.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(string key, string value)
        {
            int index = Hash(key);

            if (Contains(key))
            {
                Console.WriteLine($"Key \"{key}\" already exists in bucket No.{index}\n");
            }
            else
            {
                if (HashNode[index] == null)
                {
                    Node newNode = new Node(key, value);
                    HashNode[index] = newNode;
                    Console.WriteLine($"Add key/value \"{key}/{value}\" in bucket No.{index}");
                }
                else
                {
                    Node newNode = new Node(key, value);
                    Node current = HashNode[index];
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }
                    current.Next = newNode;
                    Console.WriteLine($"Add key/value \"{key}/{value}\" in bucket No.{index}");
                }
            }
        }

        static string Get(string key)
        {
            string value = "";
            return value;
        }

        static bool Contains(string key)
        {
            
            return true;
        }

        static int Hash(string key)
        {
            int index = 0;
            return index;
        }
    }
}
