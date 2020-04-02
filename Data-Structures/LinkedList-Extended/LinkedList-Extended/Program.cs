using System;
using System.Collections.Generic;

namespace LinkedList_Extended
{
    public class Program
    {
        /// <summary>
        /// First create an empty LinkedList named linkedlist
        /// Then use Append method to add new nodes to linkedlist
        /// Finally, use ReadValueFromEnd method to read the node's value from the end of the linked list. The argument specifies which node from the end to read the value.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            LinkedList_Extend linkedlist = new LinkedList_Extend();
            linkedlist.Append(1);
            linkedlist.Append(2);
            linkedlist.Append(3);
            linkedlist.Append(4);
            linkedlist.Append(5);
            linkedlist.Append(6);
            linkedlist.ReadValueFromEnd(2);
        }
    }
}
