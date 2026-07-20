using System.Text;

string ReturnEvenNumbers()
{
    StringBuilder evenNumbers = new(150);

    for (int i = 1; i < 100; i++)
    {
        if (i%2 == 0)
        {
            evenNumbers.Append(i);
            evenNumbers.Append(", ");
        }
    }

    evenNumbers.Insert(0, "Even Numbers >0 && <100: \n");
    evenNumbers.Remove((evenNumbers.Length - 2), 2);
    evenNumbers.Append('.');

    return evenNumbers.ToString();
}

Console.WriteLine(ReturnEvenNumbers());