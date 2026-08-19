//Given two strings s and t, return true if t is an anagram of s, and false otherwise.

//Anagram: Word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

//Thoughs: parse each character into a dictionary, counting how many times they appear
//Do that for each string, after, sort dictionaries by alphabetical order
//If words are anagram to each other, sorted dictionaries will be exaclty the same

using System.Collections.Immutable;

string input1 = "anagram";
string input2 = "nagaram";

Console.WriteLine(IsAnagram(input1, input2));

bool IsAnagram(string input1, string input2)
{
    //quick check that would immediately disqualify anagram
    if(input1.Length != input2.Length)
    {
        return false;
    }

    //now that the length of both strings are stablished to be the same, we can safely use 1 for loop to create both dictionaries
    Dictionary<char, int> input1Dict = new();
    Dictionary<char, int> input2Dict = new();

    for (int i=0; i < input1.Length; i++) //populates both dictionaries
    {
        if (input1Dict.ContainsKey(input1[i])) //checks if char is already present in dictionary
        {
            input1Dict[input1[i]]++; //gets the value and the char key and adds 1 (counting)
        }

        else
        {
            input1Dict.Add(input1[i], 1);
        }

        if (input2Dict.ContainsKey(input2[i]))
        {
            input2Dict[input2[i]]++;
        }

        else
        {
            input2Dict.Add(input2[i], 1);
        }
    }

    #region DEBUGGING
    //Display Unsorted Dictionaries
    //input1Dict.ToList().ForEach(kvp => Console.WriteLine($"{kvp.Key} -> {kvp.Value}"));
    //Console.WriteLine();
    //input2Dict.ToList().ForEach(kvp => Console.WriteLine($"{kvp.Key} -> {kvp.Value}"));

    //Display Sorted Dictionaries
    //input1Dict.ToImmutableSortedDictionary().ToList().ForEach(kvp => Console.WriteLine($"{kvp.Key} -> {kvp.Value}"));
    //Console.WriteLine();
    //input2Dict.ToImmutableSortedDictionary().ToList().ForEach(kvp => Console.WriteLine($"{kvp.Key} -> {kvp.Value}"));

    //Produces same result, error is in comparison. Simple == or Equals() compare by memory reference, not actual dict content
    #endregion

    //LINQ Approach to compare dictionaries content
    if (input1Dict.All(kvp => input2Dict.TryGetValue(kvp.Key, out var val) && Equals(kvp.Value, val)))
    {
        return true;
    }

    return false;
}