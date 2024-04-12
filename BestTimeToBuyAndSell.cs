using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Transactions;

namespace LeetCode
{
    /// <summary>
    /// You are given an array prices where prices[i] is the price of a given stock on the ith day.
    /// You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
    /// Return the maximum profit you can achieve from this transaction.If you cannot achieve any profit, return 0.
    /// </summary>
    public class BestTimeToBuyAndSell
    {
        public static int Calculate(int[] prices)
        {
            int profit = 0;
            // 7, 8, 2, 50, 1, 6, 3, 7, 8, 1, 9
            // 2, 1, 7, 3, 8, 3, 6, 2, 1, 8


            // 7,1,5,3,6,4
            // 
            var list = new List<int>(prices);
            var maxNumber = list.Max();
            var minNumber = list.Min();

            var indexOfMin = list.IndexOf(minNumber);
            var indexOfMax = list.IndexOf(maxNumber);

            if (indexOfMin < indexOfMax)
            {
                profit = maxNumber - minNumber;
            }
            else
            {
                var newMinArr = prices[indexOfMin..];
                var newMaxArr = prices[..indexOfMax];
                var intermediateArr = prices[(indexOfMax+1)..indexOfMin];

                int profitFromMax = 0, profitFromMin = 0, profitFromId = 0;
                if (newMaxArr.Length > 0)
                {
                    profitFromMax = newMaxArr.Max() - newMaxArr.Min();
                }
                if (newMinArr.Length > 0)
                {
                    profitFromMin = newMinArr.Max() - newMinArr.Min();
                }
                if (intermediateArr.Length > 0)
                {
                    profitFromId = intermediateArr.Max() - intermediateArr.Min();
                }
                profit = profitFromMax > profitFromMin ? profitFromMax : profitFromMin;
                profit = profit < profitFromId ? profitFromId : profit;
            }

            return profit;
        }
    }
}
