using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Question_525
    {
        public static int FindMaxLength(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int maxLength = 0;
            int sum = 0;

            dict.Add(0, -1);

            for (int i = 0; i < nums.Length; i++)
            {

                if (nums[i] == 0)
                {
                    sum++;
                }
                else
                {
                    sum--;
                }

                if (dict.ContainsKey(sum))
                {
                    maxLength = Math.Max(maxLength, i - dict[sum]);
                }
                else
                {
                    dict.Add(sum, i);
                }
            }
            return maxLength;
        }
    }
}
