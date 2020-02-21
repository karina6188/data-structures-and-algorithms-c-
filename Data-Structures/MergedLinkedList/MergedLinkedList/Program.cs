using System;
using System.Collections.Generic;

namespace MergedLinkedList
{
    class Program
    {
        /// <summary>
        /// Create two linked lists in a sorted order and print out both linked lists to the console
        /// Call the MergeLists() method to merge the two linked lists together in a sorted order then print out the merged linked list to the console
        /// </summary>
        /// <param name="args"></param>
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
            Console.WriteLine();

            LinkedList<int> merged = MergeLists(list1, list2);

            Console.WriteLine("Merged linked list:");
            foreach (int number in merged)
            {
                Console.Write($"{number} -> ");
            }
            Console.WriteLine("x");
        }

        /// <summary>
        /// Takes in two linked lists with int data types and returns a single merged linked list at the end
        /// Check if the linked lists are empty
        /// Assign a linked list node to the head of both linked lists as a tracker
        /// Create an empty linked list called merged. This will be returned at the end once all the nodes from both lists are added in here in a sorted order
        /// While both linked lists have not yet reach to the end of the list, compare both linked lists' node values and add the smaller one to the merged linked list
        /// Keep doing this until either one of the linked list has reach to its end
        /// Check which linked list reaches to the end, and add all the nodes from the other linked list to the merged linked list
        /// </summary>
        /// <param name="listA"></param>
        /// <param name="listB"></param>
        /// <returns>A single merged linked list that the nodes values are sorted</returns>
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
            LinkedList<int> merged = new LinkedList<int>();

            while (currentA != null && currentB != null)
            {
                if (currentA.Value <= currentB.Value)
                {
                    merged.AddLast(currentA.Value);
                    currentA = currentA.Next;
                }
                else
                {
                    merged.AddLast(currentB.Value);
                    currentB = currentB.Next;
                }
            }
            if (currentA == null)
            {
                while (currentB != null)
                {
                    merged.AddLast(currentB.Value);
                    currentB = currentB.Next;
                }
            }
            if (currentB == null)
            {
                while (currentA != null)
                {
                    merged.AddLast(currentA.Value);
                    currentA = currentA.Next;
                }
            }
            return merged;
        }
    }
}
