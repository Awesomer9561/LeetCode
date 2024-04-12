using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// Given a string s, find the length of the longest substring without repeating characters.
    /// </summary>
    public class LongestSubstring
    {
        public static int Calculate(string s)
        {
            int length = 0;
            var chars = s.ToCharArray();
            List<char> substring = new();

            // aabaab!bb
            // ba
            for (int i = 0; i < chars.Length; i++)
            {
                if (substring.Contains(chars[i]))
                {
                    var index = substring.IndexOf(chars[i]);
                    substring.RemoveRange(0, index + 1);
                }
                substring.Add(chars[i]);

                length = length > substring.Count ? length : substring.Count;
            }

            return length;
        }
    }
}
