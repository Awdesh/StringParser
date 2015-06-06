using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Parser
{
    /// <summary>
    /// Client Class responsible to send appropriate operation.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main class which will invoke all necessary methods.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            for(int i = 0; i < 7; i++)
            {
                FileParser fp = new FileParser();
                Console.WriteLine("\n***********************************************************************\n");
         
                string input = Console.ReadLine();
                int value;
                if (int.TryParse(input, out value))
                {
                    fp.Operation(value);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n Invalid input-: Please enter number between 1-7");
                    Console.Beep();
                }
            }
            // Keep the Console Window open to see the output.
            Console.ReadKey();
        }
    }
}
