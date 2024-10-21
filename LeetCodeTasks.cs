using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLearnSharp
{
    internal class LeetCodeTasks
    {

        public bool IsValid(string s)
        {
            var count = 0;
            foreach (var c in s)
            {
                if (c == '(')
                    count++;

                if (c == ')')
                {
                    if (count == 0) return false;
                    count--;
                }
            }
            return count == 0;
        }

        
            public int LongestValidParentheses(string s)
            {
                int count = 0;
                int maxCount = 0;
                int[] sums = new int[s.Length];
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == '(')
                        count++;
                    if (s[i] == ')')
                    {
                        if (count > 0)
                        {
                            count--;
                            sums[i] = sums[i - 1] + 2;
                            if (sums[i] < i)
                            {
                                sums[i] += sums[i - sums[i]];
                            }
                        }
                    }
                    maxCount = Math.Max(maxCount, sums[i]);
                }

                return maxCount;
            }

            
        }
    }

