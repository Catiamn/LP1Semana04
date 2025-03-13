using System;

namespace Special
{
    public class Program
    {
        /// <summary>
        /// Ask the user for a number that will later be used
        /// </summary>
        /// <param name="args">Only one argument is needed</param>
        private static void Main(string[] args)
        {
            Console.Write("Insert n-th number of the special sequence:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(GetSpecial(n));
            
        }
        /// <summary>
        /// Where the number first given is gonna run, giving an output following a certain equation
        /// </summary>
        /// <param name="n">N is the number the user gave</param>
        /// <returns>The return gives us the final number after all the transformations</returns>
        private static int GetSpecial( int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return GetSpecial(n - 1) + 2 * GetSpecial(n - 2);
        }
    }
}
