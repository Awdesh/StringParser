using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    /// <summary>
    /// Class responsible for finding word which uses any english alphabet letter maximum number of time.
    /// </summary>
    class WordsWithMostUseOfLetter
    {
        /// <summary>
        /// Method retrieves word with maximum frequency of a letter from collection.
        /// </summary>
        /// <returns></returns>
        public static string FindWord()
        {
            int maxFrequency = 0;
            string maxFrequencyWord = String.Empty;
            Dictionary<string, int> map = FileParser.getCollectionOfStrings();
            Dictionary<char, int> frequencyMap = new Dictionary<char, int>();

            // Log a message and return if collection is empty.
            if(map.Count <= 0)
            {
                Console.WriteLine("Collection is empty");
                return maxFrequencyWord;
            }

            foreach (string word in map.Keys)
            {
                foreach(char letter in word)
                {
                    if (!frequencyMap.ContainsKey(letter))
                        frequencyMap.Add(letter, 1);
                    else
                        // Increase value of a character's frequency if it already exists inside the map.
                        frequencyMap[letter]++;
                }

                // Gets maximum value (frequency) from dictionary.
                int max = frequencyMap.Values.Max();
                if(max > maxFrequency)
                {
                    maxFrequency = max;
                    maxFrequencyWord = word;
                }
                // Clear dictionary after storing character's frequency of a word.
                frequencyMap.Clear();
            }
            return maxFrequencyWord;
        }
    }
}
