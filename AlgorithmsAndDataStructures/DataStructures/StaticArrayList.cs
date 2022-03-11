using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.DataStructures
{
    public class StaticArrayList<T>
    {
        private static readonly int STARTING_CAPACITY = 4;

        private T[] arr;
        private int count;

        public StaticArrayList()
        {
            arr = new T[STARTING_CAPACITY];
            count = 0;
        }
        /// <summary>
        /// Returns the count of the elements in the list
        /// </summary>
        public int Count
        {
            get => count;
        }

        /// <summary>
        /// Add an item to the existing static list
        /// </summary>
        /// <param name="item"> Element we wish to add to the list</param>
        public void Add(T item)
        {
            Resize();
            arr[count] = item;
            count++;
        }

        /// <summary>
        /// Insert an item at the given index
        /// </summary>
        /// <param name="index"> Index at which we wish to insert </param>
        /// <param name="item"> Element we wish to insert </param>
        public void Insert(int index, T item)
        {
            if(index < 0 || index > count)
            {
                throw new IndexOutOfRangeException("Index out of range: " + index);
            }

            Resize();

            Array.Copy(arr, index, arr, index + 1, count - index);
            arr[index] = item;
            count++;
        }

        /// <summary>
        /// Doubling the capacity of the current static list
        /// </summary>
        private void Resize()
        {
            if(count+1 > arr.Length)
            {
                T[] biggerArray = new T[arr.Length*2];
                Array.Copy(arr, biggerArray,count);
                arr = biggerArray;
            }
        }

        /// <summary>
        /// Deleting everyhting from the static list
        /// </summary>
        public void Clear()
        {
            arr = new T[STARTING_CAPACITY];
            count = 0;
        }
        /// <summary>
        /// Find the index of given item
        /// </summary>
        /// <param name="item"> Item whose index we seek </param>
        /// <returns> Returns the index of the element or -1 if not found </returns>
        public int IndexOf(T item)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }
        /// <summary>
        /// Check if the list contains given element
        /// </summary>
        /// <param name="item"> Element to look for </param>
        /// <returns> Returns true if found </returns>
        public bool Contains (T item)
        {
            if(arr.Contains(item))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Indexer: Gives access to element at given index
        /// </summary>
        /// <param name="index"> Index for the element we want </param>
        /// <returns> Returns the element on the given position </returns>
        public T this[int index]
        {
            get
            {
                if(index < 0 || index >= arr.Length)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }

                return arr[index];
            }
            set
            {
                if (index < 0 || index >= arr.Length)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                arr[index] = value;
            }
        }
        /// <summary>
        /// Removes the element at the given index
        /// </summary>
        /// <param name="index"> Index of the element we want to remove </param>
        /// <returns> Returns the removed element </returns>
        public T RemoveAt(int index)
        {
            if (index < 0 || index >= arr.Length)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }

            T item = arr[index];

            Array.Copy(arr, index + 1, arr, index, count - index - 1);

            arr[count - 1] = default(T);
            count--;
            return item;
        }

        /// <summary>
        /// Removing the specified item from the list
        /// </summary>
        /// <param name="item"> Item to be removed </param>
        /// <returns> Returns the index of the removed item</returns>
        public int Remove (T item)
        {
            int index = this.IndexOf(item);
            if(index != -1)
            {
                this.RemoveAt(index);
            }

            return index;
        }
    }
}
