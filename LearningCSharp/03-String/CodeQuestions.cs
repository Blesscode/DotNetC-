using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_String
{
    internal class CodeQuestions
    {
        public bool CheckPallinDrome(String s)
        {
            int start = 0;
            int end = s.Length - 1;
            while (start < end)
            {
                if (s[start] != s[end])
                {
                    return false;
                }
                start++;
                end--;
            }
            return true;
        }

        public int findCountOfAChar(String s)
        {
            int count = 0;
            foreach (char c in s)
            {
                count++;
            }
            return count;
        }
    }
}
