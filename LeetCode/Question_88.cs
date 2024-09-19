using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Question_88
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] combinedArray = new int[m + n];
            int index = m + n - 1;
            int i, j;
            for (i = m - 1, j = n - 1; i >= 0 && j >= 0;)
            {
                if (nums1[i] >= nums2[j])
                {
                    nums1[index] = nums1[i];
                    i--;
                }
                else
                {
                    nums1[index] = nums2[j];
                    j--;
                }
                index--;
            }

            while (i >= 0)
            {
                nums1[index] = nums1[i];
                i--;
                index--;
            }

            while (j >= 0)
            {
                combinedArray[index] = nums2[j];
                j--;
                index--;
            }
        }
    }
}
