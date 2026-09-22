//Given the head of a singly linked list, return true if it is a palindrome or false otherwise.

//Thoughts:
//Use Count to determine the length of linked list, and where the middle point is
//Use a stack to store the first half of the linked list
//As we iterate through the second half of the linked list, we pop from the stack and compare to the current node value

//If list has an odd number of nodes, we can skip the middle node when comparing

LinkedList<int> linkedList = new LinkedList<int>(new int[] { 1, 2, 3, 2, 1 });
Console.WriteLine($"Is the linked list a palindrome: {IsPalindrome(linkedList)}");

bool IsPalindrome(LinkedList<int> linkedList)
{
    if (linkedList.Count <= 1)
    {
        return true; //A linked list with 0 or 1 nodes is always a palindrome
    }

    Stack<int> stack = new Stack<int>();
    int mid = linkedList.Count / 2; //handles odd lengths by rounding down. When stack is completed, we have to skip the middle node if the length is odd
    LinkedListNode<int> current = linkedList.First;

    for (int i = 0; i < mid; i++) //loads the first half of the linked list into the stack
    {
        stack.Push(current.Value);
        current = current.Next;
    }

    if (linkedList.Count % 2 != 0) //If the linked list has an odd number of nodes, skip the middle node
    {
        current = current.Next;
    }

    while (current != null)
    {
        if (stack.Pop() != current.Value) //compare the current node value with the top value from the stack
        {
            return false;
        }
        current = current.Next;
    }

    //If linked list survives the iteration, then it is a palindrome
    return true;
}