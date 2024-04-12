using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/product-of-array-except-self/?envType=study-plan-v2&envId=leetcode-75
    /// </summary>
    public partial class Solution
    {
        public string ReverseWords(string s)
        {
            var words = s.Trim().Split(' ');
            var response = string.Join(" ", words.Where(word => !string.IsNullOrEmpty(word)).Reverse());

            return response;
        }
    }
}
