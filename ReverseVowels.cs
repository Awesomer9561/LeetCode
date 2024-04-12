using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-vowels-of-a-string/?envType=study-plan-v2&envId=leetcode-75
    /// </summary>
    public partial class Solution
    {
        public string ReverseVowels(string s)
        {
            var vowels = "aeiou";
            var vowelsInStr = new List<char>();
            var newStr = new List<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (vowels.Contains(s[i], StringComparison.InvariantCultureIgnoreCase))
                {
                    newStr.Add('_');
                    vowelsInStr.Add(s[i]);
                }
                else
                {
                    newStr.Add(s[i]);
                }
            }

            for (int i = vowelsInStr.Count - 1; i >= 0; i--)
            {
                newStr[newStr.IndexOf('_')] = vowelsInStr[i];
            }
            return new string(newStr.ToArray());
        }
    }
}