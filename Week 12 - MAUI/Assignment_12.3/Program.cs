//(#1047) You are given a string s consisting of lowercase English letters.
//A duplicate removal consists of choosing two adjacent and equal letters and removing them.
//We repeatedly make duplicate removals on s until we no longer can.
//Return the final string after all such duplicate removals have been made. It can be proven that the answer is unique.

//Example 1:
//Input: s = "abbaca"
//Output: "ca"

//Explanation:
//In "abbaca" we could remove "bb" since the letters are adjacent and equal, and this is the only possible move.
//The result of this move is that the string is "aaca", of which only "aa" is possible,
//so the final string is "ca".

//Example 2:
//Input: s = "azxxzy"
//Output: "ay"

//Thoughts:
//First instinct is a recursive solution, however, I can think of other ways as well.
//I can use a pointer approach, keeping track of the current index and checking if the current character is equal to the next character.
//If they are equal, I can remove both characters and move the pointer back one index to check for new adjacent duplicates.

//Best way to do this is in a while loop, checking if the current index is less than (<) the length of the string - 1
//This will naturally prevent an index out of range error when checking the next character.
//Also, before performing i--, I need to check if i is greater than 0, otherwise I will get an index out of range error

string s = "abbaca";
List<char> stack = new(s);

string RemoveAdjacentDuplicates(List<char> stack)
{
    int i = 0;
    while (i < stack.Count - 1) //i < stack.Count - 1 to prevent index out of range (<= would always cause an error)
    {
        if (stack[i] == stack[i + 1])
        {
            //When RemoveAt is called, the list is re-indexed, so we need to remove the current index twice to remove both adjacent duplicates.
            stack.RemoveAt(i);
            stack.RemoveAt(i);

            if (i > 0) i--; //If check to prevent index out of range error when i is 0.
        }
        else
        {
            i++;
        }
    }

    return new string(stack.ToArray());
}