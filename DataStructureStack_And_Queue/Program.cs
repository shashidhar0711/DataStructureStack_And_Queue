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
            /// Printing all elements
            linkedListStack.display();

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Values pushing into stack");

            /// It will return top element from stack without peek ie without deleteing
            linkedListStack.peek();
            /// Printing all element
            linkedListStack.display();

            /// It will return top element after deleting 
            linkedListStack.pop();
            linkedListStack.IsEmpty();

            /// Printing all elements
            linkedListStack.display();

        }
    }
}
