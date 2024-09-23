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
        //public static int[] TwoSum(int[] numbers, int target)
        //{

        //    for (int i = 0, j = numbers.Length - 1; i < numbers.Length && j >= 0;)
        //    {
        //        if (numbers[i] + numbers[j] == target)
        //        {
        //            return [i, j];
        //        }
        //        else if (numbers[i] + numbers[j] > target)
        //        {
        //            j--;
        //        }
        //        else
        //        {
        //            i++;
        //        }
        //    }
        //    return [0, 0];
        //}

        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int x = nums[i];
                int y = target - nums[i];
                if (dict.ContainsKey(y))
                {
                    return new int[] { i, dict[y] };
                }

                if (!dict.ContainsKey(x))
                {
                    dict.Add(x, i);
                }
            }

            return [];
        }

    }
}
