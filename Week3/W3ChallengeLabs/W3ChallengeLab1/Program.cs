// string palindrome checker

Console.WriteLine("Enter a word to check if it is a palindrome: ");
string palindromeCandidate = Console.ReadLine();

IsPalindrome(palindromeCandidate);

void IsPalindrome(string palindromeCandidate)
{
    for (int i = 0; i < (palindromeCandidate.Length/2); i++)
    {
        if (palindromeCandidate[i] != palindromeCandidate[(palindromeCandidate.Length - 1) - i])
        {
            Console.WriteLine("It is not a palindrome");
            return;
        }
    }

    Console.WriteLine("It is a palindrome!");
}