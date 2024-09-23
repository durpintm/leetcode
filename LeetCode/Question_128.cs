using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal static class Question_128
    {
        public static int LongestConsecutive(int[] nums)
        {
            HashSet<int> hs = new HashSet<int>();
            hs.UnionWith(nums);
            int length = nums.Length;
            int maxLength = 0;

            foreach (int elem in hs)
            {
                if (!hs.Contains(elem - 1))
                {
                    int len = 1;
                    while (hs.Contains(elem + len))
                    {
                        len++;
                    }
                    maxLength = Math.Max(maxLength, len);
                }
            }

            return maxLength;
        }
    }
}
