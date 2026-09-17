//Given a string text, you want to use the characters of text to form as many instances of the word "balloon" as possible.
//You can use each character in text at most once. Return the maximum number of instances that can be formed.

//Example 1:
//Input: text = "nlaebolko"
//Output: 1

//Example 2:
//Input: text = "loonbalxballpoon"
//Output: 2

//Example 3:
//Input: text = "leetcode"
//Output: 0

//Thoughts:
//We can use a dictionary to count the occurrences of each character in the input string.
//We can create another dictionary to store the required counts of each character in the word "balloon".
//Afterwards, we can check for how many times we can "subtract" balloon dictionary from the input dictionary, and return the minimum number of times we can do that.

string input = "loonbalxballpoon";
Dictionary<char, int> charCount = new ();

foreach (char c in input) //loads charCount dictionary with the counts of each character in the input string
{
    if (charCount.ContainsKey(c))
    {
        charCount[c]++;
    }
    else
    {
        charCount[c] = 1;
    }
}

Dictionary<char, int> balloonCount = new ()
{
    { 'b', 1 },
    { 'a', 1 },
    { 'l', 2 },
    { 'o', 2 },
    { 'n', 1 }
};

var maxInstances = int.MaxValue;

foreach (var kvp in balloonCount)
{
    char c = kvp.Key;
    int requiredCount = kvp.Value;

    if (!charCount.ContainsKey(c)) //Checks to see if character is present in the input string. If not, we cannot form any instances of "balloon".
    {
        maxInstances = 0;
        break;
    }

    int availableCount = charCount[c];
    maxInstances = Math.Min(maxInstances, availableCount / requiredCount); //Update the maximum instances based on the available characters
}