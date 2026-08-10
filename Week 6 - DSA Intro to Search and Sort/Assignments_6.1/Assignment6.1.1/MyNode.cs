using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6._1._1
{
    internal class MyNode
    {
        public House Data { get; set; }
        public MyNode? Next { get; set; } //Has to be nullable aware so last node (tail) with Next == null does not crashes program

        public MyNode(House newHouse)
        {
            Data = newHouse;
            Next = null;
        }
    }
}
