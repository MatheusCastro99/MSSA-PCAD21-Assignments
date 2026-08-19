using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment7._3._1
{
    internal class BinarySearchTree<T> where T : IComparable<T>
    {
        public BSTNode<T>? Root { get; private set; }

        //Inserts a value into tree
        public void Insert(T value)
        {
            var newNode = new BSTNode<T>(value);
            if (Root == null) //If tree is empty, first node added is the root
            {
                Root = newNode;
                return;
            }

            //Starting at the root, find the lowest leaf
            BSTNode<T> current = Root;
            BSTNode<T>? parent = null;

            while (current != null) //When a leaf node calls Left / Right, next iteration will have a null current
            {
                parent = current;
                int comparison = value.CompareTo(current.Data);

                //decides if current will go down left or right based on the comparison with the value being inserted
                if (comparison < 0)
                {
                    current = current.Left!;
                }
                else if (comparison > 0)
                {
                    current = current.Right!;
                }
                else
                {
                    // Duplicate values are not allowed in this implementation
                    return;
                }
            } //While loop will exit at the leaf node that met the comparison conditions

            // Assign the parent
            newNode.Parent = parent; //current node that exited will loop

            //Determines if new node will be assigned to Left or Right of current
            if (value.CompareTo(parent!.Data) < 0)
            {
                parent.Left = newNode;
            }
            else
            {
                parent.Right = newNode;
            }

        }

        // Search for a node by value
        public BSTNode<T>? Find(T value)
        {
            //Start at root and searches until current == null
            BSTNode<T>? current = Root;
            int depth = 1; //Counting root as depth 1

            while (current != null)
            {
                int comparison = value.CompareTo(current.Data);

                if (comparison == 0) //comparison == 0 means that value is equal to current.Data
                {
                    Console.WriteLine($"{current.Data} found at depth {depth}");
                    return current;
                }

                current = comparison < 0 ? current.Left : current.Right; //Ternary: if its less than 0 go left, else go right
                depth++;
            }

            Console.WriteLine("Node not found");
            return null; //Value not found
        }

        // Print tree in-order to verify the sort structure
        public void InOrderTraversal() //Entry point method protects Root and makes it easier to access on instantiated tree
        {
            InOrderTraversal(Root);
            Console.WriteLine("\n");
        }
        private void InOrderTraversal(BSTNode<T>? node)
        {
            if (node == null) return; //leaf nodes that will end recursion and start way back
            InOrderTraversal(node.Left);
            Console.Write($"{node.Data} "); //after leftmost node is found, start printing Data
            InOrderTraversal(node.Right);
        }

        // Priting tree showing node Parent / Left / Right Relation (Copilot)
        public void PrintTree() //Accessible entry point
        {
            PrintTree(Root, "", isLeft: null);
        }

        private void PrintTree(BSTNode<T>? node, string indent, bool? isLeft) //Private method
        {
            if (node == null) return; //stops recursion on leaf nodes

            // 1. Process Right child first (appears on top)
            string rightIndent = indent + (isLeft == true ? "│   " : "    ");
            PrintTree(node.Right, rightIndent, false);

            // 2. Process Current Node with appropriate connector
            string connector = "── ";
            if (isLeft == true)
            {
                connector = "└── "; // Left child branch
            }
            else if (isLeft == false)
            {
                connector = "┌── "; // Right child branch
            }

            Console.WriteLine($"{indent}{connector}{node.Data}");

            // 3. Process Left child (appears on bottom)
            string leftIndent = indent + (isLeft == false ? "│   " : "    ");
            PrintTree(node.Left, leftIndent, true);
        }
    }
}
