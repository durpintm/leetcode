using LeetCode;

public class Program
{
    public static void Main(string[] args)
    {
        int[] ans_1 = Question_1.TwoSum([2, 7, 11, 15], 9);
        int[] ans_977 = Question_977.SortedSquares([-4, -1, 0, 3, 10]);
        Question_88 question_88 = new Question_88();
        Question_88.Merge([1, 2, 3, 0, 0, 0], 3, [2, 5, 6], 3);
        Question_88.Merge([0], 0, [1], 1);
        Console.WriteLine();
        Console.ReadKey();
    }
}