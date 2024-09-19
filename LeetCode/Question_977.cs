using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    // 977. Squares of a Sorted Array
    internal class Question_977
    {
        public static int[] SortedSquares(int[] nums)
        {
            int length = nums.Length;
            int[] result = new int[length];
            int sqLeft, sqRight = 0;
            int index = length - 1;
            for (int i = 0, j = length - 1; i < length && j >= 0;)
            {
                sqLeft = nums[i] * nums[i];
                sqRight = nums[j] * nums[j];

                if (i == j)
                {
                    result[index] = nums[i] * nums[i];
                    break;
                }

                if (sqRight >= sqLeft)
                {
                    result[index] = sqRight;
                    j--;
                }
                else
                {
                    result[index] = sqLeft;
                    i++;
                }
                index--;
            }
            return result;
        }
    }
}
