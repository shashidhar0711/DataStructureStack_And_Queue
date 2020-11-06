using System;

namespace DataStructureStack_And_Queue
{
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            /// Creating Reference of object Queue
            LinkedListQueue linkedListQueue = new LinkedListQueue();

            /// Adding elements into Queue
            linkedListQueue.EnQueue(70);
            linkedListQueue.EnQueue(50);
            linkedListQueue.EnQueue(36);

            /// Printing all the elements
            linkedListQueue.Display();
        }
    }
}
