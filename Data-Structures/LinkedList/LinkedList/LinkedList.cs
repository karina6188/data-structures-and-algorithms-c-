using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
    public class LinkedList
    {
        public Node Head { get; set; }

        // Constructor
        public LinkedList()
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
                TestAppend(newNode);
                return TestAppend(newNode);
            }
        }

        /// <summary>
        /// This method takes in two arguments, one integer of value and one integer of new value.
        /// Create a new node with the new value.
        /// If the linked list is empty
        /// </summary>
        /// <param name="value"></param>
        /// <param name="newVal"></param>
        /// <returns></returns>
        public bool InsertBefore(int value, int newVal)
        {
            Node newNode = new Node(newVal);

            if (Head == null)
            {
                Head = newNode;
                return true;
            }
            else
            {
                Node previous = Head;
                Node current = Head.Next;
                while (current!= null && current.Data != value)
                {
                    current = current.Next;
                }
                if (current.Data == value)
                {
                    previous.Next = newNode;
                    newNode.Next = current;
                }
                TestInsertBefore(value, previous, current, newNode);
                return TestInsertBefore(value, previous, current, newNode);
            }
        }

        public bool InsertAfter(int value, int newVal)
        {
            Node newNode = new Node(newVal);

            if (Head == null)
            {
                Head = newNode;
                return true;
            }
            else
            {
                Node current = Head;
                while (current != null && current.Data != value)
                {
                    current = current.Next;
                }
                if (current.Data == value)
                {
                    current.Next = newNode;
                    newNode.Next = current.Next;
                }
                TestInsertAfter(value, current, newNode);
                return TestInsertAfter(value, current, newNode);
            }
        }

        public bool TestAppend(Node newNode)
        {
            if (newNode.Next == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TestInsertBefore(int value, Node previous, Node current, Node newNode)
        {
            if (current.Data == value)
            {
                previous.Next = newNode;
                newNode.Next = current;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TestInsertAfter(int value, Node current, Node newNode)
        {
            if (current.Data == value)
            {
                if (current.Next == newNode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
