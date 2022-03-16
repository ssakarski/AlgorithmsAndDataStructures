using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.Algorithms
{
    public class ShuffleSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;
            Random rand = new Random();
            int temp;

            for (int i = 0; i < n; i++)
            {
                int r = rand.Next(i + 1);

                temp = arr[i];
                arr[i] = arr[r];
                arr[r] = temp;
            }
        }
    }
}
