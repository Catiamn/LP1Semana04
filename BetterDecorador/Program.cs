using System;

namespace BetterDecorador
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Decor(args[0], char.Parse(args[1]), int.Parse(args[2])));
        }

        private static string Decor (string phrase, char symbol, int numbers)
        {
            string realsymbol = " ";
            for (int i = 0; i < numbers; i++)
            {
                realsymbol += symbol;
            }
            return $"{realsymbol} {phrase} {realsymbol}";
        }
    }
}
