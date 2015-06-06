using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    /// <summary>
    /// Class responsible to count how many N-letters word exists.
    /// </summary>
    class NumberOfWords
    {
        /// <summary>
        /// Method calculates number of words with their respective letters count.
        /// </summary>
        /// <returns></returns>
        public static Dictionary<int,int> FindWord()
        {
            Dictionary<string, int> map = FileParser.getCollectionOfStrings();
            Dictionary<int, int> countMap = new Dictionary<int, int>();
            // Log a message and return if collection is empty.
            if (map.Count <= 0)
            {
                Console.WriteLine("Collection is empty");
                return countMap;
            }
            foreach(string word in map.Keys)
            {
                if(!countMap.ContainsKey(word.Length))
                {
                    countMap.Add(word.Length, 1);
                }
                else
                {
                    // If any length of characters already exists inside map then increase the word count for that length.
                    countMap[word.Length]++;
                }
            }
            return countMap;
        }
    }
}
