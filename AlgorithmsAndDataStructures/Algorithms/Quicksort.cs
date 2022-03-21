using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.Algorithms
{
    public class Quicksort
    {
        private static int Partition(int[] arr, int left, int right)
        {

            int i = left;
            int j = right+1;

            while (true)
            {
                // Looking for item on the left to swap
                while (arr[++i] < arr[left])
                {
                    if(i == right)
                    {
                        break;
                    }
                }
                // Looking for item on the right to swap
                while (arr[left] < arr[--j])
                {
                    if(j == left)
                    {
                        break;
                    }
                }
                // Checking if the pointers crossed
                if(i >= j)
                {
                    break;
                }

                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
            // Swapping last element with the partition element
            int temp2 = arr[left];
            arr[left] = arr[j];
            arr[j] = temp2;

            // Returning the index of the element in place
            return j;
        }

        public static void Sort(int[] arr, int left, int right)
        {
            if(right <= left)
            {
                return;
            }

            int j = Partition(arr, left, right);
            Sort(arr, left, j - 1);
            Sort(arr, j + 1, right);
        }
    }
}
