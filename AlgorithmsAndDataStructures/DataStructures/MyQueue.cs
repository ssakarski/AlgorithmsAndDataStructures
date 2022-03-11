using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.DataStructures
{
    public class MyQueue<T>
    {
        private class Node
        {
            public T item;
            public Node next;
        }

        private int count = 0;
        private Node first = null;
        private Node last = null;

        /// <summary>
        /// Adds an element to the front of the queue
        /// </summary>
        /// <param name="item"> Element to be added </param>
        public void Enqueue(T item)
        {
            Node node = new Node();
            node.item = item;

            if(last == null)
            {
                first = last = node;
                count++;
                return;
            }

            last.next = node;
            last = node;
            count++;
        }
        /// <summary>
        /// Removes an element from the back of the queue
        /// </summary>
        /// <returns> Returns the removed element </returns>
        public T Dequeue()
        {
            if(first == null)
            {
                throw new Exception("Cannot remove anymore elements.");
            }
            Node node = first;
            first = first.next;
            count--;

            return node.item;
        }
        /// <summary>
        /// Returns the count of the elements
        /// </summary>
        public int Count { get => count; }
        /// <summary>
        /// Check if the queue is empty
        /// </summary>
        /// <returns> Returns true if empty </returns>
        public bool IsEmpty()
        {
            return count == 0;
        }
    }
}
