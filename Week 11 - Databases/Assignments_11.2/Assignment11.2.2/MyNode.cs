using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment11._2._2
{
    internal class MyNode<T>
    {
        public T Data { get; set; }
        public MyNode<T>? Next { get; set; } //Has to be nullable aware so last node (tail) with Next == null does not crashes program

        public MyNode(T newNode)
        {
            Data = newNode;
            Next = null;
        }
    }
}
