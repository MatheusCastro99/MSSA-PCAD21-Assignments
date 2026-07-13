//Assignment 1.1.1. =========================================================================================

Console.WriteLine("Please enter your name: ");
string name = Console.ReadLine();

Console.WriteLine("\nPlease enter your address: ");
string address = Console.ReadLine();

Console.WriteLine("\nPlease enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nPlease enter your GPA for your last semester: ");
double gpa = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("\nName: " +  name + "\nAddress: " + address + "\nAge: " + age + "\nGPA: " + gpa);

Console.WriteLine("\nPress any button to exit");
Console.ReadLine();



//Assignment 1.1.2 =========================================================================================

Console.WriteLine("This program will print the sum of two numbers\n");

Console.WriteLine("input the first number");
double firstNum = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("input the second number");
double secondNum = Convert.ToDouble(Console.ReadLine());

double sum = firstNum + secondNum;

Console.WriteLine("the sum of " + firstNum + " and " + secondNum + " is " + sum);

Console.WriteLine("\nPress any button to exit");
Console.ReadLine();



//Assignment 1.1.3 =========================================================================================

Console.WriteLine("This program will print the result of dividing two numbers\n");

Console.WriteLine("input the first number");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("input the second number");
double num2 = Convert.ToDouble(Console.ReadLine());

double division = num1 / num2;
double remainder = num1 % num2;

Console.WriteLine(num1 + " divided by " + num2 + " is equal to: " + division +
    "\n with a remainder of " + remainder);

Console.WriteLine("\nPress any button to exit");
Console.ReadLine();