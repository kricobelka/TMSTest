using System;
// вывести имя фамилия возраст
namespace TMSGIt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name = "";
            string Surname = "";
            int age = 0;
            int height = 0;
            int weight = 0;
            //переменная где присваивается результат:
            int response = 0;
            while (response != -1)
            {
                Console.WriteLine("Enter 0 to enter name" + Environment.NewLine +
                                    "Enter 1 to enter surname" + Environment.NewLine +
                                   "Enter 2 to enter age" + Environment.NewLine +
                                    "Enter -1 to exit" + Environment.NewLine +
                                    "Enter -2 to enter summary" + Environment.NewLine +
                                    "Enter 3 to enter your height" + Environment.NewLine +
                                    "Enter 4 to enter your weight");
                response = int.Parse(Console.ReadLine());
                //with switch-case:
                switch (response)
                {
                    case 0:
                        {
                            Console.WriteLine("Enter your name");
                            Name = Console.ReadLine();
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("Enter your surname");
                            Surname = Console.ReadLine();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter your age");
                            age = int.Parse(Console.ReadLine());
                            break;
                        }
                    case -2:
                        {
                            Console.WriteLine(Name);
                            Console.WriteLine(Surname);
                            Console.WriteLine(age);
                            Console.WriteLine(height);
                            Console.WriteLine(weight);
                            break;
                        }
                    case -1:
                        {
                            Console.WriteLine("Program is cancelled");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter your height");
                            height = int.Parse(Console.ReadLine());
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter your weight");
                            height = int.Parse(Console.ReadLine());
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong number is indicated");
                            break;
                        }

                        // with if:
                        //if (response == 0)
                        //{
                        //    Console.WriteLine("Enter your name");
                        //    Name = Console.ReadLine();
                        //}
                        //if (response == 1)
                        //{
                        //    Console.WriteLine("Enter your surname");
                        //    Surname = Console.ReadLine();
                        //}
                        //if (response == 2)
                        //{
                        //    Console.WriteLine("Enter your age");
                        //    age = int.Parse(Console.ReadLine());
                        //}
                        //if (response == -2)
                        //{
                        //    Console.WriteLine(Name);
                        //    Console.WriteLine(Surname);
                        //    Console.WriteLine(age);
                        //    Console.WriteLine(height);
                        //}
                        Console.ReadKey();
                }
            }
        }
    }
}
