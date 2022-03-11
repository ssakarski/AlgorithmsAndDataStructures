using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.Algorithms
{
    public class QuickUnion
    {
        private int[] id;
        //Initializing the array
        public QuickUnion(int n)
        {
            id = new int[n];

            for (int i = 0; i < n; i++)
            {
                id[i] = i;
            }
        }
        //Checking if the number is its own root and if not , looking for the root of the number
        private int Root(int i)
        {
            while (i != id[i])
            {
                i = id[i]; 
            }
            return i;
        }
        //Checking if both numbers are connected in the tree
        public bool Connected(int p, int q)
        {
            return Root(p) == Root(q);
        }
        //Making a connection between both numbers/trees and setting the root of the first to the be the root of the second
        public void Union(int p, int q)
        {
            int i = Root(p);
            int j = Root(q);
            id[i] = j;
        }
    }
}
