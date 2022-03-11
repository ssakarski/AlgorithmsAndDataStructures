using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.DataStructures
{
    /// <summary>
    /// Linked list class definition
    /// </summary>
    public class LinkedList<T>
    {
        private class Node
        {
            public T Element { get; set; }
            public Node nextNode { get; set; }

            public Node(T element, Node prevNode)
            {
                Element = element;
                prevNode.nextNode = this;
            }

            public Node(T element)
            {
                Element = element;
                nextNode = null;
            }
        }


        private Node head;
        private Node tail;
        private int count;

        public LinkedList()
        {
            head = null;
            tail = null;
            count = 0;
        }

        /// <summary>
        /// Adding the element to the end of the list
        /// </summary>
        /// <param name="item"> Element to be added </param>
        public void Add (T item)
        {
            if(head == null)
            {
                // If the list is empty create a new head and tail
                head = new Node(item);
                tail = head;
            }
            else
            {
                // If the list is not empty Append the item after the tail
                Node newNode = new Node(item, tail);
                tail = newNode;
            }

            count++;
        }
        /// <summary>
        /// Removing the element at the current index
        /// </summary>
        /// <param name="index"> Index at which we wish to remove the element </param>
        /// <returns> Removes and returns the value of the element at given index </returns>
        public T RemoveAt(int index)
        {
            if(index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }

            //Finding the element at the given index

            int currentIndex = 0;
            Node currentNode = head;
            Node prevNode = null;

            while(currentIndex < index)
            {
                prevNode = currentNode;
                currentNode = currentNode.nextNode;
                currentIndex++;
            }
            RemoveNode(currentNode, prevNode);

            return currentNode.Element;
        }
        /// <summary>
        /// Remove the given node from the list
        /// </summary>
        /// <param name="node"> The node for removal </param>
        /// <param name="prevNode"> The previous node </param>
        private void RemoveNode(Node node, Node prevNode)
        {
            count--;
            if (count == 0)
            {
                // The list becomes empty -> remove head and tail
                head = null;
                tail = null;
            }
            else if(prevNode == null)
            {
                // The head node was removed -> update the head
                head = node.nextNode;
            }
            else
            {
                // Redirect the pointers to skip the removed node
                prevNode.nextNode = node.nextNode;
            }
            // Fix the tail in case it was removed
            if (object.ReferenceEquals(tail,node))
            {
                tail = prevNode;
            }
        }
        /// <summary>
        /// Remove the given element
        /// </summary>
        /// <param name="item"> The element to remove </param>
        /// <returns> Returns the element's index or -1 if not found </returns>
        public int Remove (T item)
        {
            // Find the element containing the searched item
            int currentIndex = 0;
            Node currentNode = head;
            Node prevNode = null;

            while (currentNode != null)
            {
                if(object.Equals(currentNode.Element,item))
                {
                    break;
                }

                prevNode = currentNode;
                currentNode = currentNode.nextNode;
                currentIndex++;
            }

            if (currentNode != null)
            {
                // Element is found in the list -> remove it
                RemoveNode(currentNode, prevNode);
                return currentIndex;
            }
            else
            {
                // Element is not found in the list -> return -1
                return -1;
            }
        }
        /// <summary>
        /// Look up the index of a given element
        /// </summary>
        /// <param name="item"> The element whose index we want </param>
        /// <returns> Returns the index of the element or -1 if not found </returns>
        public int IndexOf(T item)
        {
            int index = 0;
            Node currentNode = head;

            while (currentNode != null)
            {
                if(object.Equals(currentNode.Element,item))
                {
                    return index;
                }

                currentNode = currentNode.nextNode;
                index++;
            }

            return -1;
        }
        /// <summary>
        /// Search the list for the item
        /// </summary>
        /// <param name="item"> Item we are looking for </param>
        /// <returns> Returns true if found </returns>
        public bool Contains(T item)
        {
            int index = IndexOf(item);
            bool found = (index != -1);

            return found;
        }
        /// <summary>
        /// Gets or sets the element at the specified position
        /// </summary>
        /// <param name="index"> The position at which we want the element </param>
        /// <returns> Returns the object at the given index </returns>
        public T this[int index]
        {
            get
            {
                if(index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }

                Node currentNode = head;

                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.nextNode;
                }

                return currentNode.Element;
            }

            set
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }

                Node currentNode = head;

                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.nextNode;
                }

                currentNode.Element = value;
            }
        }

        /// <summary>
        /// Returns the count of all elements
        /// </summary>
        public int Count => count;
    }
}
