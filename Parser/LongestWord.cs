using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    /// <summary>
    /// Class responsible for finding a longest word.
    /// </summary>
    class LongestWord
    {
        /// <summary>
        /// Method returns longest word inside the collection of strings.
        /// </summary>
        /// <returns> string which has maximum number of characters.</returns>
        public static string FindLongestWord()
        {
            int longest = 0;
            int maxLength = 0;
            string longestWord = String.Empty;
            Dictionary<string, int> map = FileParser.getCollectionOfStrings();

            // Log a message and return if collection is empty.
            if(map.Count <= 0)
            {
                Console.WriteLine("Collection is empty");
                return longestWord;
            }

            foreach(string word in map.Keys)
            {
                longest = word.Length;
                if(longest > maxLength)
                {
                    maxLength = longest;
                    longestWord = word;
                }
            }
            return longestWord;
        }
    }
}
