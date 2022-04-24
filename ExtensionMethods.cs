namespace ExtensionMethods
{
    public static class ConsoleExtensionMethods
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