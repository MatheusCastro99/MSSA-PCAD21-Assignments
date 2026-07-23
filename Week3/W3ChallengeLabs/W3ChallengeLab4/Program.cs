//DESCRIPTION AND LINE OF THOUGHT
//You are given a string s consisting only of uppercase English letters.
//You can apply some operations to this string where, in one operation, you can remove any occurrence of one of the substrings "AB" or "CD" from s.

//Return the minimum possible length of the resulting string that you can obtain.
//Note that the string concatenates after removing the substring and could produce new "AB" or "CD" substrings.

//EX: string s = "ABFCACDB"
//step 1: remove AB from s -> "FCACDB". Step 2: remove CD from s -> "FCAB". Step 3: remove AB from s -> "FC"
//Output s.Length -> 2

//LINE OF THOUGHT =======================================================================================================================================================

//Recursive method to check for occurrences of AB || CD in string s
//   - if occurence is found, remove it from s and recall method with new s as argument
//   - if occurence is not found, return s.Length
//   - Opted for creating a bool IsOcurrenceFound so recursion will happen after a full iteration of the sentence, and not at each occurrence
//Might want to keep original string and operational string separated

//Stack method:
//   - Pushes first char in the sequence to the stack
//   - enters the loop that will compare the sequence[i] to the last char in the Stack with Stack.Peak()

using System.Collections;

string letters = "CCCCDDDD";
string lettersOps = letters;

//Console.WriteLine($"Initial string: {letters}\nMinimum Length {MinLength(lettersOps)}\nFinal string: {lettersOps}");
Console.WriteLine($"Initial string: {letters}\nMinimum Length {MinLengthWithStack(lettersOps)}\nFinal string: {lettersOps}");


//int MinLength(string sentence)
//{
//    bool IsOcurrenceFound = false;

//    for (int i = 0; i < (lettersOps.Length-1); i++) // Length-1 to prevent out of bounds since I am checking simultaneously i and i+1
//    {
//        if ((lettersOps[i] == 'A' && lettersOps[i + 1] == 'B') || (lettersOps[i] == 'C' && (lettersOps[i + 1] == 'D')))
//        {
//            lettersOps = lettersOps.Remove(i, 2);
//            IsOcurrenceFound = true;
//          //Console.WriteLine("Occurrence found");
//        }
//    }

//    if (IsOcurrenceFound) //Recursion occurs after the whole string is iterated instead after each occurence is found
//    {
//        return MinLength(lettersOps);
//    }

//    return lettersOps.Length;
//}

int MinLengthWithStack(string sentence)
{
    Stack<char> lettersStack = new("");
    lettersStack.Push(sentence[0]);

    for ( int i = 1; i < sentence.Length; i++ )
    {
        if ((sentence[i] == 'B' && lettersStack.Peek() == 'A') || (sentence[i] == 'D' && lettersStack.Peek() == 'C'))
        {
            lettersStack.Pop();

            if(lettersStack.Count == 0 && (i+1<sentence.Length)) //If stack becomes empty after pop() and next index is not out of bounds
            {                                                    // pushes the next index to the Stack (Push(sentence[i+1])) and skips the iteration for that char (i++)
                lettersStack.Push(sentence[i + 1]);
                i++;
            }
            continue;
        }

        lettersStack.Push(sentence[i]);
    }

    lettersOps = string.Join("", lettersStack);
    return lettersStack.Count;
}