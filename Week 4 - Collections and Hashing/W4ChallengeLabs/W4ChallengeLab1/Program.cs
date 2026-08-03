//PROBLEM: Write a method that checks if given number (positive integer) contains digit 3.
//CONSTRAINTS: Do not convert number to other type. Do not use built-in functions like Contains(), StartsWith(), etc.
//HINT: Solution involves progressive division
//THOUGHTS: use modular operator to see if the remainder is 3 when divided by 6

int digit = 12345;

ContainsDigitThree(digit);
void ContainsDigitThree(int number)
{
    while (number > 0)
    {
        if (number % 10 == 3)
        {
            Console.WriteLine("Contains 3!!");
            return;
        }
        number /= 10;
    }
    Console.WriteLine("Does not contains 3");
};