using System;
using System.Collections.Generic;
using System.Linq;

public class SumOfCoins
{
    public static void Main(string[] args)
    {
        var availableCoins = new[] { 1, 2, 5, 10, 20, 50 };
        var targetSum = 923;

        var selectedCoins = ChooseCoins(availableCoins, targetSum);

        Console.WriteLine($"Number of coins to take: {selectedCoins.Values.Sum()}");
        foreach (var selectedCoin in selectedCoins)
        {
            Console.WriteLine($"{selectedCoin.Value} coin(s) with value {selectedCoin.Key}");
        }
    }

    public static Dictionary<int, int> ChooseCoins(IList<int> coins, int targetSum)
    {
        Dictionary<int, int> result = new Dictionary<int, int>();

        coins = coins.OrderByDescending(x => x).ToList();

        for (int i = 0; i < coins.Count; i++)
        {
            int currentCoin = coins[i];

            if (targetSum >= currentCoin)
            {
                result.Add(currentCoin, 0);
            }

            while (targetSum >= currentCoin)
            {
                result[currentCoin]++;
                targetSum -= currentCoin;
            }
        }

        return result;
    }
}