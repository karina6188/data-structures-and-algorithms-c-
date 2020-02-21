using System;
using System.Collections.Generic;

namespace MergedLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list1 = new LinkedList<int>();
            list1.AddLast(10);
            list1.AddLast(6);
            list1.AddLast(4);
            list1.AddLast(3);

            Console.WriteLine("Linked List 1:");
            foreach(int number in list1)
            {
                Console.WriteLine($"{number} -> ");
            }
            Console.WriteLine("x");

            LinkedList<int> list2 = new LinkedList<int>();
            list2.AddLast(13);
            list2.AddLast(8);
            list2.AddLast(5);
            list2.AddLast(4);
            list2.AddLast(3);
            list2.AddLast(2);

            Console.WriteLine("Linked List 1:");
            foreach (int number in list1)
            {
                Console.WriteLine($"{number} -> ");
            }
            Console.WriteLine("x");

            MergeLists(list1, list2);
        }

        static LinkedList<int> MergeLists(LinkedList<int> list1, LinkedList<int> list2)
        {
            if (list1.First == null) return null;
        }
    }
}
