//Given the head of a linked list and an integer val, remove all the nodes of the linked list that has Node.val == val, and return the new head.

//Example 1:
//Input: head = [1, 2, 6, 3, 4, 5, 6], val = 6
//Output: [1, 2, 3, 4, 5]

//Example 2:
//Input: head = [], val = 1
//Output: []

//Example 3:
//Input: head = [7, 7, 7, 7], val = 7
//Output: []

//Thoughts:
//Before start iteration, check if head is null, if so return null.
//Also before iteration, check if head.val == val, if so move head to head.next and recheck until head is not null and head.val != val.
//Then start iteration, for each node, check if node.next.val == val, if so remove node.next without moving current node, else move current node to current.next.
//Because we are checking node.next, we don't need to check the last node, so we can stop when node.next is null.

LinkedList<int> SampleList = new LinkedList<int>(new int[] { 1, 2, 6, 3, 4, 5, 6 });
int val = 6; //Expected output: [1, 2, 3, 4, 5]

Console.WriteLine("Original List: " + string.Join(", ", SampleList));
Console.WriteLine("Value to Remove: " + val);
Console.WriteLine("Modified List: " + string.Join(", ", (RemoveValElements(SampleList, val) ?? Enumerable.Empty<int>())));

LinkedList<int>? RemoveValElements(LinkedList<int> sampleList, int val)
{
    //Remove leading nodes with the target value
    while (sampleList != null && sampleList.First.Value == val)
    {
        sampleList.RemoveFirst();
    }

    //While loop exits when first node that is not equal to val OR when head is null (all of the list nodes == val)
    if (sampleList == null) return null;

    var current = sampleList.First;
    while (current != null && current.Next != null)
    {
        if (current.Next.Value == val)
        {
            current.List.Remove(current.Next);
        }
        else
        {
            current = current.Next;
        }
    }

    return sampleList;
}