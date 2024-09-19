using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    // Segregate 0s and 1s
    // https://www.geeksforgeeks.org/problems/segregate-0s-and-1s5106/1
    internal class GG_1
    {
        public static void Segregate0and1(int[] arr)
        {
            int l = 0;
            int r = arr.Length - 1;
            while (l < r)
            {
                while (arr[l] == 0 && l < r)
                {
                    l++;
                }

                while (arr[r] == 1 && l < r)
                {
                    r--;
                }

                if (l < r)
                {
                    int temp = arr[l];
                    arr[l] = arr[r];
                    arr[r] = temp;
                    l++;
                    r--;
                }
            }
        }
    }
}
