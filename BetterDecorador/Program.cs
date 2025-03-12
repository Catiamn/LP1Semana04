using System;

namespace BetterDecorador
{
    public class Program
    {
        /// <summary>
        /// Defines what each of the components the user gives are
        /// Organizes them with the 
        /// </summary>
        /// <param name="args">The args on the method Decor()</param>
        private static void Main(string[] args)
        {
            Console.WriteLine(Decor(args[0], char.Parse(args[1]), int.Parse(args[2])));
        }
        /// <summary>
        /// Creates a string that keeps adding the character given to the string, so it can later print
        /// the correct number of times
        /// </summary>
        /// <param name="phrase">The phrase given first</param>
        /// <param name="symbol">The symbol given in second place</param>
        /// <param name="numbers">Finally the last thing given, the number of time
        // the symbol will appear </param>
        /// <returns>The print at the end </returns>
        private static string Decor (string phrase, char symbol, int numbers)
        {
            string realsymbol = " ";
            for (int i = 0; i < numbers; i++)
            {
                realsymbol += symbol;
            }
            ///Print at the end
            ///Prints the Phrase given and the character x number of times
            /// x is given by the user
            return $"{realsymbol} {phrase} {realsymbol}";
        }
    }
}
