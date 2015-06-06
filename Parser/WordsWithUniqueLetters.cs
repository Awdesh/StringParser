using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Parser
{
    /// <summary>
    /// Class retrieves all the words containing unique letters.
    /// </summary>
    class WordsWithUniqueLetters
    {
        /// <summary>
        /// Method finds a word with most unique characters.
        /// </summary>
        /// <returns>A string representing a word with most number of unique letters.</returns>
        public static string getWords()
        {
            Dictionary<string, int> map = FileParser.getCollectionOfStrings();
            
            // Log a message and return if collection is empty.
            if (map.Count <= 0)
            {
                Console.WriteLine("Collection is empty");
                return string.Empty;
            }

            bool isDuplicate = false;
            int maxLength = 0;
            string uniqueLetterWord = String.Empty;
            List<char> uniqueWords = new List<char>();

            foreach(string word in map.Keys)
            {
                foreach(char letter in word)
                {
                    isDuplicate = false;

                    if(!uniqueWords.Contains(letter))
                    {
                        uniqueWords.Add(letter);
                    }
                    else
                    {
                        // If letter gets repeated in a word then set flag to true.
                        isDuplicate = true;
                        break;
                    }
                }
                // Sets MaxLength to word length if word contains unique letters.
                if(!isDuplicate)
                {
                    if(word.Length > maxLength)
                    {
                        maxLength = word.Length;
                        uniqueLetterWord = word;
                    }
                }
                uniqueWords.Clear();
            }
            return uniqueLetterWord;
        }
    }
}
