using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/max-number-of-k-sum-pairs/?envType=study-plan-v2&envId=leetcode-75
    /// </summary>
    public partial class Solution
    {
        public int MaxOperations(int[] nums, int k)
        {
            var response = 0;
            var frequency = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (!frequency.ContainsKey(num))
                {
                    frequency[num] = 0;
                }
                frequency[num]++;
            }

            foreach (var num in nums)
            {
                var pair = k - num;
                if (frequency.ContainsKey(pair) && frequency[pair] > 0 && frequency[num] > 0)
                {
                    if (num == pair)
                    {
                        response += frequency[num] / 2;
                    }
                    else
                    {
                        response += Math.Min(frequency[num], frequency[pair]);
                    }
                    frequency[num] = 0;
                    frequency[pair] = 0;
                }
            }

            return response;
        }
    }
}
