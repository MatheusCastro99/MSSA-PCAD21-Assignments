int[] inputArray =  [0, 2, 1, 1, 9, 1, 1];

for (int i = 0; i < inputArray.Length; i++)
{
    if ((inputArray[i] == 1) && (inputArray[i+1] == 1))
    {
        inputArray[i] = 0;
        inputArray[(i+1)] = 0;

        break;
    }
}

Console.WriteLine(string.Join(", ", inputArray));