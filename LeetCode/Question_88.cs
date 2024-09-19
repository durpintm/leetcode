using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    // Merge Sorted Array
    internal class Question_88
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
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
                nums1[index] = nums2[j];
                j--;
                index--;
            }
        }

        public static void Merge2(int[] nums1, int m, int[] nums2, int n)
        {
            int index = nums1.Length - 1;
            int p = m - 1;
            int q = n - 1;

            while(index >= 0)
            {
                if (q < 0) break;

                if(p >= 0 && nums1[p] >= nums2[q])
                {
                    nums1[index--] = nums1[p--];
                }
                else
                {
                    nums1[index--] = nums2[q--];
                }
            }
        }
    }
}
