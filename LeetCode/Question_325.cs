using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal static class Question_325
    {
        // https://www.geeksforgeeks.org/problems/longest-sub-array-with-sum-k0809/1?itm_source=geeksforgeeks&itm_medium=article&itm_campaign=practice_card
        public static int lenOfLongSubarr(int[] A, int N, int K)
        {
            //int[] prefixSum = new int[N];
            int sum = 0;

            Dictionary<int, int> dict = new Dictionary<int, int>();
            int maxLen = 0;
            dict[0] = -1;

            for (int i = 0; i < N; i++)
            {
                //if (i == 0)
                //{
                //    prefixSum[i] = A[i];
                //}
                //else
                //{
                //    prefixSum[i] = A[i] + prefixSum[i - 1];
                //}

                sum += A[i];

                int valueNeedToSubtract = sum - K;
                if (dict.ContainsKey(valueNeedToSubtract))
                {
                    maxLen = Math.Max(i - dict[valueNeedToSubtract], maxLen);
                }

                if (!dict.ContainsKey(sum))
                {
                    dict[sum] = i;
                }
            }
            return maxLen;
        }
    }
}
