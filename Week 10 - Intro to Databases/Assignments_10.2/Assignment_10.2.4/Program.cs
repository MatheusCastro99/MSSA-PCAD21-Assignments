//Write a program in C# Sharp to create a list of numbers and display numbers greater than 80.

//Test Data :
//      55 200 740 76 230 482 95
//Expected Output :
//The numbers greater than 80 are :
//200
//740
//230
//482
//95

int[] numberList = [55, 200, 740, 76, 230, 482, 95];

int[] filteredNums = numberList
    .Where(n => 
        n > 80)
    .ToArray();

Console.WriteLine($"The numbers greater than 80 are: {string.Join(", ", filteredNums)}");