using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.DataStructures
{
    public class UnorderedMaxPriorityQueue
    {
        private int[] pq;
        private int count;
        /// <summary>
        /// Initialize the MP queue and set it's capacity
        /// </summary>
        /// <param name="capacity"></param>
        public UnorderedMaxPriorityQueue(int capacity)
        {
            pq = new int[capacity];
        }
        /// <summary>
        /// Check to see if the MP queue is empty
        /// </summary>
        /// <returns> Returns true if empty </returns>
        public bool IsEmpty()
        {
            return count == 0;
        }
        /// <summary>
        /// Insert a new element
        /// </summary>
        /// <param name="item"></param>
        public void Insert(int item)
        {
            pq[count++] = item;
        }
        /// <summary>
        /// Delete the biggest element inside the MP queue
        /// </summary>
        /// <returns> Returns the removed max element </returns>
        public int DeleteMax()
        {
            int max = 0;

            for (int i = 1; i < count; i++) // max will be at pos 0 so we start at 1
            {
                if(pq[max] < pq[i])
                {
                    max = i;
                }
            }
            // Exchanging the last item with the max item
            int temp = pq[max];
            pq[max] = pq[count - 1];
            pq[count - 1] = temp;
            // Returning the removed max item
            return pq[--count];
        }
        /// <summary>
        /// Print the remaining elements inside the MP queue
        /// </summary>
        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(pq[i] + " ");
            }
        }
    }
}
