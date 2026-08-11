using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6._2._1
{
    internal class MyStack
    {
        private int[] StackList {  get; set; }

        public MyStack()
        {
            StackList = new int[0];
        }

        public void Push(int number)
        {
            StackList = StackList.Append(number).ToArray();
        }

        public int Pop()
        {
            if (StackList.Length > 0)
            {
                int selected = StackList[StackList.Length - 1];

                StackList = StackList.Where((val, idx) => idx != StackList.Length - 1).ToArray();

                return selected;
            }

            return -1;
        }

        public int Peak()
        {
            if (StackList.Length > 0)
            {
                int selected = StackList[StackList.Length - 1];
                return selected;
            }

            return -1;
        }

        public override string ToString()
        {
            string ans = $"Current Array: {string.Join(", ", StackList)} ";
            return ans;
        }
    }
}