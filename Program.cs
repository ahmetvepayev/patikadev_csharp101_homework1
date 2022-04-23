using System;

namespace patikadev_csharp101_homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Homework1 homework1 = new Homework1();

            while (true){
                Console.Write("Please enter the question number (enter \"0\" to exit) : ");
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
        public void Question1(){
            Console.WriteLine("Question1");
        }

        public void Question2(){
            Console.WriteLine("Question2");
        }

        public void Question3(){
            Console.WriteLine("Question3");
        }

        public void Question4(){
            Console.WriteLine("Question4");
        }

    }
}
