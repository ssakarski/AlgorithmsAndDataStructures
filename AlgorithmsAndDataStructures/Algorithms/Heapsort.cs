using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.Algorithms
{
    public class Heapsort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;

            for (int i = n/2-1; i >= 0; i--)
            {
                // Sort the heap from the bottom to the top
                Heap(arr, n, i);
            }

            for (int i = n-1; i > 0 ; i--)
            {
                // swap the root with the last item and reduce the size
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;

                // Sort the new heap
                Heap(arr, i, 0);
            }
        }
        
        private static void Heap(int[] arr , int n, int i)
        {
            int largest = i; // the root element
            int left = i * 2 + 1; // left child
            int right = i * 2 + 2; // right child

            // if the left child is bigger than the parent make the parent the left child
            if(left < n && arr[left] > arr[largest])
            {
                largest = left;
            }
            // if the right child is bigger than the parent make the parent the right child
            if (right < n && arr[right] > arr[largest])
            {
                largest = right;
            }

            // if the largest element is not the root, make it
            if(largest != i)
            {
                int temp = arr[i];
                arr[i] = arr[largest];
                arr[largest] = temp;

                // recursively heapify the rest;
                Heap(arr, n, largest);
            }
        }
    }
}
