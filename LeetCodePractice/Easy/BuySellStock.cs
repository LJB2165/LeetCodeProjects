using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    public class BuySellStock
    {
        public int MaxProfit(int[] prices)
        {
            int minPrice = int.MaxValue; // Initialize minPrice to a very high value
            int maxProfit = 0; // Initialize maxProfit to 0

            // Iterate through the array of prices
            for (int i = 0; i < prices.Length; i++)
            {
                // Update minPrice if the current price is lower
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }
                // Calculate the potential profit if selling at the current price
                else
                {
                    int profit = prices[i] - minPrice;
                    // Update maxProfit if the current profit is higher
                    if (profit > maxProfit)
                    {
                        maxProfit = profit;
                    }
                }
            }

            // Return the maximum profit found
            return maxProfit;
        }
    }
}
