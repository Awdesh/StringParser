using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Parser
{
    /// <summary>
    /// Helper Class which Setup necessary methods for Parser.
    /// </summary>
    class FileParser
    {
        // Dictionary is been used here to store all strings from different files.
        // Dictionary has a faster lookup of O(1) when data is large.
        private static Dictionary<string, int> map;

        /// <summary>
        /// No parametrized constrcutor.
        /// </summary>
        public FileParser()
        {
            map = new Dictionary<string, int>();
            Initializer();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string,int> getCollectionOfStrings()
        {
            ParseFiles();
            return map;
        }

        /// <summary>
        /// Method prompts different action on the conole screen to user.
        /// </summary>
        private static void Initializer()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("*********************************************************\n");
            Console.WriteLine("Press Keys from 1-7 to perform operation you want-: ");
            Console.WriteLine("*********************************************************\n");

            Console.WriteLine(" Press 1 -: To find Total Number of Words.");
            Console.WriteLine(" Press 2 -: To find First Words Alphabetically.");
            Console.WriteLine(" Press 3 -: To find Longest Words.");
            Console.WriteLine(" Press 4 -: Count of N-Letters words.");
            Console.WriteLine(" Press 5 -: To find a word with the most unique letters.");
            Console.WriteLine(" Press 6 -: To find a word with the most repeated use of single letter.");
            Console.WriteLine(" Press 7 -: To find a Random Word Word with the most unique letters.");
        }

        /// <summary>
        /// Method calls respective operation class based on user's selected option.
        /// </summary>
        /// <param name="index"> An integer which represents user's selected Option</param>
        public void Operation(int index)
        {
            try
            {
                switch (index)
                {
                    case 1:
                        Console.WriteLine("\nTotal words inside Directory are-: {0}", CountWords.TotalWords());
                        break;

                    case 2:
                        Console.WriteLine("\n First word Alphabetically is-: {0}", FirstWordAlphabetically.FindWord());
                        break;

                    case 3:
                        Console.WriteLine("\n longest word is -: {0} with length -: {1}", LongestWord.FindLongestWord(), LongestWord.FindLongestWord().Length);
                        break;

                    case 4:
                         Dictionary<int,int> d = NumberOfWords.FindWord();
                         foreach(KeyValuePair<int,int> pair in d)
                         {
                            Console.WriteLine("\n There are -: {1} words of length -: {0}", pair.Key, pair.Value);
                         }
                        break;

                    case 5:
                        Console.WriteLine("Word with most uniqure characters is -: {0}", WordsWithUniqueLetters.getWords());
                        break;

                    case 6:
                        Console.WriteLine("Word with most use of a single letter is -: {0}", WordsWithMostUseOfLetter.FindWord());
                        break;

                    case 7:
                        Console.WriteLine("\nNew Random word from the list is -: {0}", RandomWord.GetRandomWord());
                        break;

                    default:
                        Console.WriteLine("None of the option Selected");
                        break;
                }
            }
           catch(Exception ex)
            {
                Console.WriteLine("Error occurred while processing request.", ex);
            }
        }

        /// <summary>
        /// Parse all the files inside a given directory and store file's data inside a dictionary.
        /// </summary>
        public static void ParseFiles()
        {
            string path = "../../../words";
            foreach (string file in Directory.EnumerateFiles(path, "*.txt"))
            {
                var contents = File.ReadAllLines(file);

                foreach (var line in contents)
                {
                    // Checks if map exists and doesn't already contain string, This will onlu allow to add non-plural strings.
                    if (map != null && !map.ContainsKey(line.Trim()))
                    {
                        map.Add(line, 1);
                    }
                }
            }
        }
    }
}
