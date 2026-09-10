//You are given an array of characters letters that is sorted in non-decreasing order, and a character target.
//There are at least two different characters in letters.
//Return the smallest character in letters that is lexicographically greater than target.
//If such a character does not exist, return the first character in letters.

//Example 1:
//Input: letters = ["c","f","j"], target = "a"
//Output: "c"
//Explanation: The smallest character that is lexicographically greater than 'a' in letters is 'c'.

//Example 2:
//Input: letters = ["c","f","j"], target = "c"
//Output: "f"
//Explanation: The smallest character that is lexicographically greater than 'c' in letters is 'f'.

//Example 3:
//Input: letters = ["x","x","y","y"], target = "z"
//Output: "x"
//Explanation: There are no characters in letters that is lexicographically greater than 'z' so we return letters[0].You are given an array of characters letters that is sorted in non-decreasing order, and a character target. There are at least two different characters in letters.
//Return the smallest character in letters that is lexicographically greater than target. If such a character does not exist, return the first character in letters.

//THOUGHTS:
//letters sorted in non-decreasing order == alphabetical order allowing repeating characters
//I could create a char list with all the letters for reference. Having an external reference would eliminate having to deal with repeated chars

//check #1: Check the last letter of the list and the target letter, if index of last letter < index of target, return letters[0]
//If index of last letter == index of target, we should also return letters[0] (since there wouldn't be a next letter on letters)

char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

char[] letters = ['c', 'f', 'j'];
int lastLetterIndex = letters.Length - 1;
char target = 'a';

Console.WriteLine($"The next letter after {target} on the list {string.Join(", ", letters)} is {NextLetter(letters, target)}");

char NextLetter(char[] letters, char target)
{
    //Edge Case when target => last letter on letters
    if (alphabet.IndexOf(target) >= alphabet.IndexOf(letters[lastLetterIndex]))
    {
        return letters[0];
    }

    else
    {
        //initalize a char and an index iterator that will iterate over alphabet checking the next letter that is present on letters
        char valid = target;
        int index = alphabet.IndexOf(target);

        do
        {
            valid = alphabet[index + 1]; //checks the next char over in alphabet and move the index
            index++;
        }
        while (!letters.Contains(valid)); //when a match is found, exits the loop and returns valid

        return valid;
    }
}
