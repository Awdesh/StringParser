using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser
{
    /// <summary>
    /// Class responsible to return first word alphabetically.
    /// </summary>
    class FirstWordAlphabetically
    {
        /// <summary>
        /// Method returns first word alphabetically.
        /// </summary>
        /// <returns>string : First alphabetically sorted word. </returns>
        public static string FindWord()
        {
            Dictionary<string, int> map = FileParser.getCollectionOfStrings();

            // Log a message and return if collection is empty.
            if (map.Count <= 0)
            {
                Console.WriteLine("Collection is empty");
                return string.Empty;
            }

            List<string> list = map.Keys.ToList();
            list.Sort();
            return list.ElementAt(1);
        }
    }
}
