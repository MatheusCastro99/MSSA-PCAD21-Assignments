//Given a string s, reverse only all the vowels in the string and return it.

//Vowels can appear in both lower and upper cases, and also appear more than once

//Thoughts:
//Create a string with vowels only and check if pointer is in that group (Contains?)
//When first vowel is found, drop a pointer there and keep iterating
//When second vowel is found, reverse the two

string input = "intelligent";

//ReverseVowelsBubble(input);

Console.WriteLine(ReverseVowelsOrder(input));

//Reverses the vowels in pairs
void ReverseVowelsBubble(string input)
{
    Console.WriteLine($"Original input: {input}");

    //creates a string with vowels in both cases for comparison
    string vowels = "aeiouAEIOU";
    char[] letters = input.ToCharArray();

    int vowelPointer = 0;
    bool firstVowel = true;

    for (int i = 0; i < input.Length; i++)
    {
        if (vowels.Contains(input[i]) && firstVowel)
        {
            vowelPointer = i;
            firstVowel = false;

            continue;
        }

        if(vowels.Contains(input[i]))
        {
            char temp = letters[i];
            letters[i] = letters[vowelPointer];
            letters[vowelPointer] = temp;

            firstVowel=true;
            continue;
        }
    }

    input = new(letters);
    Console.WriteLine($"Inverted string: {input}");
}

//Reverse entire order of vowels
string ReverseVowelsOrder(string input)
{
    Console.WriteLine(input);

    //creates a string with vowels in both cases for comparison
    string vowels = "aeiouAEIOU";
    char[] letters = input.ToCharArray();

    //create left and right pointers
    int leftPointer = 0; 
    int rightPointer = input.Length-1;

    //Keeps track of where vowels happened, and if it happened on the counterside
    int vowelPointer = 0;
    bool vowelFound = false;

    while (leftPointer < rightPointer)
    {
        if (vowels.Contains(input[leftPointer])) //found left vowel
        {
            if (vowelFound) //has right vowel waiting
            {
                //performs the swap and resets vowelFound to proceed
                char temp = letters[rightPointer];
                letters[rightPointer] = letters[vowelPointer];
                letters[vowelPointer] = temp;

                vowelFound = false; 

                //Console.WriteLine($"Left vowel found at {leftPointer} SWAP");
                leftPointer++;
                continue;
            }

            vowelPointer = leftPointer; //If vowel is found but do not have a counterpart, drops pointer there and enables vowelFound
            vowelFound=true;

            //Console.WriteLine($"Left vowel found at {leftPointer}");

        }

        leftPointer++; //if letters[leftPointer] is not a vowel, simply move pointer forward

        if (vowels.Contains(input[rightPointer])) //found right vowel
        {
            if(vowelFound) //has left vowel waiting
            {
                //performs the swap and resets vowelFound to proceed
                char temp = letters[rightPointer];
                letters[rightPointer] = letters[vowelPointer];
                letters [vowelPointer] = temp;

                vowelFound = false;

                //Console.WriteLine($"Right vowel found at {rightPointer} SWAP");
                rightPointer--;
                continue;
            }

            vowelPointer = rightPointer; //If vowel is found but do not have a counterpart, drops pointer there and enables vowelFound
            vowelFound = true;

            //Console.WriteLine($"Right vowel found at {rightPointer}");
        }

        rightPointer--; //if letters[rightPointer] is not a vowel, simply move pointer backwards

    }

    return new string(letters);
}