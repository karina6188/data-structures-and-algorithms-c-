using System;
using System.Collections.Generic;
using System.Text;

namespace FindRepeatedWord
{
    public class Hashtable
    {
        public int Buckets { get; set; }

        public Node Node { get; set; }

        public Hashtable(int buckets)
        {
            Hashtable[] hashtable = new Hashtable[buckets];
            Buckets = buckets;
            
        }
        /// <summary>
        /// Takes in a lengthy string and a key.
        /// First, it calls Hash() method and sends over the key to get an index position inside the hashtable.
        /// Then stores the key/value pair data to the corresponding index position and in a linked list.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        static void Add(string key, string value)
        {
            int index = Hash(key);

        }

        static string Get(string key)
        {
            string defaultText = "The key cannot be found";
            return defaultText;
        }

        static bool Contains(string key)
        {
            return true;    
        }

        public static int Hash(string key)
        {
            int index;
            byte[] asciiBytes = Encoding.ASCII.GetBytes(key);
            int letterNumber = 0;
            for (int i = 0; i < asciiBytes.Length; i++)
            {
                letterNumber += asciiBytes[i];
            }
            index = letterNumber * 1024 % Buckets;
            return index;
        }
    }
}
