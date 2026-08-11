using Assignment6._2._1;

MyStack stack = new();

stack.Push(2);
Console.WriteLine(stack.ToString());

stack.Push(5);
Console.WriteLine(stack.ToString());

stack.Push(6);
Console.WriteLine(stack.ToString());

Console.WriteLine(stack.Peak());

Console.WriteLine(stack.Pop());
Console.WriteLine(stack.ToString());