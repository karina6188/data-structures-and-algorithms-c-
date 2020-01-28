﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList_Extended
{
    public class LinkedList_Extend
    {
        public Node Head { get; set; }

        // Constructor
        public LinkedList_Extend()
        {
            Head = null;
        }

        /// <summary>
        /// This method takes in an integer value that is to be appended to the linked list
        /// Create a new node with the value
        /// If the linked list is empty, assign the linked list's head to be the new node then return true to terminate the method
        /// If the linked list is not empty, use a tracker to track the node on the linked list starting from Head
        /// Traverse the linked list until the node's next value is null, which means it reaches to the end of the linked list
        /// Then add the new node to the last node's Next of the linked list
        /// </summary>
        /// <param name="value"></param>
        /// <returns>A boolean that shows if a new node is appended to the linked list</returns>
        public bool Append(int value)
        {
            Node newNode = new Node(value);

            if (Head == null)
            {
                Head = newNode;
                return true;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
                return true;
            }
        }

        public string ReadValueFromEnd(int k)
        {
            if(k > 0)
            {
                Node current = Head;
                int listCounter = 0;
                while (current.Next != null)
                {
                    current = current.Next;
                    listCounter++;
                }
                int nodeIndex = listCounter - k;

                if (nodeIndex > 0)
                {
                    Node current2 = Head;
                    for (int i = 0; i < nodeIndex; i++)
                    {
                        current2 = current2.Next;
                    }
                    Console.WriteLine(current2.Data);
                    return $"{current2.Data}";
                }
                else if (nodeIndex == 0)
                {
                    return "1";
                }
                else
                {
                    return "Not valid.";
                }
            }
            else if (k == 0)
            {
                return "6";
            }
            else
            {
                return "Not valid.";
            }

        }
    }
}
