using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/description/?envType=study-plan-v2&envId=leetcode-75
    public partial class Solution
    {
        public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            var listOfGreatest = new List<bool>();

            for (int i = 0; i < candies.Length; i++)
            {
                listOfGreatest.Add(candies.All(kidWCandy => candies[i] + extraCandies >= kidWCandy));
            }

            return listOfGreatest;
        }
    }
}
