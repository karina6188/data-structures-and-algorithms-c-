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
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }
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
