using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Question_5
    {
        public static string LongestPalindrome(string s)
        {
            int strLength = s.Length;
            if (strLength < 2)
            {
                return s;
            }

            int start = 0, maxLength = 1;

            for (int i = 0; i < strLength; i++)
            {
                int oddLength = ExpandAroundCenter(s, i, i);       // Odd length palindromes
                int evenLength = ExpandAroundCenter(s, i, i + 1);  // Even length palindromes

                int currentMax = Math.Max(oddLength, evenLength);

                if (currentMax > maxLength)
                {
                    maxLength = currentMax;
                    start = i - (maxLength - 1) / 2;  // Calculate the new start index
                }
            }

            return s.Substring(start, maxLength);
        }

        private static int ExpandAroundCenter(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }
            // Return the length of the palindrome
            return right - left - 1;
        }
        //public static string LongestPalindrome(string s)
        //{
        //    int len = s.Length;
        //    int maxLen = 0;
        //    string ans = "";
        //    // generate the longest odd length palindromic substring for each i
        //    for (int mid = 0; mid < len; mid++)
        //    {
        //        int i = mid - 1;
        //        int j = mid + 1;
        //        int curLen = 1;
        //        while (i >= 0 && j < len && s.ElementAt(i) == s.ElementAt(j))
        //        {
        //            i--;
        //            j++;
        //            curLen += 2;
        //        }

        //        if (curLen > maxLen)
        //        {
        //            ans = s.Substring(i + 1, curLen);
        //            maxLen = curLen;
        //        }
        //    }

        //    // generate the longest even length palindrome substring for each (i,j) where i, j has to be adjacent
        //    for (int mid = 0; mid < len - 1; mid++)
        //    {
        //        int i = mid;
        //        int j = mid + 1;
        //        int curLen = 0;
        //        while (i >= 0 && j < len && s.ElementAt(i) == s.ElementAt(j))
        //        {
        //            i--;
        //            j++;
        //            curLen += 2;
        //        }
        //        if (curLen > maxLen)
        //        {
        //            ans = s.Substring(i + 1, curLen);
        //            maxLen = curLen;
        //        }
        //    }

        //    return ans;
        //}

        //public static string LongestPalindrome(string s)
        //{
        //    // Generate all the substring
        //    // For each substring, check whether it's a palindrome
        //    // If it's a palidrome, update the answer

        //    int length = s.Length;
        //    string longestPali = "";
        //    for (int i = 0; i < length; i++)
        //    {
        //        string subStr = "";
        //        for (int j = i; j < length; j++)
        //        {
        //            subStr += s.ElementAt(j) + "";
        //            if (isPalidrome(subStr) && subStr.Length > longestPali.Length)
        //            {
        //                longestPali = subStr;
        //            }
        //        }
        //    }
        //    return longestPali;
        //}

        //public static bool isPalidrome(string s)
        //{
        //    int i = 0;
        //    int j = s.Length - 1;

        //    while (i <= j)
        //    {
        //        if (s[i] != s[j])
        //        {
        //            return false;
        //        }
        //        i++;
        //        j--;
        //    }
        //    return true;
        //}
    }
}

