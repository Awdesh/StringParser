using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    /// <summary>
    /// Class counts total number of words inside the text files in a directory.
    /// </summary>
    class CountWords
    {
        /// <summary>
        /// Method counts total number of words.
        /// </summary>
        /// <returns>integer representing total numbe rof words in list of words.</returns>
        public static int TotalWords()
        {
            return FileParser.getCollectionOfStrings().Count;
        }
    }
}
