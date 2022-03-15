using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.Algorithms
{
    public class SelectionSort
    {
        /// <summary>
        /// Sorts an array of integers in ascending order
        /// </summary>
        /// <param name="arr"> The array we want to sort </param>
        public static void Sort(int[] arr)
        {
            int n = arr.Length;
            int temp;
            for (int i = 0; i < n-1; i++)
            {
                int min = i;

                for (int j = i+1; j < n; j++)
                {
                    if(arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
        }
    }
}
