using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.Algorithms
{
    public class MergeSort
    {
       public static void Merge(int[] arr, int[] temp, int left, int mid, int right)
        {
            // create a temporary array to hold the values and then assign the values of the main array to the temp 
            for (int k = left; k <= right; k++)
            {
                temp[k] = arr[k];
            }

            // Merging and sorting the broken up arrays
            int i = left;
            int j = mid+1;

            for (int k = left; k <= right; k++)
            {
                if(i > mid)
                {
                    arr[k] = temp[j++];
                }
                else if(j > right)
                {
                    arr[k] = temp[i++];
                }
                else if(temp[j] < temp[i])
                {
                    arr[k] = temp[j++];
                }
                else
                {
                    arr[k] = temp[i++];
                }
            }
        }

        public static void Sort(int[] arr, int[] temp, int left, int right)
        {
            //Breaking the array into smaller arrays recursively
            if(right <= left)
            {
                return;
            }
            int mid = left + (right - left) / 2;
            //Breaking the left side the of array
            Sort(arr,temp, left, mid);
            //Breaking the right side of the array
            Sort(arr,temp, mid + 1, right);
            //Merging both sides and sorting them
            Merge(arr,temp, left, mid, right);
        }
    }
}
