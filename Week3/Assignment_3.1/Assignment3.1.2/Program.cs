// Leap Year requirements:
// Condition 1: The year is evenly divisible by 4
// Prohibitive Condition: If the year is also evenly divisible by 100, it is not a leap year.
// Exception: However, if the year is divisible by 400, it is a leap year.

//Natural language:
//If a year can be divided by 4 and is not multiple of 100 -> Leap year
//Or if year can be divided by 400 -> Leap year

//PseudoCode:
//year % 4 == 0 and year % 100 != 0 -> Leap year
//year % 400 == 0 -> Leap year

int year;

Console.WriteLine("Enter a year to check if it is a leap year: ");
year = Convert.ToInt32(Console.ReadLine());

bool IsLeapYear(int year)
{
    if ( year % 4 == 0 ) // condition
    {
        if (year % 100 == 0) // prohibitive condition
        {
            if (year % 400 == 0) // exception
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else 
        {
            return true;
        }
    }
    else { return false; }
}

Console.WriteLine(IsLeapYear(year));