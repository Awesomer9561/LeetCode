using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/move-zeroes/?envType=study-plan-v2&envId=leetcode-75
    /// </summary>
    public partial class Solution
    {
        public void MoveZeroes(int[] nums)
        {
            var items = nums.Where(x => x != 0).ToList();

            for (int i = 0; i < nums.Length; i++)
            {
                if (i < items.Count)
                {
                    nums[i] = items[i];
                }
                else
                {
                    nums[i] = 0;
                }
            }
        }
    }
}
