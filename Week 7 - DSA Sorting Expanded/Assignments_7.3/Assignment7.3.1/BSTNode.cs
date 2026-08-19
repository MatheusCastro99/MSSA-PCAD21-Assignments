using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment7._3._1
{
    internal class BSTNode<T> where T : IComparable<T>
    {
        public T Data { get; set; }

        //Parent node nullable aware so program does not crash on root node
        public BSTNode<T>? Parent { get; set; }

        //Child nodes nullable aware so the program does not crash on leaf nodes
        public BSTNode<T>? Left { get; set; }
        public BSTNode<T>? Right { get; set; }

        public BSTNode(T data)
        {
            Data = data;
            Left = null;
            Right = null;
            Parent = null;
        }
    }
}
