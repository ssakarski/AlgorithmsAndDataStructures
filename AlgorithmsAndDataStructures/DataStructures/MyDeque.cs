using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.DataStructures
{
    public class MyDeque<T>
    {
        private class Node
        {
            public T element;
            public Node next;
            public Node prev;

            public Node(T item)
            {
                element = item;
                next = prev = null;
            }
            public Node()
            {

            }
        }

        private Node first, last;
        private int count = 0;

        public MyDeque()
        {

        }
        /// <summary>
        /// Check if the deque is empty
        /// </summary>
        /// <returns> Returns true if it's empty </returns>
        public bool IsEmpty()
        {
            return count == 0;
        }
        /// <summary>
        /// Returns the amount of elements inside the deque
        /// </summary>
        public int Count { get => count; }

        /// <summary>
        /// Add an item at the beggining of the deque
        /// </summary>
        /// <param name="item"> The item we wish to add </param>
        public void AddFirst(T item)
        {
            Node newNode = new Node(item);
            if (newNode.element == null)
            {
                throw new ArgumentNullException("This method doesnt accept null value");
            }
            if (first == null)
            {
                first = last = newNode;
            }
            else
            {
                newNode.next = first;
                first.prev = newNode;
                first = newNode;
            }
            count++;
        }
        /// <summary>
        /// Add an item to the last position of the deque
        /// </summary>
        /// <param name="item"> The item we wish to add </param>
        public void AddLast(T item)
        {
            Node newLast = new Node(item);
            if (newLast.element == null)
            {
                throw new ArgumentNullException("This method doesnt accept null value");
            }
            if (last == null)
            {
                last = first = newLast;
            }
            else
            {
                newLast.prev = last;
                last.next = newLast;
                last = newLast;
            }
            count++;
        }
        /// <summary>
        /// Remove the first element of the deque
        /// </summary>
        /// <returns> Returns the removed node value </returns>
        public T RemoveFirst()
        {
            if (count == 0)
            {
                throw new ArgumentOutOfRangeException("There are no items to be removed.");
            }

            Node temp = first;
            first = first.next;
            if (first == null)
            {
                last = null;
            }
            else
            {
                first.prev = null;
            }
            count--;
            return temp.element;
        }
        public T RemoveLast()
        {
            if (count == 0)
            {
                throw new ArgumentOutOfRangeException("There are no items to be removed.");
            }

            Node temp = last;
            last = last.prev;
            if (last == null)
            {
                first = null;
            }
            else
            {
                last.next = null;
            }
            count--;
            return temp.element;
        }

        public T PeekFirst()
        {
            if (count != 0)
            {
                return first.element;
            }
            else
            {
                throw new ArgumentOutOfRangeException("There are no items in the deque.");
            }
        }

        public T PeekLast()
        {
            if (count != 0)
            {
                return last.element;
            }
            else
            {
                throw new ArgumentOutOfRangeException("There are no items in the deque.");
            }
        }

        public void Clear()
        {
            while (first != null)
            {
                first = first.next;
            }
            last = null;
            count = 0;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }

                Node currentNode = first;

                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.next;
                }

                return currentNode.element;
            }
        }
    }
}
