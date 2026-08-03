//ASSIGNMENT 5.1.1
//Given an integer x, return true if x is a palindrome, and false otherwise.

int x = 122; // Example input

IsPalindrome(x);

bool IsPalindrome (int x)
{
    string xString = x.ToString ();
    for (int y = 0; y < xString.Length/2; y++)
    {
        if (xString[y] != xString[(xString.Length - 1) - y])
        {
            Console.WriteLine("Not a palindrome");
            return false;
        }
    }

    Console.WriteLine("Palindrome found");
    return true;
}
Console.WriteLine("\n=================================================\n");


//ASSIGNMENT 5.1.2
//Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.

int givenNumber = 1234;
IndividualDigitsSum(givenNumber);

void IndividualDigitsSum(int numbers)
{
    int sum = 0;
    foreach (var number in numbers.ToString())
    {
        Console.WriteLine(number);
        sum += (number - '0'); // - '0' trick to convert char to int
    }

    Console.WriteLine($"The sum of the digits is {sum}");
}
Console.WriteLine("\n=================================================\n");


//ASSIGNMENT 5.1.3
//Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

int[] nums = [1, 2, 3, 4];
//Dictionary<int, int> countValues = new();
HashSet<int> seen = new(); //Since exercise does not require keeping track of duplicates, a Hash will give 0(1) time and avoid storing unnecessary data

Console.WriteLine(IsDuplicatePresentHash(nums));

bool IsDuplicatePresentHash(int[] nums) 
{
    foreach (var number in nums) 
    {
        if (!seen.Add(number)) //HashSet.Add() returns true if element is new to set and successfully added, and false if element is already present in set
        {
            return true; //Duplicate found and method terminated instantly
        }
    }

    return false;
}

//bool IsDuplicatePresentDict(int[] numbers)
//{
//    foreach (int number in numbers) 
//    {
//        if(countValues.ContainsKey(number))
//        {
//            return true;
//        }
//        else
//        {
//            countValues.Add(number, 1);
//        }
//    }

//    return false;
//}