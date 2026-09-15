//You are given an array prices where prices[i] is the price of a given stock on the ith day.
//You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

//Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.ou are given an array prices where prices[i] is the price of a given stock on the ith day.
//You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

//Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.

int[] prices = [7, 1, 5, 3, 6, 4];

Console.WriteLine(MaxProfit(prices));

int MaxProfit(int[] prices)
{
    int minPrice = prices[0];
    int maxPrice = 0;

    int currProfit;
    int maxProfit = 0;

    for (int i = 0; i < prices.Length; i++)
    {
        //Checks if current price is greater than previous max Price (If prices went up)
        if (prices[i] > maxPrice)
        { 
            maxPrice = prices[i];
            currProfit = maxPrice - minPrice; //Profit at each possible sale

            //Keeps track of biggest profit possible
            if (currProfit > maxProfit)
            { 
                maxProfit = currProfit;
            }
        }

        //Checks for minimum price (Prices going below previous minimum)
        if (prices[i] < minPrice)
        {
            minPrice = prices[i];
            maxPrice = 0; //If a new min price is found, resets max price since we cannot sell it in the past
        }
    }

    return maxProfit;
}