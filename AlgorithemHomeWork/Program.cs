using System;
using System.Collections.Generic;



namespace AlgorithemHomeWork;
class Program
{
    static void Main(string[] args)
    {
        Iterative counter = new Iterative();
        Recursive counter1 = new Recursive();


        while (true)
        {
            Console.WriteLine("Choose execution method (type 'exit' to quit):");
            Console.WriteLine("1. Iterative method");
            Console.WriteLine("2. Recursive method");

            string choice = Console.ReadLine();

            if (choice.ToLower() == "exit")
            {
                break;
            }

            if (choice != "1" && choice != "2")
            {
                Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                continue;
            }

            Console.WriteLine("Enter numbers separated by spaces:");
            string input = Console.ReadLine();
            string[] inputArr = input.Split(' ');

            int[] arr;
            try
            {
                arr = Array.ConvertAll(inputArr, int.Parse);
            }
            catch (FormatException)
            {
                Console.WriteLine("An error occurred in number input. Please ensure you enter valid integers.");
                continue;
            }

            Dictionary<int, int> result;

            if (choice == "1")
            {
                result = counter.CountFrequencyIterative(arr);
            }
            else
            {
                result = counter1.CountFrequencyRecursive(arr);
            }

            Console.WriteLine("Value frequencies:");
            foreach (var pair in result)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
