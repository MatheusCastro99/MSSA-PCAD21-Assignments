using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_6._3
{
    internal class MyQueue
    {
        LinkedList<Caller> queue;

        public MyQueue()
        {
            queue = new();
        }

        public void Enqueue(Caller person)
        {
            queue.AddLast(person);
            Console.WriteLine($"{person}   - added to line");
            Console.WriteLine();
            Thread.Sleep(1000);
        }

        public string Dequeue()
        {
            string selected = queue.First.Value.ToString();
            queue.RemoveFirst();

            return $"{selected}   - removed from line\n";
        }

        public void GetQueue()
        {
            Console.WriteLine();
            Console.WriteLine("Iterating through line:");

            foreach(var item in queue)
            {
                Console.Write($"{item.ToString()}\n");
                Thread.Sleep(1500); //1.5 second pause for iteration "feeling" of processing one by one
            }
            Console.WriteLine("\n");
        }

        public string Peak()
        {
            string nextInLine = queue.First.Value.ToString();
            return $"Next in line:\n{nextInLine}";
        }
    }
}
