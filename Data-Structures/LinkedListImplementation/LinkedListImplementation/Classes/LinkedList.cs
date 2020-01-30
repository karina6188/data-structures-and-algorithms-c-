using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListImplementation
{
    public class LinkedList
    {
        public Node Head { get; set; }

        public LinkedList()
        {
            Head = null;
        }

        /// <summary>
        /// This method takes in an argument of a integer data type, which represents a node's value
        /// Create a new node with the value from the argument
        /// If the linked list is empty, assign the Head of the linked list to be the new node, then return the Head's data and exit the method
        /// If the linked list is not empty, assign a node tracker named current to be the Head, so the Head's value is saved in this node
        /// Then assign the Head to be the new node with the value from the argument, and assign the Head's Next to be the old Head which is node "current"
        /// </summary>
        /// <param name="value"></param>
        /// <returns>An integer of the linked list' Head data to indicate if a new value is actually inserted to the Head of the linked list</returns>
        public int Insert(int value)
        {
            try
            {
                Node newNode = new Node(value);

                if (Head == null)
                {
                    Head = newNode;
                    return Head.Data;
                }
                else
                {
                    Node current = Head;
                    Head = newNode;
                    Head.Next = current;
                    return Head.Data;
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("The argument format is not valid.");
                return 0;
            }
        }

        public int InsertTest(int value)
        {
            Node newNode = new Node(value);

            if (Head == null)
            {
                Head = newNode;
                return Head.Data;
            }
            else
            {
                Node current = Head;
                Head = newNode;
                Head.Next = current;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                return Head.Next.Data;
            }
        }

        public bool Includes(int value)
        {
            try
            {
                if (Head == null)
                {
                    return false;
                }
                else
                {
                    Node current = Head;
                    while (current.Next != null)
                    {
                        if (current.Data == value)
                        {
                            return true;
                        }
                        current = current.Next;
                    }
                    return false;
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("The argument format is not valid.");
                return false;
            }
        }

        public string toString()
        {
            try
            {
                if (Head == null)
                {
                    return "The linked list is empty.";
                }
                else
                {
                    Node current = Head;
                    string result = "";
                    while (current.Next != null)
                    {
                        result += current.Data.ToString() + " --> ";
                        current = current.Next;
                    }
                    result += current.Data.ToString();
                    return result;
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                return "The argument format is not valid.";
            }
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
            try
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
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("The argument format is not valid.");
                return false;
            }
        }

        public int PrintList()
        {
            try
            {
                Node current = Head;
                int numberOfNodes = 1;
                while (current.Next != null)
                {
                    Console.Write(current.Data + " --> ");
                    current = current.Next;
                    numberOfNodes++;
                }
                Console.WriteLine(current.Data);
                return numberOfNodes;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("There is no value in the linked list to be printed out.");
                return 0;
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
    }
}
