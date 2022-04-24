global using System;
using Homework1NS;

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
}
