//Given the head of a singly linked list, reverse the list, and return the reversed list.

using Assignment11._2._2;

MyLinkedList<int> myNums = new();

myNums.AddToEnd(1);
myNums.AddToEnd(2);
myNums.AddToEnd(3);
myNums.AddToEnd(4);
myNums.AddToEnd(5);
myNums.AddToEnd(6);

myNums.PrintList();

//Iterate through list making each node point to its previous
//I have to how a tempPointer variable so I dont break the loop during iteration
//Additionaly, since the changes to each pointer will be made from its next iteration, I should keep a prev pointer as well
//I also have to explicitly select the last node (n+1 == null) as the new head
//I'll implement the method on MyLinkedList class where I have direct access to head

myNums.ReverseList();

myNums.PrintList();



