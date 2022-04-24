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


        // -----------------Helper Methods----------------//
        public void PrintDivisible(int[] numbers, int factor)
        {
            foreach (int number in numbers)
            {
                if (number%factor == 0)
                {
                    number.PrintInteger();
                }
            }
        }

        public void Print(string text)
        {
            Console.Write(text);
        }

        public void Print(object printable)
        {
            Console.WriteLine(printable.ToString());
        }

        public void PrintLine(string text)
        {
            Console.WriteLine(text);
        }

        public void PrintLine(object printable)
        {
            Console.WriteLine(printable.ToString());
        }

        public void PrintReverseArray(object[] array)
        {
            for (int i = array.Length-1; i >= 0; i--)
            {
                PrintLine(array[i]);
            }
        }

        public void PrintWordCount(string text)
        {
            PrintLine(text.Split(' ').Length);
        }

        public void PrintSymbolCount(string text)
        {
            PrintLine(text.Replace(" ", "").Length);
        }

        public string ReadValue()
        {
            return Console.ReadLine();
        }

        public T ReadValue<T>() where T: struct, IConvertible
        {
            return (T) Convert.ChangeType(Console.ReadLine(), typeof(T));
        }

        public string[] ReadValues(int n)
        {
            string[] words = new string[n];
            for (int i = 0; i < n; i++)
            {
                words[i] = Console.ReadLine();
            }
            return words;
        }

        public T[] ReadValues<T>(int n) where T: struct, IConvertible
        {
            T[] values = new T[n];
            for (int i = 0; i < n; i++)
            {
                values[i] = ReadValue<T>();
            }
            return values;
        }
    }
}