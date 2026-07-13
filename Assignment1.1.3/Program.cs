Console.WriteLine("This program will print the result of dividing two numbers\n");

Console.WriteLine("input the first number");
double firstNum = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("input the second number");
double secondNum = Convert.ToDouble(Console.ReadLine());

double division = firstNum / secondNum;
double remainder  = firstNum % secondNum;

Console.WriteLine(firstNum + " divided by " + secondNum + " is equal to: " +  division + 
    "\n with a remainder of " + remainder);

Console.WriteLine("\nPress any button to exit");
Console.ReadLine();