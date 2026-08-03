Console.WriteLine("Insert line: ");
string testString = Console.ReadLine();

Console.WriteLine("Insert target character to be counted");
char targetChar;
char.TryParse(Console.ReadLine(), out targetChar);

int targetCount = 0;

foreach (char letter in testString)
{
    if (letter == targetChar)
    {
        targetCount++;
    }
}

Console.WriteLine(targetCount);