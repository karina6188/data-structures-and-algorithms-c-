using System;
using System.Collections;

namespace FindRepeatedWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable(5);
            hashtable.Add("applebee", "applebee");
            hashtable.Add("andy", "andy");
            hashtable.Add("karina", "karina");
            hashtable.Add("thomas", "thomas");
            hashtable.Add("porkee", "porkee");
            hashtable.Add("wendy", "wendy");
            Console.WriteLine();
            hashtable.Get("andy");
            hashtable.Get("carrie");
            hashtable.Get("wendy");
            hashtable.Get("karina");
            hashtable.Get("sylvia");
            Console.WriteLine();
            Console.WriteLine($"Hashtable contains key \"applebee\" ? {hashtable.Contains("applebee")}");
            Console.WriteLine($"Hashtable contains key \"karina\" ? {hashtable.Contains("karina")}");
            Console.WriteLine($"Hashtable contains key \"thomas\" ? {hashtable.Contains("thomas")}");
            Console.WriteLine($"Hashtable contains key \"thomas\" ? {hashtable.Contains("thomas")}");
            Console.WriteLine($"Hashtable contains key \"porkee\" ? {hashtable.Contains("porkee")}");
            Console.WriteLine();
            Console.WriteLine($"Hash \"elephant\" into bucket: {hashtable.Hash("elephant")}");
            Console.WriteLine($"Hash \"tiger\" into bucket: {hashtable.Hash("tiger")}");
        }

        static string RepeatedWord(string text)
        {
            string defaultText = "No repeated word is found";
            return defaultText;
        }
    }
}
