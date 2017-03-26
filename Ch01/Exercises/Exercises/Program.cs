using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Current date/time: " + DateTime.Now);
            Console.WriteLine("The square root of 12345: " + Math.Sqrt(12345));

            for (int i = 2; i < 103; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(-i);
                }
            }

            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("In 10 years you will be " + (age + 10) + " years old.");

            Console.ReadKey();
        }
    }
}
