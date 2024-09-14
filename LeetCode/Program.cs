public class Program
{
    public static void Main(string[] args)
    {
        //int[] result = TwoSum([2, 7, 11, 15], 9);
        //int[] result = SortedSquares([-4, -1, 0, 3, 10]);
        int[] result = SortedSquares([1]);
        Console.WriteLine();
        Console.ReadKey();
    }

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

    // 977. Squares of a Sorted Array
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