using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASKS
{
    class Program
    {
        static void Main(string[] args)
        {

            // Task 1: Print Stars
            // Task1();

            // Task 2: Multiplication Table
            // Task2();

            // Task 3: Pyramid of Numbers
            // Task3();

            // Task 4: Square of Stars
            // Task4();

            // Task 5: Descending Numbers
            // Task5();

            // Task 6: Sum of Series
            // Task6();

            // Task 7: Even and Odd Numbers
            // Task7();

            // Task 8: Dynamic Triangle
            // Task8();

            // Task 9: Square of Ascending Numbers
            // Task9();

            // Task 10: Numbers Divisible by 3 or 5
            // Task10();

            Console.ReadKey();
        }

        static void Task1()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int g = 0; g <= i; g++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Task2()
        {
            for (int i = 0; i <= 5; i++)
            {
                for (int g = 0; g <= 5; g++)
                {
                    Console.Write("{0,4}", g * i);
                }
                Console.WriteLine();
            }
        }

        static void Task3()
        {
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int space = 1; space <= n - i; space++)
                {
                    Console.Write(" ");
                }
                for (int numUp = 1; numUp <= i; numUp++)
                {
                    Console.Write(numUp);
                }
                for (int numDown = i - 1; numDown >= 1; numDown--)
                {
                    Console.Write(numDown);
                }
                Console.WriteLine();
            }
        }

        static void Task4()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int g = 0; g < 5; g++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Task5()
        {
            int n = 5;
            for (int i = n; i >= 1; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        static void Task6()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine($"The sum of numbers from 1 to {n} is {sum}");
        }

        static void Task7()
        {
            Console.WriteLine("Odd Numbers:");
            for (int i = 1; i <= 20; i += 2)
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine("\nEven Numbers:");
            for (int i = 0; i <= 20; i += 2)
            {
                Console.Write(i + ", ");
            }
        }

        static void Task8()
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                for (int g = 0; g <= i; g++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Task9()
        {
            int n = 4;
            int current = 1;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(current + " ");
                    current++;
                }
                Console.WriteLine();
            }
        }

        static void Task10()
        {
            Console.WriteLine("Numbers divisible by 3 or 5:");
            for (int i = 0; i <= 50; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.Write(i + ", ");
                }
            }
        }
    }
}
