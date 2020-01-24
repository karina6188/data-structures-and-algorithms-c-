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
        /// If the linked list is empty, assign the Head of the linked list to be the new node with the new value and return true to break out the method.
        /// If the linked list is not empty, traverse the linked list by assigning a tracker node of Head and Head's Next node.
        /// While the node is not null and the current node's value is not the value that you are inserting before, move the tracker to the next node.
        /// Keep doing this until you either find the value you are looking for or you reach to the end of the linked list which means the value you are looking for does not exist.
        /// Then you will break out of the while loop.
        /// If the value is found, assign the current node's Next to be the new node, and the new node's Next value to be nextUp.
        /// Now the new node has been inserted.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="newVal"></param>
        /// <returns>A boolean if a new node is being inserted</returns>
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
                Node current = Head;
                Node nextUp = Head.Next;
                while (nextUp!= null && nextUp.Data != value)
                {
                    nextUp = nextUp.Next;
                }
                if (nextUp.Data == value)
                {
                    current.Next = newNode;
                    newNode.Next = nextUp;
                }
                TestInsertBefore(value, current, nextUp, newNode);
                return TestInsertBefore(value, current, nextUp, newNode);
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
