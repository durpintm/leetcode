using LeetCode;

public class Program
{
    public static void Main(string[] args)
    {
        //int[] ans_1 = Question_1.TwoSum([2, 7, 11, 15], 9);

        //int[] ans_977 = Question_977.SortedSquares([-4, -1, 0, 3, 10]);

        //Question_88.Merge2([1, 2, 3, 0, 0, 0], 3, [2, 5, 6], 3);
        //Question_88.Merge2([0], 0, [1], 1);

        //GG_1.Segregate0and1([0, 0, 1, 1, 0]);

        //string s = Question_5.LongestPalindrome("sdfgrrgft");

        //var result = Question_54.SpiralOrder([[1, 2, 3, 4], [5, 6, 7, 8], [9, 10, 11, 12]]);

        //int max = GetFrequency([2, 0, 1, 2, 3, 2, 4, 1, 5, 3, 2]);

        //int maxLength = Question_525.FindMaxLength([0, 1, 0, 0, 0, 1, 1, 0, 1]);

        int maxLen = Question_325.lenOfLongSubarr([10, 5, 2, 7, 1, 9], 6, 15);


        Console.ReadKey();
    }

    public static int GetFrequency(int[] array)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        foreach (int i in array)
        {
            if (dict.ContainsKey(i))
            {
                dict[i] += 1;
            }
            else
            {
                dict[i] = 1;

            }
        }

        return dict.Values.Max();
    }
}