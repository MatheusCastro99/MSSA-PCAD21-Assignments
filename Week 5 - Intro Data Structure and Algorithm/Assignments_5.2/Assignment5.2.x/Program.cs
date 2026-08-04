#region ASSIGNMENT 5.3.1
//Given a string s consisting of words and spaces, return the length of the last word in the string.
//A word is a maximal substring consisting of non-space characters only.

string s = "fly me to the moon   ";
int lastWordLength = 0;

bool startCount = false; //Will help accounting for leading spaces

Stack<char> lastWord = new();

for (int i = s.Length-1;  i >= 0; i--) //Initializes the loop at the last index position of s and iterate backwards
{
    if (s[i] == ' ' && !startCount) continue; //Accounts for leading spaces, iterating backwards without incrementing lastWordLength;

    if (s[i] == ' ' && startCount) break; //Accounts for beginning of last word, marked by a ' '. Breaks out of loop without incrementing

    startCount = true; //This line will only be reached when iteration fails two lasts checks, marking the last character of the last word
    lastWordLength++; //From here, startCount will be true so it will fail the first test every time.

    lastWord.Push(s[i]); //Stacks are LIFO, so even though the characters are being stored in reverse order, they will result in the actual word when deconstructed
}

foreach (char c in lastWord) Console.Write(c); //Prints lastWord preserving the Stack

Console.Write($" Contains {lastWordLength} letters");
#endregion

Console.WriteLine("\n==================================================\n");

#region ASSIGNMENT 5.3.2 and 5.3.3
//5.3.2: Write a program in C# Sharp to print the first n natural number using recursion.
//5.3.3: Write a program in C# Sharp to print numbers from n to 1 using recursion.

int n = 10;
PrintNaturalNumbersIncrement(n);
Console.WriteLine("\n");
PrintNaturalNumbersDecrement(n);

void PrintNaturalNumbersIncrement(int n)
{
    if (n > 0)
    {
        PrintNaturalNumbersIncrement(n - 1); //Recursion comes first, so first Console.Write reached is from the last recursion, n==1

        Console.Write($"{n} ");
    }
}

void PrintNaturalNumbersDecrement(int n)
{
    if (n > 0)
    {
        Console.Write($"{n} "); //Printing comes first, so now the numbers will print before decreasing
        PrintNaturalNumbersDecrement(n - 1);
    }
}
#endregion

Console.WriteLine("\n\n==================================================\n");

#region ASSIGNMENT 5.3.4
//Write a program in C# Sharp to check whether a given string is Palindrome or not using recursion.
//Method will require two arguments, left and right, if at any point they do not match, return false
//On match, call the method moving the poiters towards each other.

Console.WriteLine("Enter to check if it is a palindrome recursivelly");
string inputString = Console.ReadLine();
int left = 0;
int right = inputString.Length - 1;

Console.WriteLine(CheckPalindromeRecursion(inputString, left, right));

bool CheckPalindromeRecursion(string input, int left, int right)
{
    if (left >= right) //If pointers meet/cross, it is a palindrome. Stops recursion once half of the word is checked
    {
        return true;
    }

    if (input[left] != input[right]) //If characters don't match at any point, it's not a palindrome. Stops recursion immediately with false
    {
        return false;
    }
    
    return CheckPalindromeRecursion(input, left + 1, right - 1); //If none of the prior conditions are met, checks to see if next iterations has an answer
}

#endregion