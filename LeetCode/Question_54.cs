using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal static class Question_54
    {
        public static IList<int> SpiralOrder(int[][] matrix)
        {
            int rows = matrix.Length;
            int columns = matrix[0].Length;
            int length = rows * columns;
            int count = 0;
            IList<int> list = new List<int>();
            int left = 0, right = columns - 1, up = 0, down = rows - 1;

            while (count < length)
            {

                // traverse from left to right
                for (int col = left; col <= right; col++)
                {
                    list.Add(matrix[up][col]);
                    count++;
                }

                // traverse from up to down
                for (int row = up + 1; row <= down; row++)
                {
                    list.Add(matrix[row][right]);
                    count++;
                }

                if (up != down)
                {
                    //traverse from right to left
                    for (int col = right - 1; col >= left; col--)
                    {
                        list.Add(matrix[down][col]);
                        count++;
                    }
                }


                if (left != right)
                {
                    // travers from down to up
                    for (int row = down - 1; row > up; row--)
                    {
                        list.Add(matrix[row][left]);
                        count++;
                    }
                }

                left++;
                right--;
                up++;
                down--;
            }

            return list;
        }
    }
}
