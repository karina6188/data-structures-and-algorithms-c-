using System;
using System.Collections.Generic;
using System.Text;

namespace FindRepeatedWord
{
    public class Node
    {
        /// <summary>
        /// Key of the key/value pair
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// Value of the key/value pair
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Node's reference to the next node
        /// </summary>
        public Node Next { get; set; }

        /// <summary>
        /// Node constructor to specify the data stored on the node and a reference to the next node
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public Node(string key, string value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }
}
