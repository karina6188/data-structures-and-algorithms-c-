using System;
using System.Collections.Generic;
using System.Text;

namespace FindRepeatedWord
{
    class Hashtable
    {
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

        static int Hash(string key)
        {
            int index = 0;
            return index;
        }
    }
}
