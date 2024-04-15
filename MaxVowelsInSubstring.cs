using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-number-of-vowels-in-a-substring-of-given-length/?envType=study-plan-v2&envId=leetcode-75
    /// </summary>
    public partial class Solution
    {
        public int MaxVowels(string s, int k)
        {
            var vowels = "aeiou";
            var vowelCount = 0;
            for (int i = 0; i < k; i++)
            {
                if (vowels.Contains(s[i]))
                {
                    vowelCount++;
                }
            }

            var maxVowelCount = vowelCount;

            for (var i = k; i < s.Length; i++)
            {
                if (vowels.Contains(s[i - k]))
                {
                    vowelCount--;
                }
                if (vowels.Contains(s[i]))
                {
                    vowelCount++;
                }

                if (maxVowelCount < vowelCount)
                {
                    maxVowelCount = vowelCount;
                }
            }
            return maxVowelCount;

            //abciiidef
            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (vowels.Contains(s[i]))
            //    {
            //        var newString = "";
            //        if (i + k > s.Length)
            //        {
            //            newString = s.Substring(i);
            //        } 
            //        else
            //        {
            //            newString = s.Substring(i, k);
            //        }
            //        var vowelCount = newString.Count(vowels.Contains);
            //        if (maxVowelCount < vowelCount)
            //        {
            //            maxVowelCount = vowelCount;
            //        }
            //    }
            //}
        }
    }
}
