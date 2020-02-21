using System;
using System.Collections.Generic;

namespace MergedLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list1 = new LinkedList<int>();
            list1.AddLast(3);
            list1.AddLast(4);
            list1.AddLast(6);
            list1.AddLast(10);

            Console.WriteLine("Linked list 1:");
            foreach(int number in list1)
            {
                Console.Write($"{number} -> ");
            }
            Console.WriteLine("x");
            Console.WriteLine();

            LinkedList<int> list2 = new LinkedList<int>();
            list2.AddLast(2);
            list2.AddLast(3);
            list2.AddLast(4);
            list2.AddLast(5);
            list2.AddLast(8);
            list2.AddLast(13);

            Console.WriteLine("Linked list 2:");
            foreach (int number in list2)
            {
                Console.Write($"{number} -> ");
            }
            Console.WriteLine("x");

            //MergeLists(list1, list2);
        }

        static LinkedList<int> MergeLists(LinkedList<int> listA, LinkedList<int> listB)
        {
            if (listA.First == null)
            {
                Console.WriteLine("Linked list 1 is empty");
                return null;
            }
            if (listB.First == null)
            {
                Console.WriteLine("Linked list 2 is empty");
                return null;
            }
            LinkedListNode<int> currentA = listA.First;
            LinkedListNode<int> currentB = listB.First;

            while (currentA.Next != null && currentB.Next != null)
            {

            }

            return null;
        }
    }
}
