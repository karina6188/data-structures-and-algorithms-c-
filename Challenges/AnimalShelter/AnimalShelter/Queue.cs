using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AnimalShelter
{
    public class Queue
    {
        public Stack stack1 = new Stack();
        public Stack stack2 = new Stack();

        public string existingAnimals()
        {
            stack1.Push("dog");
            stack1.Push("dog");
            stack1.Push("cat");
            stack1.Push("cat");
            stack1.Push("cat");
            string allAnimals = "";
            foreach (var number in stack1)
            {
                Console.WriteLine(number);
                allAnimals += number + " ";
            }
            return allAnimals;
        }

        public string enqueue(string animal)
        {
            if (animal == "dog" || animal == "cat")
            {
                while (stack1.Count > 0)
                {
                    stack2.Push(stack1.Pop());
                }
                stack1.Push(animal);
                while (stack2.Count > 0)
                {
                    stack1.Push(stack2.Pop());
                }
                string allAnimals = "";
                foreach (var number in stack1)
                {
                    Console.WriteLine(number);
                    allAnimals += number + " ";
                }
                return allAnimals;
            }
            else
            {
                return "The shelter only takes dogs or cats.";
            }
        }

        public string dequeue(string pref)
        {
            if (pref != "dog" && pref != "cat")
            {
                Console.WriteLine("null");
                return "null";
            }

            if (stack1.Count < 1)
            {
                Console.WriteLine("There is no animals in the shelter.");
            }
            else
            {
                while (stack1.Count > 0)
                {
                    stack2.Push(stack1.Pop());
                }
            }

            bool notFound = true;
            while (stack2.Count > 0)
            {
                string firstAnimal = stack2.Peek().ToString();
                while (notFound)
                {
                    if (firstAnimal == pref)
                    {
                        stack2.Pop();
                        notFound = false;
                    }
                    else
                    {
                        break;
                    }
                }
                stack1.Push(stack2.Pop());
            }
            Console.WriteLine($"Result of method deenqueue({pref}): ");
            string remainingAnimals = "";
            foreach (var animal in stack1)
            {
                Console.WriteLine(animal);
                remainingAnimals += animal + " ";
            }
            return remainingAnimals;
        }
    }
}
