//Divisible by 2 or 3
//Given two integers, write a method that returns their multiplication if they are both divisible by 2 or 3, otherwise returns their sum.

//THOUGHTS: Complex logic statement to check by requirements

int num1 = 9;
int num2 = 6;

Console.WriteLine($"Num1: {num1}\nNum2: {num2}\nResult: {DoTheTrick(num1, num2)}");
int DoTheTrick(int num1, int num2)
{
    if ((num1 % 2 == 0 && num2 % 2 == 0) || (num1 % 3 == 0 && num2 % 3 == 0))
    {
        return num1*num2;
    }
    return num1+num2;
}