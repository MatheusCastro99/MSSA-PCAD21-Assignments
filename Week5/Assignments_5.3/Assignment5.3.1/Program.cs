//You have a long flowerbed in which some of the plots are planted, and some are not. However, flowers cannot be planted in adjacent plots.
//Given an integer array flowerbed containing 0's and 1's, where 0 means empty and 1 means not empty, and an integer n.
//return true if n new flowers can be planted in the flowerbed without violating the no-adjacent-flowers rule and false otherwise.

//flowerbed[i] is 0 or 1.
//There are no two adjacent flowers in flowerbed.

//Thoughts: 3 slot wide sliding window checking, at each position, i-1 and i+i
//Fix edge cases (i==0, where i-1 == null | i == flowerbed.Length-1, where i+1 == null)

int[] flowerbed1 = [1, 0, 0, 0, 1];
int n1 = 1;

int[] flowerbed2 = [1, 0, 0, 0, 1];
int n2 = 2;

int[] flowerbed3 = [0];
int n3 = 0;

Console.WriteLine(CheckAvailability(flowerbed1, n1));
Console.WriteLine(CheckAvailability(flowerbed2, n2));
Console.WriteLine(CheckAvailability(flowerbed3, n3));

bool CheckAvailability(int[] flowerbed, int n)
{
    int newFlowers = 0;

    if (flowerbed.Length == 1 && flowerbed[0] == 0) //Edge-case input: [0]
    {
        flowerbed[0] = 1;
        newFlowers++;

        Console.WriteLine("Single element Array found. Terminating early");
        return true; //Terminates method early to prevent OutOfBounds
    }

    if (flowerbed[0] == 0 && flowerbed[1] == 0) //Cases where flowerbed[0] and flowerbed[1] == 0. Because for loop starts at i=1, the 0 index is not checked in the loop
    {
        flowerbed[0] = 1;
        newFlowers++;
    }

    for (int i = 1; i<flowerbed.Length - 1; i++) //First and last position excluded to prevent OutOfBounds in edge-cases, Also does not clear conditions on Length == 2
    {
        if(flowerbed[i-1] == 0 && flowerbed[i+1] == 0) //Sliding window checks for available spots
        {
            flowerbed[i] = 1; //New flower planted!
            newFlowers++;

            if (newFlowers == n) //the moment that newFlowerGoal reaches n, loop is terminated
            {
                break;
            }
        }
    } //If I have to count all the new flowers instead of simply meeting a goal, I could remove the break check
      //and let newFlowers countinh throughout the whole loop

    if (flowerbed[flowerbed.Length - 1] == 0 && flowerbed[flowerbed.Length - 2] == 0) //Similar to the beginning edge case, for loop also does not check last index
    {
        flowerbed[flowerbed.Length - 1] = 1;
        newFlowers++;
    }

    if (newFlowers >= n) //Checks if goal is met / passed
    {
        Console.WriteLine($"New Flowers planted: {newFlowers}");
        return true;
    }

    Console.WriteLine("No new flowers could be planted");
    return false;
}