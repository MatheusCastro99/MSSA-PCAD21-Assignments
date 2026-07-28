//PROBLEM: Write a function that reverses a string. The input string is given as an array of characters s.

//CONSTRAINTS: You must do this by modifying the input array in-place. (Problem 344 in leetcode)

//THOUGHTS: Single iteration performing 3 way swap and stopping in the middle

string input = "Hello";

ReverseArray(input);

void ReverseArray(string input)
{
    char[] inputChars = input.ToCharArray();
    for (int i = 0; i < inputChars.Length/2; i++)
    {
        char temp = inputChars[i];
        inputChars[i] = inputChars[(inputChars.Length - 1) - i];
        inputChars[(inputChars.Length - 1) - i] = temp;
    }

    input = string.Join("", inputChars);
    Console.WriteLine(input);
}