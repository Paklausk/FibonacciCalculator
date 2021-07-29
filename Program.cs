using FibonacciCalculator.Objects;
using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace FibonacciCalculator
{
    class Program
    {
        static bool firstNumberOutputted = false;
        static void Main(string[] args)
        {
            WriteColorText("Please enter amount of finobacci numbers: ", ConsoleColor.Green);
            string possibleNumberOfIterations = Console.ReadLine();
            int totalAmountOfNumbers;
            if (!int.TryParse(possibleNumberOfIterations, out totalAmountOfNumbers))
            {
                WriteColorText("Provided number '", ConsoleColor.Green);
                WriteColorText(possibleNumberOfIterations, ConsoleColor.Red);
                WriteColorText("' is invalid", ConsoleColor.Green);
            }
            else
            {
                FibonacciNumbersList fibonacciList = new FibonacciNumbersList(0, 1);
                OutputNumber(fibonacciList.Current);
                for (long i = 0; i < totalAmountOfNumbers - 1; i++)
                    OutputNumber(fibonacciList.Next);
            }
            Console.ReadKey(true);
        }
        static void WriteColorTextLine(string text, ConsoleColor color)
        {
            WriteColorText(text + Environment.NewLine, color);
        }
        static void WriteColorText(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }
        static void OutputNumber(BigInteger number)
        {
            if (firstNumberOutputted)
                WriteColorText(", ", ConsoleColor.White);
            else firstNumberOutputted = true;
            WriteColorText(number.ToString(), ConsoleColor.Magenta);
        }
    }
}
