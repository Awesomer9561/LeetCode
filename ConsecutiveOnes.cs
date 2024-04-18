using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    /// <summary>
    /// https://leetcode.com/problems/max-consecutive-ones-iii/?envType=study-plan-v2&envId=leetcode-75
    /// </summary>
    public partial class Solution
    {
        public int LongestOnes(int[] nums, int k)
        {
            int maxOnes = 0;
            int left = 0;
            int zeroCount = 0;

            for (int right = 0; right < nums.Length; right++)
            {
                if (nums[right] == 0)
                {
                    zeroCount++;
                }

                // Shrink the window from the left if zeroCount exceeds k
                while (zeroCount > k)
                {
                    if (nums[left] == 0)
                    {
                        zeroCount--;
                    }
                    left++;
                }

                // Update maxOnes with the current window size
                maxOnes = Math.Max(maxOnes, right - left + 1);
            }

            return maxOnes;
        }
    }
}
