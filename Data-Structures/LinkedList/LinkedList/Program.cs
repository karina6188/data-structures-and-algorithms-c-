using System;
using System.Collections.Generic;

namespace LinkedLists
{
    public class Program
    {
        /// <summary>
        /// First create an empty LinkedList named linkedlist
        /// Then use Append method to add new nodes to linkedlist
        /// Finally, use InsertBefore method to insert a new node with a value of 10 before the node with a value of 5
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            LinkedList linkedlist = new LinkedList();
            linkedlist.Append(1);
            linkedlist.Append(2);
            linkedlist.Append(3);
            linkedlist.Append(4);
            linkedlist.Append(5);
            linkedlist.Append(6);
            linkedlist.InsertBefore(5, 10);
        }
    }
}
