using ExtensionMethods;

namespace HelperMethods
{
    public static class ConsoleHelperMethods
    {
        
        // -----------------Helper Methods----------------//
        public static void PrintDivisible(int[] numbers, int factor)
        {
            foreach (int number in numbers)
            {
                if (number%factor == 0)
                {
                    number.PrintInteger();
                }
            }
        }

        public static void Print(string text)
        {
            Console.Write(text);
        }

        public static void Print(object printable)
        {
            Console.WriteLine(printable.ToString());
        }

        public static void PrintLine(string text)
        {
            Console.WriteLine(text);
        }

        public static void PrintLine(object printable)
        {
            Console.WriteLine(printable.ToString());
        }

        public static void PrintReverseArray(object[] array)
        {
            for (int i = array.Length-1; i >= 0; i--)
            {
                PrintLine(array[i]);
            }
        }

        public static void PrintWordCount(string text)
        {
            PrintLine(text.Split(' ').Length);
        }

        public static void PrintSymbolCount(string text)
        {
            PrintLine(text.Replace(" ", "").Length);
        }

        public static string ReadValue()
        {
            return Console.ReadLine();
        }

        public static T ReadValue<T>() where T: struct, IConvertible
        {
            return (T) Convert.ChangeType(Console.ReadLine(), typeof(T));
        }

        public static string[] ReadValues(int n)
        {
            string[] words = new string[n];
            for (int i = 0; i < n; i++)
            {
                words[i] = Console.ReadLine();
            }
            return words;
        }

        public static T[] ReadValues<T>(int n) where T: struct, IConvertible
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