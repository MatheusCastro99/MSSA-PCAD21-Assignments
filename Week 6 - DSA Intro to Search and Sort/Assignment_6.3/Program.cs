//You are developing a program to manage a call queue of customers using the Queue in C#.
//The program creates a queue of callers and demonstrates the functionality of enqueueing elements into the queue and iterating over the elements and dequeuing.

//Use linked lists.
//Create Queue (FIFO), Enqueue, Iterate, Dequeue, Peak

using Assignment_6._3;

MyQueue line =  new MyQueue();

line.Enqueue(new("John", "123-234-3456", "123"));
line.Enqueue(new("Jane", "098-876-6543", "234"));
line.Enqueue(new("Josh", "876-654-4321", "345"));
line.Enqueue(new("Joel", "345-567-7890", "456"));

line.GetQueue();

Console.WriteLine(line.Dequeue());
Console.WriteLine(line.Dequeue());

Console.WriteLine(line.Peak());
