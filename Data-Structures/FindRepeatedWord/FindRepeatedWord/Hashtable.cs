﻿using System;
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
        }

        /// <summary>
        /// Takes in a lengthy string and a key.
        /// First, it calls Hash() method and sends over the key to get an index position inside the hashtable.
        /// Then stores the key/value pair data to the corresponding index position and in a linked list.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void Add(string key, string value)
        {
            int index = Hash(key);

        }

        public string Get(string key)
        {
            string defaultText = "The key cannot be found";
            return defaultText;
        }

        public bool Contains(string key)
        {
            return true;    
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
