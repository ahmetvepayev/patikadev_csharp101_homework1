using System;

namespace patikadev_csharp101_homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Homework1 homework1 = new Homework1();

            while (true){
                Console.Write("_______Please enter the question number (enter \"0\" to exit) : ");
                string input = Console.ReadLine();
                if (input == "0"){
                    break;
                }
                switch (input){
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
        public int ReadInteger(){
            return int.Parse(Console.ReadLine());
        }

        public int[] ReadInteger(int n){
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++){
                numbers[i] = ReadInteger();
            }
            return numbers;
        }

        public void Question1(){
            Console.Write("Enter a positive integer: ");

            int n = ReadInteger();
            int[] numbers = new int[n];

            Console.WriteLine($"Enter {n} positive integers. Press Enter after each integer: ");
            numbers = ReadInteger(n);

            Console.WriteLine("Even integers:");
            foreach (int number in numbers){
                if (number%2 == 0){
                    number.PrintInteger();
                }
            }
        }

        public void Question2(){
            Console.Write("Question2");
        }

        public void Question3(){
            Console.Write("Question3");
        }

        public void Question4(){
            Console.Write("Question4");
        }

    }

    static class ExtensionMethods
    {
        public static void PrintInteger(this int number){
            Console.WriteLine(number);
        }

        public static void PrintIntegerArray(this int[] numbers){
            foreach (int number in numbers){
                number.PrintInteger();
            }
        }
    }
}
