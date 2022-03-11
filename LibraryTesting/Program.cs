﻿using System;
using AlgorithmsAndDataStructures.Algorithms;
using AlgorithmsAndDataStructures.DataStructures;
namespace LibraryTesting
{
    class Program
    {
        static void Main(string[] args)
        {

            var myQueue = new MyQueue<string>();

            myQueue.Enqueue("Dog");
            myQueue.Enqueue("Cat");
            myQueue.Enqueue("Water");
            myQueue.Enqueue("Soap");

            Console.WriteLine(myQueue.Count);
            Console.WriteLine(myQueue.IsEmpty());

            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Dequeue());

            Console.WriteLine(myQueue.Count);
            Console.WriteLine(myQueue.IsEmpty());

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
