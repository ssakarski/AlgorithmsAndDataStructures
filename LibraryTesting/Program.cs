using System;
using AlgorithmsAndDataStructures.Algorithms;
using AlgorithmsAndDataStructures.DataStructures;
namespace LibraryTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree BST = new BinarySearchTree(100);
            BST.Add(9);
            BST.Add(7);
            BST.Add(10);
            BST.Add(107);
            BST.Add(108);
            Console.WriteLine(BST.Size);
            BST.Delete(108);
            BST.Delete(9);
            Console.WriteLine(BST.Size);
            BST.InOrder(BST.Root);

            //int[] binSearch = new int[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
            //int start = 0;
            //int end = binSearch.Length - 1;
            //int target = 9;
            //BinarySearch.Search(binSearch, target, start, end);

            //int[] heapsort = new int[10] {13,10,1,7,20,34,50,11,5,2 };

            //Heapsort.Sort(heapsort);

            //foreach (var item in heapsort)
            //{
            //    Console.Write(item +" ");
            //}

            //MaxPQ orderedMPQ = new MaxPQ(10);
            //orderedMPQ.Insert(10);
            //orderedMPQ.Insert(23);
            //orderedMPQ.Insert(8);
            //orderedMPQ.Insert(2);
            //orderedMPQ.Insert(9);
            //orderedMPQ.Insert(14);
            //orderedMPQ.Insert(77);
            //orderedMPQ.Insert(22);
            //orderedMPQ.Insert(1);

            //for (int i = 0; i != orderedMPQ.Count;)
            //{
            //    Console.Write(orderedMPQ.DeleteMax()+" ");
            //}

            //UnorderedMaxPriorityQueue mpq = new UnorderedMaxPriorityQueue(7);
            //mpq.Insert(5);
            //mpq.Insert(2);
            //mpq.Insert(3);
            //mpq.Insert(4);
            //mpq.Insert(1);
            //mpq.Insert(8);
            //mpq.Insert(24);

            //Console.WriteLine(mpq.DeleteMax());
            //Console.WriteLine(mpq.DeleteMax());
            //Console.WriteLine(mpq.DeleteMax());
            //Console.WriteLine();
            // Show the remaining items inside the unordered max priority queue (array version)
            //mpq.Print();

            //int[] arr5 = new int[] { 3, 5, 8, 2, 9, 10, 1, 0, 1, 2 };

            //ShuffleSort.Sort(arr5);
            //Quicksort.Sort(arr5, 0, arr5.Length - 1);

            //foreach (var item in arr5)
            //{
            //    Console.Write($"{item} ");
            //}

            //int[] arr4 = new int[] { 3, 5, 8, 2, 9, 10, 1, 0, 1, 2 };
            //int[] temp = new int[arr4.Length];
            //MergeSort.Sort(arr4,temp, 0, arr4.Length-1);

            //foreach (var item in arr4)
            //{
            //    Console.Write($"{item} ");
            //}


            //int[] arr3 = new int[] { 0,1,2,3,4,5,6,7,8,9 };

            //ShuffleSort.Sort(arr3);

            //foreach (var item in arr3)
            //{
            //    Console.Write($"{item} ");
            //}


            //int[] arr2 = new int[] { 3, 5, 8, 2, 9, 10, 1, 0, 1, 2 };

            //Shellsort.Sort(arr2);

            //foreach (var item in arr2)
            //{
            //    Console.Write($"{item} ");
            //}

            //int[] arr1 = new int[] { 3, 5, 8, 2, 9, 10, 1, 0, 1, 2 };

            //InsertionSort.Sort(arr1);

            //foreach (var item in arr1)
            //{
            //    Console.Write($"{item} ");
            //}

            //int[] arr = new int[] { 3, 5, 8, 2, 9, 10, 1, 0, 1, 2 };
            //SelectionSort.Sort(arr);

            //foreach (var item in arr)
            //{
            //    Console.Write($"{item} ");
            //}

            //var myDeque = new MyDeque<string>();

            //myDeque.AddFirst("horse");
            //myDeque.AddFirst("whale");
            //myDeque.AddFirst("ocean");

            //string s = myDeque.RemoveFirst();

            //myDeque.AddLast("ocean");
            //myDeque.AddLast("poll");
            //myDeque.AddLast("pong");

            //for (int i = 0; i < myDeque.Count; i++)
            //{
            //    Console.WriteLine(myDeque[i]);
            //}

            //myDeque.Clear();

            //string s1 = myDeque.RemoveLast();
            //string s2 = myDeque.PeekLast();

            //myDeque.AddFirst("one");
            //myDeque.AddLast("two");
            //myDeque.RemoveLast();
            //myDeque.RemoveLast();
            //myDeque.RemoveFirst();

            //var myQueue = new MyQueue<string>();

            //myQueue.Enqueue("Dog");
            //myQueue.Enqueue("Cat");
            //myQueue.Enqueue("Water");
            //myQueue.Enqueue("Soap");

            //Console.WriteLine(myQueue.Count);
            //Console.WriteLine(myQueue.IsEmpty());

            //Console.WriteLine(myQueue.Dequeue());
            //Console.WriteLine(myQueue.Dequeue());
            //Console.WriteLine(myQueue.Dequeue());
            //Console.WriteLine(myQueue.Dequeue());

            //Console.WriteLine(myQueue.Count);
            //Console.WriteLine(myQueue.IsEmpty());

            //var myStack = new MyStack<string>();

            //myStack.Push("Dog");
            //Console.WriteLine(myStack.Pop());
            //Console.WriteLine(myStack.IsEmpty());
            //myStack.Push("Cat");
            //myStack.Push("Kid");
            //myStack.Push("Adult");
            //Console.WriteLine(myStack.Count);
            //Console.WriteLine(myStack.Pop());
            //Console.WriteLine(myStack.Pop());
            //Console.WriteLine(myStack.Pop());

            //MyStack<int> myNewStack = new MyStack<int>();
            //myNewStack.Push(5);
            //myNewStack.Push(3);
            //myNewStack.Push(2);
            //Console.WriteLine();
            //Console.WriteLine(myNewStack.Count);
            //Console.WriteLine(myNewStack.Peek());
            //Console.WriteLine(myNewStack.Pop());
            //Console.WriteLine(myNewStack.Pop());

            //var list = new LinkedList<string>();

            //list.Add("Fish");
            //list.Add("Cloud");
            //list.Add("Ham");
            //list.Add("Bell");
            //list.Add("Jesus");
            //list.Add(null);
            //list.Add("Mug");

            //Console.WriteLine(list.Contains("Ham"));

            //list.Remove("Bell");
            //list.RemoveAt(4);

            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}


            //var list = new StaticArrayList<string>();

            //list.Add("Monkey");
            //list.Add("Dog");
            //list.Add("Cat");
            //list.Add("Hippo");
            //list.Add("Georgi");
            //list.Add("John");

            //Console.WriteLine(list.Contains("Dog"));

            //list.Remove("Cat");
            //list.Insert(0, "Monke");

            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            //QuickUnion qu = new QuickUnion(10);
            //qu.Union(4,3);
            //qu.Union(3,8);
            //qu.Union(6,5);
            //qu.Union(9,4);
            //qu.Union(2,1);
            //qu.Union(5,0);
            //qu.Union(7,2);
            //qu.Union(6,1);
            //qu.Union(7,3);
            //Console.WriteLine(qu.Connected(6, 9));

            //QuickFind qf = new QuickFind(10);
            //7-9 0-3 5-0 5-6 0-8 4-1
            //qf.Union(7, 9);
            //qf.Union(0, 3);
            //qf.Union(5, 0);
            //qf.Union(5, 6);
            //qf.Union(0, 8);
            //qf.Union(4, 1);

            //Console.WriteLine(qf.Connected(8,6));

            //qf.ArrayShow();
        }
    }
}
