using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.Algorithms
{
    public class InsertionSort
    {
        /// <summary>
        /// Sort an integer array
        /// </summary>
        /// <param name="arr"> The array we wish to sort </param>
        public static void Sort(int[] arr)
        {
            int n = arr.Length;
            int temp;
            for (int i = 0; i < n; i++)
            {
                //Form a small subarray sort the small one and then move to the big one
                for (int j = i; j > 0 ; j--)
                {
                    if(arr[j] < arr[j-1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j - 1];
                        arr[j - 1] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
