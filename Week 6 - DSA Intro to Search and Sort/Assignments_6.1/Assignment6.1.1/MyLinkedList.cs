using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Assignment6._1._1
{
    internal class MyLinkedList
    {
        private MyNode? head;

        // Add a node to the end of the list
        public void AddToEnd(House data)
        {
            MyNode newNode = new MyNode(data);

            if (head == null) //Case where list is empty
            {
                head = newNode;
                return;
            }

            MyNode current = head;
            while (current.Next != null) //Checks for end of the list
            {
                current = current.Next;
            }

            current.Next = newNode; //Stores newNode in Next reference of previous
        }

        // Add a node to the front of the list
        public void AddToBeginning(House data)
        {
            MyNode newNode = new MyNode(data);
            newNode.Next = head; //Stores current head node in newNode.Next
            head = newNode; //Makes newNode head
        }

        public void SearchHouse(string comparingData)
        {
            MyNode current = head;
            string comparingFactor = comparingData;

            bool isFound = false;

            if (current == null)
            {
                Console.WriteLine("Cannot search on an empty List");
                return;
            }

            Console.WriteLine("Search result: ");

            while (current.Next != null) ; //Acts more like a filter than a proper search
            {
                var houseData = current.Data;

                if (comparingFactor.Equals(houseData.HouseNumber) || comparingFactor.Equals(houseData.StreetAddress) || comparingFactor.Equals(houseData.HouseType))
                {
                    Console.WriteLine(houseData.ToString() + "\n");
                    isFound = true;
                }

                current = current.Next;
            }

            if(!isFound)
            {
                Console.WriteLine("No House was found with the description entered");
            }
        }

        // Print all nodes
        public void PrintList()
        {
            MyNode current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data.ToString() + "\n");
                current = current.Next;
            }
            Console.WriteLine("\n ---- End of List");
        }
    }
}
