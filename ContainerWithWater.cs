using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    /// <summary>
    /// https://leetcode.com/problems/container-with-most-water/description/?envType=study-plan-v2&envId=leetcode-75
    /// </summary>
    public partial class Solution
    {
        public int MaxArea(int[] height)
        {
            int maxArea = 0;
            int left = 0;
            int right = height.Length - 1;

            while (left < right)
            {
                // Calculate the area formed by the two lines
                int area = Math.Min(height[left], height[right]) * (right - left);
                maxArea = Math.Max(maxArea, area);

                // Move the pointer pointing to the shorter line towards the center
                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return maxArea;

            // [1,8,6,2 || 5,4,8,3,7]


            //var heightIndexes = new List<(int, int)>();

            //for (int i = 0; i < length; i++)
            //{
            //    heightIndexes.Add((height[i], i));
            //}
            //heightIndexes.Sort();

            //int leftIndex = 0, rightIndex = length - 1;
            //while (rightIndex - leftIndex> 0)
            //{
            //    var leftHeight = heightIndexes[leftIndex];
            //    var rightHeight = heightIndexes[rightIndex];

            //    var distance = rightHeight.Item2 - leftHeight.Item2;
            //    var minHeight = Math.Min(leftHeight.Item1, rightHeight.Item1);
            //    var area = distance * minHeight;
            //    if (area > maxArea)
            //    {
            //        maxArea = area;
            //    }

            //    leftIndex++;
            //    rightIndex--;
            //}

            //return maxArea;
        }
    }
}
