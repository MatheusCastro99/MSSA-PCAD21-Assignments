//You are a student who has recently taken an exam with your classmates.
//However, the professor has not yet provided the students with a sorted list of exam scores.
//To make things easier, you write a program to sort exam scores in ascending order using the selection sort algorithm.
//This way, you can obtain the sorted list of scores and see how you performed compared to your classmates.
//Also, you choose selection sort since that is an easy way of implementation.

//Selection Sort: Nested loop with Two Pointers Methodology to identify lowest value and move it to front of array
//min start at first element, then go through array finding next lowest
//Whenever loop ends, perform a swap if new min was found through iteration

int[] grades = [7, 3, 8, 1, 9, 7, 6, 5, 3, 2, 10, 4];

Console.WriteLine($"Original Grades List: {string.Join(", ", grades)}");

SortGrades(grades);

Console.WriteLine($"Sroted Grades List:   {string.Join(", ", grades)}");

void SortGrades(int[] grades)
{
    int min;
    int minIndex = 0;
    bool sorted = true;

    for (int i = 0; i < grades.Length; i++) //Controls how many iterations will happen
    {
        min = grades[i]; //min is set to the value at i, so inner loop can safely starts at i+1

        for (int j = i+1; j < grades.Length; j++) //each actual iteration
        {                                         //last value doesn't iterate, but array will be sorted by then
            if (grades[j] < min)
            {   
                //store index and value of number lower than current min
                min = grades[j];
                minIndex = j;

                sorted = false; //triggers swap operation after inner loop is completed
            }
        }

        if (!sorted)
        {
            int temp = grades[i];
            grades[i] = min;
            grades[minIndex] = temp;

            //(grades[i], grades[minIndex]) = (min, grades[i]); //tuple assignment
            
            sorted = true;
        }
    }
}