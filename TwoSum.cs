using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
    /// You can return the answer in any order.
    /// </summary>
    public class TwoSum
    {
        public static int[] Calculate(int[] nums, int target)
        {
            int a = 0, b = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target && i != j)
                    {
                        a = i;
                        b = j;
                        break;
                    }
                }
                if (a != 0 &&  b != 0)
                {
                    break;
                }
            }

            return new int[] { a, b};
        }
    }
}
