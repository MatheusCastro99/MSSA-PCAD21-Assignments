Console.WriteLine("This program will print the sum of two numbers\n");

Console.WriteLine("input the first number");
double firstNum = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("input the second number");
double secondNum = Convert.ToDouble(Console.ReadLine());

double sum = firstNum + secondNum;

Console.WriteLine("the sum of " + firstNum + " and " + secondNum + " is " + sum);

Console.WriteLine("\nPress any button to exit");
Console.ReadLine();
