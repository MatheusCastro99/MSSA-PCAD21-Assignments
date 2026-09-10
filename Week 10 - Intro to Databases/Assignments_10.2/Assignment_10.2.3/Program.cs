//Write a program in C# Sharp to find a string that starts and ends with a specific character.

//Test Data :
//   'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS'
//Input starting character for the string : A
//Input ending character for the string : M
//Expected Output :
//The city starting with A and ending with M is : AMSTERDAM

//Thoughts:
// LINQ approach to check city[0] and city[city.Length-1] chars

string[] cities = ["ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS"];

char firstChar = 'A';
char lastChar = 'M';

string[] selectedCities = cities
    .Where(city => 
        city[0] == firstChar && 
        city[city.Length-1] == lastChar)
    .ToArray();

Console.WriteLine($"The cities starting with {firstChar} and ending with {lastChar} are: {string.Join(", ", selectedCities)}");