using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// https://leetcode.com/problems/is-subsequence/?envType=study-plan-v2&envId=leetcode-75
    /// </summary>
    public partial class Solution
    {
        public bool IsSubsequence(string s, string t)
        {
            //t- ahbgdc
            //s- a b c 
            //

            List<(char, int)> indexes = [];
            int totalIndexer = 0;
            
            for (int i = 0; i < s.Length; i++)
            {
                if (t.Contains(s[i]))
                {
                    totalIndexer = t.IndexOf(s[i], totalIndexer);
                    indexes.Add((s[i], totalIndexer));
                    totalIndexer++;
                }
                else
                {
                    return false;
                }
            }
            totalIndexer = -1;
            foreach (var index in indexes)
            {
                if (index.Item2 > totalIndexer)
                {
                    totalIndexer = index.Item2;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
