//You are given two strings word1 and word2. Merge the strings by adding letters in alternating order, starting with word1.
//If a string is longer than the other, append the additional letters onto the end of the merged string.
//Return the merged string.

//Figure out which word is the smallest and run a single for loop on it
//for each iteration, in a char array or new string, append word1[i] and word2[i]
//after the loop is finished, append the rest of the largest word to the answer

string word1 = "ab";
string word2 = "pqrs";

MergeWords(word1, word2);

void MergeWords(string word1, string word2)
{
    //Ternary operations will determine smallest and largest words
    string smallest = word1.Length < word2.Length ? word1 : word2; //Math.Min(word1, word2) and Math.Max(word1, word2) would also work in the place of ternaries
    string largest = word1.Length > word2.Length ? word1 : word2;

    List<char> ans = new();

    for (int i = 0; i < smallest.Length; i++) //Merges two words into ans List
    {
        ans.Add(word1[i]);
        ans.Add(word2[i]);
    }

    string? remainder = largest.Substring(smallest.Length); //determines if there are remaining letters
    if (remainder != null)
    {
        ans.AddRange(remainder); //adds those letters to the end of ans List
    }

    string result = new(ans.ToArray());
    Console.WriteLine(result);
}