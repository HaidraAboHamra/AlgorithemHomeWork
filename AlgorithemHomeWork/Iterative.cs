using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithemHomeWork
{
    public class Iterative
    {
        public Dictionary<int, int> CountFrequencyIterative(int[] arr)
        {
            Dictionary<int, int> frequency = new Dictionary<int, int>();

            foreach (var num in arr)
            {
                if (num >= 25 && num <= 75)
                {
                    if (frequency.ContainsKey(num))
                    {
                        frequency[num]++;
                    }
                    else
                    {
                        frequency[num] = 1;
                    }
                }
                else
                {
                    Console.WriteLine($"Value {num} is out of range (25-75) and will be ignored.");
                }
            }
            return frequency;
        }

    }
}
