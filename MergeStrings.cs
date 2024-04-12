using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    //https://leetcode.com/problems/merge-strings-alternately/description/?envType=study-plan-v2&envId=leetcode-75
    internal class MergeStrings
    {
        public string MergeAlternately(string word1, string word2)
        {
            var result = "";

            if (word1.Length == word2.Length)
            {
                for (int i = 0; i < word1.Length; i++)
                {
                    result += $"{word1[i]}{word2[i]}";
                }
            }
            else if (word1.Length > word2.Length)
            {
                for (int i = 0; i < word2.Length; i++)
                {
                    result += $"{word1[i]}{word2[i]}";
                }
                result += word1[(word2.Length)..];
            }
            else if (word1.Length < word2.Length)
            {
                for (int i = 0; i < word1.Length; i++)
                {
                    result += $"{word1[i]}{word2[i]}";
                }
                result += word2[(word1.Length)..];
            }
            return result;
        }
    }
}
