/* 
 * A method that reverses a string (e.g. "Hello" gives "olleH")
 * Deadline: 2012-01-02
 * Programmer: Baran Topal 
 * Solution name: Reverse 
 * Project name: Reverse
 * File name: Program.cs
 * Status: Finished
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reverse
{
    /// <summary>
    /// A method that reverses a string (e.g. "Hello" gives "olleH")
    /// </summary>
    class Program
    {
        #region methods

        /// <summary>
        /// Main gate, reversing the hard coded inputs
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string[] inputs = { "\"ey edip adanada pide ye\"", "\"baran\"", "\"Hello\"" };

            //Looping through the string array
            foreach (string input in inputs)
            {
                Console.Write("Reverse of the given string; ");
                Console.Write(input);

                //converting the string into char array
                char[] forwards = input.ToCharArray();

                //Another way;
                //Array.Reverse(forwards);

                StringBuilder reverse = new StringBuilder(input.Length);

                for (int i = input.Length - 1; i >= 0; i--)
                    reverse.Append(forwards[i]);

                Console.WriteLine(" is " + reverse + ".");
            }
        }

        #endregion methods
    }
}
