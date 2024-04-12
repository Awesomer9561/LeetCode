using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.    
    /// </summary>
    public class ValidParentheses
    {
        private static char[] openingBraces = { '(', '{', '[' };
        private static char[] closingBraces = { ')', '}', ']' };
        public bool Calculate(string s)
        {
            List<char> withoutPair = new List<char>();
            // [{()}](){}[]
            for (int i = 0; i < s.Length; i++)
            {
                // If is an opening
                if (openingBraces.Contains(s[i]))
                {
                    withoutPair.Add(s[i]);
                }
                else if (closingBraces.Contains(s[i]) && withoutPair.Count > 0)
                {
                    // if not an opening then it is a closing
                    // find the closing brace's opening pair

                    var lastOpening = withoutPair.Last();
                    if (IsMatch(lastOpening, s[i]))
                    {
                        // If matches then remove the opening from withoutpair
                        withoutPair.RemoveAt(withoutPair.LastIndexOf(lastOpening));
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return withoutPair.Count == 0;
        }

        private static bool IsMatch(char openingBrace, char closingBrace)
        {
            if (openingBrace == openingBraces[0] && closingBrace == closingBraces[0]) return true;
            if (openingBrace == openingBraces[1] && closingBrace == closingBraces[1]) return true;
            if (openingBrace == openingBraces[2] && closingBrace == closingBraces[2]) return true;

            return false;
        }
    }
}
