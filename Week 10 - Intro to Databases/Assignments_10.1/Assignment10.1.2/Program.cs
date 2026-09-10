//Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.

//Example 1:
//Input: n = 3
//Output: ["((()))", "(()())", "(())()", "()(())", "()()()"]

//Thoughts:
//Well formed parentheses means that number of ( == number of ). Also means that lenght of string is always 2n
//We can alwas add ( as long as ( <= n. But we can only add ) as long as ) <= (
//Output is a string[] with all possible solution, which hints at a tree structure adding each possible solution to the list
//I could implement a tree structure keeping track of all possible combinations.
//I do not necessarily need to keep track of all possible combinations, but I do have to check them to validate possible options

//Upon Research, I figured out that this is a Catalan Number problem, with pre-defined formulas and algorithms
//There must be a way to combine Catalan Number formulas together with pre-established rules (lenght of valid string is always 2n, number of ( == number of ))
//To create a targeted solution instead of simply checking and validating every possible combination

//Solution generated with Copilot's help upon entering the findings of Catalan Numbers and the pre-defined rules

var solutions = GenerateParenthesis(3);

string inlineOutput = "[" + string.Join(", ", solutions) + "]";
Console.WriteLine(inlineOutput);

IList<string> GenerateParenthesis(int n)
{
    List<string> results = new List<string>();
    if (n <= 0) return results;

    // 1. Calculate how many valid strings exist in total
    long totalSolutions = CalculateCatalan(n);

    // 2. Direct-construct each string one by one using its index/rank
    for (long i = 0; i < totalSolutions; i++)
    {
        results.Add(GetValidStringAtRank(n, i));
    }

    return results;
}

string GetValidStringAtRank(int n, long rank)
{
    string result = "";
    int openRemaining = n;
    int closeRemaining = n;

    // Every solution has a fixed length of 2 * n
    for (int step = 0; step < n * 2; step++)
    {
        // If we ran out of open parentheses, we can only add close ones
        if (openRemaining == 0)
        {
            result += ")";
            closeRemaining--;
            continue;
        }

        // Look ahead: how many valid endings exist if we place a '(' here?
        long validWaysWithOpen = CountWays(openRemaining - 1, closeRemaining);

        if (rank < validWaysWithOpen)
        {
            result += "(";
            openRemaining--;
        }
        else
        {
            result += ")";
            rank -= validWaysWithOpen; // Skip past the '(' paths we aren't taking
            closeRemaining--;
        }
    }

    return result;
}

long CountWays(int o, int c)
{
    if (o < 0 || c < 0 || o > c) return 0;
    return Choose(o + c, o) * (c - o + 1) / (c + 1);
}

// Helper: Standard Combinations formula nCr
long Choose(int n, int r)
{
    if (r < 0 || r > n) return 0;
    long ans = 1;
    for (int i = 1; i <= r; i++)
    {
        ans = ans * (n - r + i) / i;
    }
    return ans;
}

long CalculateCatalan(int n)
{
    return Choose(2 * n, n) / (n + 1);
}