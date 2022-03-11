using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.DataStructures
{
    public class MyStack<T>
    {
        private int count = 0;
        private Node first = null;
        private class Node
        {
            public T Element;
            public Node next;
        }
        /// <summary>
        /// Add a new element at the top of the stack
        /// </summary>
        /// <param name="item"> The element to be added </param>
        public void Push(T item)
        {
            Node oldFirst = first;
            first = new Node();
            first.Element = item;
            first.next = oldFirst;
            count++;
        }
        /// <summary>
        /// Remove the element at the top of the stack
        /// </summary>
        /// <returns> Returns the value of the removed element </returns>
        public T Pop()
        {
            if (count > 0)
            {
                T item = first.Element;
                first = first.next;
                count--;
                return item;
            }
            else
            {
                throw new IndexOutOfRangeException("The stack cannot go below 0 arguments");
            }
        }
        /// <summary>
        /// Peek at the element at the top of the stack
        /// </summary>
        /// <returns> Returns the value of the element at the top </returns>
        public T Peek()
        {
           return first.Element;
        }
        /// <summary>
        /// Check if the stack is empty
        /// </summary>
        /// <returns> Returns true if it's empty </returns>
        public bool IsEmpty()
        {
            return count == 0 ;
        }
        /// <summary>
        /// Check the count of elements inside the stack
        /// </summary>
        public int Count { get => count; }
    }
}
