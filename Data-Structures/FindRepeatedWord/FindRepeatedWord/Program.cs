﻿using System;

namespace FindRepeatedWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable(5);
            int index = hashtable.Hash("dictionary");
            hashtable.Add("applebee", "applebee");
            hashtable.Add("applebee", "applebee");
            hashtable.Add("beeapple", "beeapple");
        }

        static string RepeatedWord(string text)
        {
            string defaultText = "No repeated word is found";
            return defaultText;
        }
    }
}
