using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithemHomeWork
{
    public class Recursive
    {
        public Dictionary<int, int> CountFrequencyRecursive(int[] arr, Dictionary<int, int> frequency = null, int index = 0)
        {
            if (frequency == null)
            {
                frequency = new Dictionary<int, int>();
            }

            if (index >= arr.Length)
            {
                return frequency;
            }

            int num = arr[index];
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

            return CountFrequencyRecursive(arr, frequency, index + 1);
        }
    }
}
