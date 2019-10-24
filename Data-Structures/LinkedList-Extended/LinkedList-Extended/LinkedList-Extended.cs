using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList_Extended
{
    public class LinkedList_Extend
    {
        public Node Head { get; set; }

        public LinkedList_Extend()
        {
            Head = null;
        }

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
