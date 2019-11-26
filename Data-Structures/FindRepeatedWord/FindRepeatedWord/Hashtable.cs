using System;
using System.Collections.Generic;
using System.Text;

namespace FindRepeatedWord
{
    public class Hashtable
    {
        /// <summary>
        /// Set how many buckets are there in the hashtable
        /// </summary>
        public int Buckets { get; set; }

        /// <summary>
        /// Create a Node array to store multitple key/value pairs in each bucket
        /// </summary>
        public Node[] Node { get; set; }

        /// <summary>
        /// Hashtable constructor to set up the quantity for buckets and set up the same amount of node arrays to match the bucket quantity
        /// </summary>
        /// <param name="buckets"></param>
        public Hashtable(int buckets)
        {
            Buckets = buckets;
            Node[] node = new Node[buckets];
            Node = node;
        }

        /// <summary>
        /// Takes in a lengthy string and a key.
        /// First, it calls Hash() method and sends over the key to get an index position inside the hashtable.
        /// Check if the index position already has the key. If yes, print to console window that the key already exists. Otherwise, stores the key/value pair data to the corresponding bucket and into the next available node.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(string key, string value)
        {
            int index = Hash(key);

            if (!Contains(key))
            {
                Node newNode = new Node(key, value);
                if (Node[index] == null)
                {
                    Node[index] = newNode;
                    Console.WriteLine($"Added new key/value pair \"{key}/{value}\" in bucket No.{index}");
                }
                else
                {
                    while (Node[index].Next != null)
                    {
                        Node[index].Next = Node[index];
                    }
                    Node[index].Next = newNode;
                    Console.WriteLine($"Added new key/value pair \"{key}/{value}\" in bucket No.{index}");
                }
            }
            else
            {
                Console.WriteLine($"The key \"{key}\" already exists in bucket No.{index}");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string Get(string key)
        {
            string returnedText = "The key cannot be found";
            int index = Hash(key);
            if (Node[index] == null) return returnedText;
            if (Node[index] != null)
            {
                if (Node[index].Key == key)
                {
                    return Node[index].Value;
                }
                else
                {
                    while (Node[index].Next != null)
                    {
                        if (Node[index].Key == key) return Node[index].Value;
                        Node[index] = Node[index].Next;
                    }
                }
            }
            return returnedText;
        }

        /// <summary>
        /// Calls Hash() method first to get the index position inside the hashtable.
        /// Check the node list at the index position. If the node list is empty, return false.
        /// If not empty, check if the first node's key matches with the finding key. If yes, return true.
        /// If not, while the node.Next is not empty, runs down the node list and check every node's key if it matches with the finding key. If yes, return true.
        /// Otherwise, if all the nodes on the node list are checked and still not find the finding key, return false.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Contains(string key)
        {
            int index = Hash(key);
            if (Node[index] == null)
            {
                return false;
            }
            else
            {
                if (Node[index].Key == key) return true;
                while (Node[index].Next != null)
                {
                    if (Node[index].Key == key)
                    {
                        return true;
                    }
                    Node[index] = Node[index].Next;
                }
                return false;
            }
        }

        /// <summary>
        /// Takes in a string key and get the ASCII numbers for the key and store the values into a byte array.
        /// Loop through the byte array and adds up the values then times 1024 and modulus 1147 and modulus the number of buckets.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
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
