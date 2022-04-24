using System;

namespace patikadev_csharp101_homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Homework1 homework1 = new Homework1();

            while (true)
            {
                Console.Write("_______Please enter the question number (enter \"0\" to exit) : ");
                string input = Console.ReadLine();
                if (input == "0")
                {
                    break;
                }
                switch (input)
                {
                    case "1":
                        homework1.Question1();
                        break;
                    case "2":
                        homework1.Question2();
                        break;
                    case "3":
                        homework1.Question3();
                        break;
                    case "4":
                        homework1.Question4();
                        break;
                    default:
                        Console.WriteLine("Question does not exist");
                        break;
                }
            }
        }
    }

    class Homework1
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
            Console.Write("Question3");
        }

        public void Question4()
        {
            Console.Write("Question4");
        }


        // -----------------Helper Methods----------------//
        public void Print(string text)
        {
            Console.Write(text);
        }

        public void PrintLine(string text)
        {
            Console.WriteLine(text);
        }

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

    static class ExtensionMethods
    {
        public static void PrintInteger(this int number)
        {
            Console.WriteLine(number);
        }

        public static void PrintIntegerArray(this int[] numbers)
        {
            foreach (int number in numbers)
            {
                number.PrintInteger();
            }
        }
    }
}
