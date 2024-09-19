using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    // Two Sum
    internal class Question_1
    {
        public static int[] TwoSum(int[] numbers, int target)
        {

            for (int i = 0, j = numbers.Length - 1; i < numbers.Length && j >= 0;)
            {
                if (numbers[i] + numbers[j] == target)
                {
                    return [i, j];
                }
                else if (numbers[i] + numbers[j] > target)
                {
                    j--;
                }
                else
                {
                    i++;
                }
            }
            return [0, 0];
        }

    }
}
