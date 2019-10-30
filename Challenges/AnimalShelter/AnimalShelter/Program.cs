using System;

namespace AnimalShelter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            Console.WriteLine("Existing animals in the shelter: ");
            queue.existingAnimals();
            Console.WriteLine("\n");
            Console.WriteLine("Result of method enqueue(dog): ");
            Console.WriteLine("Stack values: ");
            queue.enqueue("dog");
            Console.WriteLine("\n");
            queue.dequeue("cat");
        }
    }
}
