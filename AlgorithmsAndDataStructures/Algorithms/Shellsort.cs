using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.Algorithms
{
    public class Shellsort
    {
        /// <summary>
        /// Sort an array with the shellsort method
        /// </summary>
        /// <param name="a"> Array we wish to sort </param>
        public static void Sort(int[] a) 
        {
            int n = a.Length;
            int temp;
            // 3x + 1 increment sequence for the h sort
            int h = 1;
            while (h < n/3)
            {
                h = 3 * h + 1;
            }

            while (h >= 1)
            {
                for (int i = h; i < n; i++)
                {
                    // Doing insertion sort from i
                    for (int j = i; j >= h && a[j] < a[j-h] ; j -= h)
                    {
                        temp = a[j];
                        a[j] = a[j - h];
                        a[j - h] = temp;
                    }
                }
                //reducing the gap between the elements
                h = h / 3;

            }
        }
    }
}
