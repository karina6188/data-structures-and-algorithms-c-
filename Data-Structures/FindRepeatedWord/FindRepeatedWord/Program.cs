using System;

namespace FindRepeatedWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable(50);
            int index = Hashtable.Hash("complication");
            Console.WriteLine(index);
        }

        static string RepeatedWord(string text)
        {
            string defaultText = "No repeated word is found";
            return defaultText;
        }
    }
}
