using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.DataStructures
{
    /// <summary>
    /// Ordered max priority queue with binary heap implementation
    /// </summary>
    public class MaxPQ
    {
        private int[] arr;
        private int count;

        public MaxPQ(int capacity)
        {
            arr = new int[capacity+1];
        }
        /// <summary>
        /// Check to see if the MPQ is empty
        /// </summary>
        /// <returns> True if empty </returns>
        public bool IsEmpty()
        {
            return count == 0;
        }
        /// <summary>
        /// Insert a value
        /// </summary>
        /// <param name="item"></param>
        public void Insert(int item)
        {
            if(count == arr.Length-1)
            {
                throw new ArgumentOutOfRangeException("You can't add anymore elements.");
            }
            arr[++count] = item;
            swim(count);
        }
        public int Count { get => count;}
        /// <summary>
        /// Delete the max int which is located at position 1
        /// </summary>
        /// <returns> Returns the value of the deleted item </returns>
        public int DeleteMax()
        {
            if(IsEmpty())
            {
                throw new ArgumentOutOfRangeException("There are no more elements to be deleted.");
            }
            int max = arr[1];
            Exchange(1, count--);
            sink(1);
            return max;
        }
        /// <summary>
        /// Push the selected int to its correct position
        /// </summary>
        /// <param name="n"></param>
        private void swim(int n)
        {
            while (n > 1 && Less(n/2,n))
            {
                Exchange(n,n / 2);
                n = n / 2;
            }
        }
        /// <summary>
        /// The biggest int sinks to the bottom of the tree
        /// </summary>
        /// <param name="n"></param>
        private void sink(int n)
        {
            //while the position of the element is less than the last position it will keep sinking
            while (2*n <= count)
            {
                int j = 2 * n;
                if(j<count && Less(j,j+1))
                {
                    j++;
                }
                if(!Less(n, j))
                {
                    break;
                }
                Exchange(n, j);
                n = j;
            }
        }
        /// <summary>
        /// Check to see if element i is less than j
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        private bool Less(int i, int j)
        {
            return arr[i].CompareTo(arr[j]) < 0;
        }
        /// <summary>
        /// Exchange the elements of the array in the MPQ
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        private void Exchange(int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public void Print()
        {
            for (int i = 1; i < count+1; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
