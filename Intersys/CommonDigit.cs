using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intersys
{
    public class CommonDigit
    {
        public CommonDigit()
        {
            Console.WriteLine("Specify the amount of numbers to test (2-20):");
            int length = Utils.Read<int>(int.Parse, (val) =>
            {
                if (val < 2 || val > 20)
                {
                    Console.WriteLine("Specify a number in range (2,20) inclusive");
                    return false;
                }
                else return true;
            });

            Console.WriteLine($"Specify {length} numbers to test:");
            int[] numbers = Utils.ReadTable<int>(' ', int.Parse, (array) =>
            {
                if (array.Length != length)
                {
                    Console.WriteLine($"You specified {array.Length} numbers instead of {length}");
                    return false;
                }
                else return true;
            });
            int[] counters = new int[10];
            foreach (int number in numbers)
            {
                int n = number;
                while (n != 0)
                {
                    int digit = Math.Abs(n % 10);                    
                    counters[digit]++;
                    n /= 10;
                }
            }

            int index = -1, maxCount = 0;
            for (int i = 0; i < counters.Length; i++)
            {
                if ((counters[i] > maxCount) ||
                (counters[i] == maxCount && i > index))
                {
                    index = i;
                    maxCount = counters[i];
                }
            }
            Console.WriteLine($"The most common digit is {index}, appeared {maxCount} times");
        }
    }
}