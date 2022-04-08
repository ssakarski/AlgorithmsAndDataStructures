using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.DataStructures
{
    public class BinarySearchTree
    {
       /// <summary>
       /// Get the size of the tree
       /// </summary>
       public int Size { get; private set; } = 0;
       /// <summary>
       /// Initialize a tree without root value
       /// </summary>
       public BinarySearchTree()
       { 
       }
       /// <summary>
       /// Initialize a tree with root value
       /// </summary>
       /// <param name="rootVal">value for the root</param>
       public BinarySearchTree(int rootVal)
       {
            Add(rootVal);
       }
       /// <summary>
       /// Tree node
       /// </summary>
       public class Node
        {
            public int Value { get;set; }
            public Node LeftChild { get; set; }
            public Node RightChild { get; set; }

            public Node(int value,Node left, Node right)
            {
                Value = value;
                left = right = null;
            }
        }

        public Node Root { get; private set; }
        /// <summary>
        /// Add a new value inside the tree
        /// </summary>
        /// <param name="val">value to be inserted</param>
        public void Add(int val)
        {
            Node prev = null;
            Node current = Root;
            //Check to see if the node is in the tree and where it belongs.
            while (current != null)
            {
                prev = current;
                //Moving through the tree to the left or the right depending on the value and breaking if the value is already inside.
                if(val < current.Value)
                {
                    current = current.LeftChild;
                }
                else if(val > current.Value)
                {
                    current = current.RightChild;
                }
                else
                {
                    Console.WriteLine($"The value {val} is already in the tree.");
                    return;
                }
            }

            Node newNode = new Node(val,null,null);
            //If the root is null assign the new node to it.
            if(Root == null)
            {
                Root = newNode;
                Size++;
            }
            else
            {
                if(val < prev.Value)
                {
                    prev.LeftChild = newNode;
                }
                else if(val>prev.Value)
                {
                    prev.RightChild = newNode;
                }
                Size++;
            }
        }
        /// <summary>
        /// Delete a value from the tree
        /// </summary>
        /// <param name="value">value to be deleted</param>
        public void Delete(int value)
        {
            Root = Delete(Root, value);
            Size--;
        }
        /// <summary>
        /// Delete a value from the tree
        /// </summary>
        /// <param name="current">The root of the tree</param>
        /// <param name="value">The value we wish to delete</param>
        private Node Delete(Node current, int value)
        {
            //If the tree is empty return
            if(current == null)
            {
                return current;
            }

            if(value<current.Value)
            {
                current.LeftChild=Delete(current.LeftChild, value);
            }
            else if (value>current.Value)
            {
                current.RightChild=Delete(current.RightChild, value);
            }
            //If the value is the same as the current root
            else
            {
                //Nodes with only 1 child
                if(current.LeftChild == null)
                {
                    return current.RightChild;
                }
                else if(current.RightChild == null)
                {
                    return current.LeftChild;
                }
                //If there are 2 children get the min value of the right one
                current.Value = MinVal(current.RightChild);
                //Deleting the successor
                current.RightChild = Delete(current.RightChild, current.Value);
            }
            return current;
        }
        /// <summary>
        /// Get the min value
        /// </summary>
        /// <param name="current">Root of the tree</param>
        /// <returns>Min value</returns>
        public int MinVal(Node current)
        {
            int currentMin = current.Value;
            while(current != null)
            {
                currentMin = current.Value;
                current = current.LeftChild;
            }
            return currentMin;
        }
        /// <summary>
        /// Get the max value
        /// </summary>
        /// <param name="current">Root of the tree</param>
        /// <returns>Max value of the tree</returns>
        public int MaxVal(Node current)
        {
            int currentMax = current.Value;
            while (current != null)
            {
                currentMax = current.Value;
                current = current.RightChild;
            }
            return currentMax;
        }
        // DFS below
        /// <summary>
        /// Prints the tree in order
        /// </summary>
        /// <param name="root"></param>
        public void InOrder(Node root)
        {
            if (root != null)
            {
                InOrder(root.LeftChild);
                Console.Write(root.Value+" ");
                InOrder(root.RightChild);
            }
        }
        /// <summary>
        /// Prints the tree in post order
        /// </summary>
        /// <param name="root">Root of the tree</param>
        public void PostOrder(Node root)
        {
            if (root != null)
            {
                InOrder(root.LeftChild);
                InOrder(root.RightChild);
                Console.Write(root.Value+" ");
            }
        }

        /// <summary>
        /// Prints the tree pre order
        /// </summary>
        /// <param name="root">root of the tree</param>
        public void PreOrder(Node root)
        {
            if (root != null)
            {
                Console.Write(root.Value+" ");
                InOrder(root.LeftChild);
                InOrder(root.RightChild);
            }
        }
    }
}
