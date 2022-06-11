using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Stack_HashSet
{
    public class _Queue
    {
        public void QueueNotGeneric()
        {
            // Create a queue
            // Using Queue class
            Queue my_queue = new Queue();

            // Adding elements in Queue
            // Using Enqueue() method
            my_queue.Enqueue("GFG");
            my_queue.Enqueue(1);
            my_queue.Enqueue(100);
            my_queue.Enqueue(2.4);
            my_queue.Enqueue("Geeks123");

            Console.WriteLine("Total elements present in my_queue: {0}",
                                                        my_queue.Count);
            my_queue.Dequeue();

            // After Dequeue method
            Console.WriteLine("Total elements present in my_queue: {0}",
                                                        my_queue.Count);

            // Remove all the elements from the queue
            my_queue.Clear();

            // After Clear method
            Console.WriteLine("Total elements present in my_queue: {0}",
                                                        my_queue.Count);

            my_queue.Enqueue("GFG");
            my_queue.Enqueue("Geeks");
            my_queue.Enqueue("GeeksforGeeks");
            my_queue.Enqueue("geeks");
            my_queue.Enqueue("Geeks123");

            Console.WriteLine("Total elements present in my_queue: {0}",
                                                        my_queue.Count);

            // Obtain the topmost element of my_queue
            // Using Dequeue method
            Console.WriteLine("Topmost element of my_queue"
                         + " is: {0}", my_queue.Dequeue());


            Console.WriteLine("Total elements present in my_queue: {0}",
                                                        my_queue.Count);

            // Obtain the topmost element of my_queue
            // Using Peek method
            Console.WriteLine("Topmost element of my_queue is: {0}",
                                                   my_queue.Peek());

            Console.WriteLine("Total elements present in my_queue: {0}",
                                                        my_queue.Count);
        }
    }
}

