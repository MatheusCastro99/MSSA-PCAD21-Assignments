//Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.
//Each letter in magazine can only be used once in ransomNote.

//Example 1:
//Input: ransomNote = "aa", magazine = "ab"
//Output: false

//Example 2:
//Input: ransomNote = "aa", magazine = "aab"
//Output: true

//Thoughts:
//Dictionary keeping track of the letters in magazine and their counts.
//Iterate through ransomNote and check if each letter is present in the dictionary and has a count greater than 0, subtract 1 from the count as we iterate.

string ransomNote = "aa";
string magazine = "aab";

//create and loads dictionary with letter counts from magazine
LoadDictionary(magazine, out Dictionary<char, int> letterCounts);

Console.WriteLine($"Can construct ransom note '{ransomNote}' from magazine '{magazine}': {CanConstructRansomNote(ransomNote, letterCounts)}");

bool CanConstructRansomNote(string ransomNote, Dictionary<char, int> letterCounts)
{
    //Guard clause to check if ransomNote is longer than the total letters available in magazine
    if (ransomNote.Count() > letterCounts.Values.Sum())
    {
        return false;
    }

    //Guard clause to check if ransomNote is empty, in which case it can always be constructed
    if (ransomNote.Length == 0)
    {
        return true;
    }

    //Iterate through ransomNote and check if each letter is present in the dictionary and has a count greater than 0, subtract 1 from the count as we iterate.
    foreach (char letter in ransomNote)
    {
        if (!letterCounts.ContainsKey(letter) || letterCounts[letter] <= 0)
        {
            return false;
        }
        letterCounts[letter]--;
    }

    //If letterCount survives the iteration, then ransomNote can be constructed from magazine
    return true;
}

void LoadDictionary(string magazine, out Dictionary<char, int> loadedDictionary)
{
    loadedDictionary = new Dictionary<char, int>();
    foreach (char letter in magazine)
    {
        if (loadedDictionary.ContainsKey(letter))
        {
            loadedDictionary[letter]++;
        }
        else
        {
            loadedDictionary[letter] = 1;
        }
    }
}