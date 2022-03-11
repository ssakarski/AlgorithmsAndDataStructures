using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.Algorithms
{
    public class QuickFind
    {
        private int[] id;

        //Initializing the array in the constuctor
        public QuickFind(int n)
        {
            id = new int[n];

            for (int i = 0; i < n; i++)
            {
                id[i] = i;
            }
        }

        // Checking if p and q have the same value and if they do they are connected
        public bool Connected(int p, int q)
        {
            return id[p] == id[q];
        }

        //Connecting two points and setting the value of the first point to the value of the second
        public void Union(int p, int q)
        {
            int pid = id[p];
            int qid = id[q];

            for (int i = 0; i < id.Length; i++)
            {
                if(id[i] == pid)
                {
                    id[i] = qid;
                }
            }
        }
        public void ArrayShow()
        {
            for (int i = 0; i < id.Length; i++)
            {
                Console.WriteLine($"pos:{i} value:{id[i]}");
            }
        }
    }
}
