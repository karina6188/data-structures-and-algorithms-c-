using System;

namespace HashTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Telephone area codes in the United States:");
            Hashtable hashtable = new Hashtable(10);
            hashtable.Add("Arkansas", "479");
            hashtable.Add("California", "510");
            hashtable.Add("Colorado", "303");
            hashtable.Add("Florida", "727");
            hashtable.Add("Georgia", "478");
            hashtable.Add("Hawaii", "808");
            hashtable.Add("Iowa", "641");
            hashtable.Add("Illinois", "309");
            hashtable.Add("Indiana", "574");
            hashtable.Add("Kentucky", "270");
            hashtable.Add("Massachusetts", "978");
            hashtable.Add("Michigan", "616");
            hashtable.Add("Minnesota", "763");
            hashtable.Add("North Carolina", "828");
            hashtable.Add("New Jersey", "973");
            hashtable.Add("New York", "585");
            hashtable.Add("Ohio", "330");
            hashtable.Add("Oklahoma", "405");
            hashtable.Add("Pennsylvania", "215");
            hashtable.Add("Texas", "432");
            hashtable.Add("Virginia", "804");
            hashtable.Add("Washington", "425");
            Console.WriteLine();
            hashtable.Get("Utah");
            hashtable.Get("Florida");
            hashtable.Get("New Jersey");
            hashtable.Get("South Dakota");
            hashtable.Get("Montana");
            hashtable.Get("Missouri");
            hashtable.Get("Kentucky");
            hashtable.Get("Colorado");
            hashtable.Get("California");
            hashtable.Get("Alabama");
            Console.WriteLine();
            Console.WriteLine($"Hashtable contains key \"Delaware\" ? {hashtable.Contains("Delaware")}");
            Console.WriteLine($"Hashtable contains key \"Iowa\" ? {hashtable.Contains("Iowa")}");
            Console.WriteLine($"Hashtable contains key \"Illinois\" ? {hashtable.Contains("Illinois")}");
            Console.WriteLine($"Hashtable contains key \"Maine\" ? {hashtable.Contains("Maine")}");
            Console.WriteLine($"Hashtable contains key \"North Carolina\" ? {hashtable.Contains("North Carolina")}");
            Console.WriteLine();
            Console.WriteLine($"Hash \"Kansas\" into bucket: {hashtable.Hash("Kansas")}");
            Console.WriteLine($"Hash \"Maryland\" into bucket: {hashtable.Hash("Maryland")}");
            Console.WriteLine($"Hash \"Tennessee\" into bucket: {hashtable.Hash("Tennessee")}");
            Console.WriteLine($"Hash \"Oregon\" into bucket: {hashtable.Hash("Oregon")}");
            Console.WriteLine($"Hash \"Alaska\" into bucket: {hashtable.Hash("Alaska")}");
        }
    }
}
