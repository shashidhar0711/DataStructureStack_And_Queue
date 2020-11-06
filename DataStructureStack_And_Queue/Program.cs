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
            /// Creating Refernce of object class
            LinkedListStack linkedListStack = new LinkedListStack();

            /// Adding elements in to stack
            linkedListStack.push(70);
            linkedListStack.push(30);
            linkedListStack.push(56);

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Values pushing into stack");

            /// Printing all elements
            linkedListStack.display();
        }
    }
}
