using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AnimalShelter
{
    public class Queue
    {
        /// <summary>
        /// Create two stacks to put animals
        /// </summary>
        public Stack stack1 = new Stack();
        public Stack stack2 = new Stack();

        /// <summary>
        /// This method takes no parameter and returns a string to indicate how many animals are in the stack
        /// First, push all the existing animals into stack 1 using the pre-determined Push method
        /// For each animal in the stack, write to the console of each animal
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// This method takes a parameter of a string data type and returns a string
        /// If the animal from the parameter is either a dog or a cat, while stack 1 is not empty, keep popping the dogs and cats from stack 1 and push them to stack 2 until all the animals from stack 1 have been popped
        /// Now stack 1 is empty. Push the animal from the parameter to stack 1
        /// Then while stack 2 is not empty, keep popping all the animals from stack 2 to stack 1
        /// Finally, write to the console of all the animals in the stack 1
        /// </summary>
        /// <param name="animal"></param>
        /// <returns>A string to show cats and dogs in the stack. If an animal that is neither a cat nor a dog that is pushed to the stack, the string shows a message of "The shelter only takes dogs or cats"</returns>
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
