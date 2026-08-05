//You are climbing a staircase. It takes n steps to reach the top.
//Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?

//LeetCode Constraints: 1 <= n <= 45

//n == number of steps
//c == ways to climb

//Thoughts: examples given reminds of fibbonacci sequence
//Each step added will contain C(n-1) and then some more
//Recursion / Iteration could account for fibonacci pattern

//It seems like c will always correspond to nth number of fibonacci sequence

Console.WriteLine("Enter how many steps you stairs have: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"You can climb these stairs {DifferentWaysToClimb(n)} different ways!");
int DifferentWaysToClimb(int n)
{
    if (n == 1) return 1; //Do not need to worry about n < 1 due to constraints

    int SecToLastNum = 0; // Seeds to start sequence
    int lastNum = 1;
    int waysToClimb = 0;

    for (int i = 2; i <= n + 1; i++) //starts at 2 to account for a=0 and b=1. n+1 accounts for first iteration since climbing 0 steps is not a valid action
    {
        waysToClimb = SecToLastNum + lastNum;
        SecToLastNum = lastNum;
        lastNum = waysToClimb;
    }

    return waysToClimb;
}