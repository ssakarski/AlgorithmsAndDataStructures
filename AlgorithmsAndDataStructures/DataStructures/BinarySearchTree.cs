using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures.DataStructures
{
    public class BinarySearchTree
    {
       public BinarySearchTree()
       { 
       }

       public BinarySearchTree(int rootVal)
       {
            Add(rootVal);
       }
       public class Node
        {
            public int Value { get; private set; }
            public Node LeftChild { get; set; }
            public Node RightChild { get; set; }

            public Node(int value,Node left, Node right)
            {
                Value = value;
                left = right = null;
            }
        }

        public Node Root { get; private set; }

        public void Add(int val)
        {
            Node prev = null;
            Node current = Root;
            ///Check to see if the node is in the tree and where it belongs.
            while (current != null)
            {
                prev = current;
                //Moving through the tree to left or the right depending on the value and breaking if the value is already inside.
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
            }
        }
        // DFS below
        public void InOrder(Node root)
        {
            if (root != null)
            {
                InOrder(root.LeftChild);
                Console.Write(root.Value+" ");
                InOrder(root.RightChild);
            }
        }

        public void PostOrder(Node root)
        {
            if (root != null)
            {
                InOrder(root.LeftChild);
                InOrder(root.RightChild);
                Console.Write(root.Value+" ");
            }
        }

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
