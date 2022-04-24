using HelperMethods;
using static HelperMethods.ConsoleHelperMethods;
using ExtensionMethods;

namespace Homework1NS
{
    public class Homework1
    {
        public void Question1()
        {
            Print("Enter a positive integer: ");
            int n = ReadValue<int>();
            int[] numbers = new int[n];

            PrintLine($"Enter {n} positive integers. Press Enter after each integer: ");
            numbers = ReadValues<int>(n);

            PrintLine("Even integers:");
            PrintDivisible(numbers, 2);
        }

        public void Question2()
        {
            PrintLine("Enter two positive integers. Press Enter after each integer:");
            int n = ReadValue<int>();
            int m = ReadValue<int>();
            int[] numbers = new int[n];

            PrintLine($"Enter {n} positive integers. Press Enter after each integer: ");
            numbers = ReadValues<int>(n);

            PrintLine($"Integers divisible by {m}:");
            PrintDivisible(numbers, m);
        }

        public void Question3()
        {
            Print("Enter a positive integer: ");
            int n = ReadValue<int>();
            string[] words = new string[n];

            PrintLine($"Enter {n} words. Press Enter after each word:");
            words = ReadValues(n);

            PrintLine("Reverse:");
            PrintReverseArray(words);
        }

        public void Question4()
        {
            PrintLine("Type a sentece and press Enter:");
            string input = ReadValue();

            PrintLine("Word count:");
            PrintWordCount(input);

            PrintLine("Symbol count without whitespaces");
            PrintSymbolCount(input);
        }
    }
}