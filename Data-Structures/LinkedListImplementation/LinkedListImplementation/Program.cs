using System;

namespace LinkedListImplementation
{
    class Program
    {
        /// <summary>
        /// First create an empty LinkedList named list1
        /// Then use Append method to add new nodes to list1
        /// Finally, use WriteLine and PrintList methods to print out the values in the linked list
        /// Use Includes method to check if a value exists in the linked list
        /// Use Insert method to add a value to the head of the linked list
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            LinkedList list1 = new LinkedList();
            list1.Append(1);
            list1.Append(2);
            list1.Append(3);
            list1.Append(4);
            list1.Append(5);

            Console.WriteLine("Use toString() method to represent all values: ");
            Console.WriteLine(list1.toString());
            Console.WriteLine("");

            Console.WriteLine("Find 3 in linked list? ");
            list1.PrintList();
            Console.WriteLine(list1.Includes(3));

            Console.WriteLine("");
            Console.WriteLine("Linked List: ");
            list1.PrintList();
            list1.Insert(10);
            Console.WriteLine("Insert to Head: ");
            list1.PrintList();
        }
    }
}
