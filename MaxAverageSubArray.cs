using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-average-subarray-i/?envType=study-plan-v2&envId=leetcode-75
    /// </summary>
    public partial class Solution
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            double sum = 0, maxAvg;
            for (int i = 0; i < k; i++)
            {
                sum += nums[i];
            }
            maxAvg = sum / k;

            for (int i = k; i < nums.Length; i++)
            {
                sum += nums[i] - nums[i - k];
                maxAvg = Math.Max(maxAvg, sum /k);
            }

            return maxAvg;
        }
    }
}
