//Given a string, write a method which returns sum of all digits in that string. Assume that string contains only single digits.

Console.WriteLine("enter the string containing mixed single digits and letters: ");
string mixed = Console.ReadLine();

SumDigitsInString(mixed);
void SumDigitsInString(string mix)
{
    int sum = 0;

    foreach (char c in mix)
    {
        int thisNum = 0;
        Int32.TryParse(c.ToString(), out thisNum);

        sum += thisNum;
    }

    Console.WriteLine($"The sum of the digits is: {sum}");
} 