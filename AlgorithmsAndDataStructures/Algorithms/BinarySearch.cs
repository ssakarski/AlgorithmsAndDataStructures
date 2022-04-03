using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.Algorithms
{
    public class BinarySearch
    {
        /// <summary>
        /// Binary search a sorted array
        /// </summary>
        /// <param name="arr">The array to be searched</param>
        /// <param name="target">The target we are looking for</param>
        /// <param name="start">Start index of the array</param>
        /// <param name="end">End index of the array</param>
        /// <returns></returns>
        public static int Search(int[] arr, int target, int start, int end)
        {
            // If the target is not inside the array it will return -1
            if(start>end)
            {
                Console.WriteLine($"{target} was not in the array!");
                return -1;
            }
            int mid = (end + start) / 2;
            // returns the mid index if the values are equal with the target
            if(arr[mid] == target)
            {
                Console.WriteLine($"The target {target} was found at position {mid}");
                return mid;
            }
            // If the mid value is higher than the target we recursively look up the left side of the array and the same goes for the right if its bigger
            if(arr[mid] > target)
            {
                return Search(arr, target, start, mid-1);
            }
            else
            {
                return Search(arr, target, mid + 1, end);
            }
            
        }
    }
}
