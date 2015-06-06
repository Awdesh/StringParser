using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    /// <summary>
    /// Class responsible for retrieving a random word from collection of strings.
    /// </summary>
    class RandomWord
    {
        /// <summary>
        /// Method retrieves a random word from collection of strings.
        /// </summary>
        /// <returns>string : random word.</returns>
        public static string GetRandomWord()
        {
            // Random class retrieves random word from collection everytime.
            System.Random random = new Random();

            Dictionary<string, int> map = FileParser.getCollectionOfStrings();
            return map.ElementAt(random.Next(map.Count())).Key;
        }
    }
}
