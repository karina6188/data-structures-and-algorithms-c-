using System;
using System.Collections.Generic;
using System.Text;

namespace HashTables
{
    public class HashTable
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
        public HashTable(int buckets)
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

        /// <summary>
        /// Set default string to return if the key is not found.
        /// Call Hash() method to get the index position inside the hashtable.
        /// If the node list in the bucket is empty, return default string.
        /// If the node list is not empty, check if the first node has the finding key. If yes, return the node's value.
        /// If not, while the node.Next is not null, keep looping through the node list and look for the finding key. If finds it, return that node's value.
        /// If not, return the default string.
        /// </summary>
        /// <param name="key"></param>
        /// <returns>A string of either "the key is not found" or the value to the key if found</returns>
        public string Get(string key)
        {
            string returnedText = $"Cannot find key \"{key}\"";
            int index = Hash(key);
            if (HashNode[index] == null)
            {
                Console.WriteLine(returnedText);
                return returnedText;
            }
            if (HashNode[index] != null)
            {
                if (HashNode[index].Key == key)
                {
                    Console.WriteLine($"Found the key \"{key}\"");
                    return HashNode[index].Value;
                }
                else
                {
                    Node current = HashNode[index];
                    while (current.Next != null)
                    {
                        current = current.Next;
                        if (current.Key == key)
                        {
                            Console.WriteLine($"Found the key \"{key}\"");
                            return current.Value;
                        }
                    }
                }
            }
            Console.WriteLine(returnedText);
            return returnedText;
        }

        /// <summary>
        /// Call Hash() method first to get the index position inside the hashtable.
        /// Check the node list at the index position. If the node list is empty, return false.
        /// If not empty, check if the first node's key matches with the finding key. If yes, return true.
        /// If not, while the node.Next is not empty, runs down the node list and check every node's key if it matches with the finding key. If yes, return true.
        /// Otherwise, if all the nodes on the node list are checked and still not find the finding key, return false.
        /// </summary>
        /// <param name="key"></param>
        /// <returns>A boolean if the hashtable contains the key</returns>
        public bool Contains(string key)
        {
            int index = Hash(key);
            if (HashNode[index] == null)
            {
                return false;
            }
            else
            {
                Node current = HashNode[index];
                if (HashNode[index].Key == key) return true;
                while (current.Next != null)
                {
                    current = current.Next;
                    if (current.Key == key)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        /// <summary>
        /// Takes in a string key and get the ASCII numbers for the key and store the values into a byte array.
        /// Loop through the byte array and adds up the values then times 1024 and modulus 1147 and modulus the number of buckets.
        /// </summary>
        /// <param name="key"></param>
        /// <returns>An integer indicating the index position of the hashtable</returns>
        public int Hash(string key)
        {
            int index;
            byte[] asciiBytes = Encoding.ASCII.GetBytes(key);
            int letterNumber = 0;
            for (int i = 0; i < asciiBytes.Length; i++)
            {
                letterNumber += asciiBytes[i];
            }
            index = letterNumber * 1024 % 1147 % Buckets;
            return index;
        }
    }
}
