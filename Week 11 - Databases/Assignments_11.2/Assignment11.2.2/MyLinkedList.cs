using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Assignment11._2._2
{
    internal class MyLinkedList<T>
    {
        private MyNode<T>? head;

        // Add a node to the end of the list
        public void AddToEnd(T data)
        {
            MyNode<T> newNode = new MyNode<T>(data);

            if (head == null) //Case where list is empty
            {
                head = newNode;
                return;
            }

            MyNode<T> current = head;
            while (current.Next != null) //Checks for end of the list
            {
                current = current.Next;
            }

            current.Next = newNode; //Stores newNode in Next reference of previous
        }

        // Add a node to the front of the list
        public void AddToBeginning(T data)
        {
            MyNode<T> newNode = new MyNode<T>(data);
            newNode.Next = head; //Stores current head node in newNode.Next
            head = newNode; //Makes newNode head
        }

        public void ReverseList()
        {
            MyNode<T> current = head;

            var temp = current; //temp needs to be initalized outside loop, since it needs to carry the current info to the next loop iteration
            MyNode<T>? prev = null; //I will also keep track of a prev Node since the changes to each node will be made on the next iteration

            while (current != null)
            {
                temp = current.Next; //Saves Next node to preserve iteration
                current.Next = prev; //Reversing pointer step
                prev = current; //Move prev to the current node
                current = temp; //Moves loop forward
            }

            head = prev; //At the end of while loop, current should be null, but since we do prev = current before advances, prev holds the last node
        }

        // Print all nodes
        public void PrintList()
        {
            MyNode<T> current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data.ToString() + "\n");
                current = current.Next;
            }
            Console.WriteLine("\n ---- End of List");
        }
    }
}
