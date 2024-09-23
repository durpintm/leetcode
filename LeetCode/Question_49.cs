using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Question_49
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            foreach (string str in strs)
            {
                int[] freq = new int[26];

                foreach (char ch in str.ToCharArray())
                {
                    freq[ch - 'a']++;
                }

                string freqPattern = "";

                foreach (int charFreq in freq)
                {
                    freqPattern += (charFreq + "#");
                }

                if (!dict.ContainsKey(freqPattern))
                {
                    dict[freqPattern] = new List<string>();
                }

                dict[freqPattern].Add(str);
            }

            //    foreach (var kvp in dict)
            //     {
            //         Console.WriteLine($"{kvp.Key}:");

            //         foreach (var item in kvp.Value)
            //         {
            //             Console.WriteLine($" - {item}");
            //         }
            //     }
            return dict.Values.ToList<IList<string>>();
        }
    }
}
