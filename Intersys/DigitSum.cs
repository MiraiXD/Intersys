using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intersys
{
    public class DigitSum
    {
        public DigitSum()
        {
            Console.WriteLine("Specify the amount of numbers:");
            uint length = Utils.Read<uint>(uint.Parse);
            Console.WriteLine($"Specify {length} positive numbers:");
            uint[] numbers = Utils.ReadTable<uint>(' ', uint.Parse, (array) =>
            {
                if (array.Length != length)
                {
                    Console.WriteLine("Wrong amount of numbers. Try again");
                    return false;
                }
                else return true;
            });

            var maxSum = numbers
            .Select((number, index) => new DigitSumVal
            {
                number = number,
                index = index,
                digitSum = CalcDigitSum(number)
            })
            .OrderByDescending(n => n, new DigitSumComparer())
            .First();

            Console.WriteLine($"Maximum digit sum number is {maxSum.number} at index {maxSum.index}, with the digit sum {maxSum.digitSum}");
        }
        private class DigitSumComparer : IComparer<DigitSumVal>
        {
            public int Compare(DigitSumVal x, DigitSumVal y)
            {
                if (x.digitSum != y.digitSum) return x.digitSum.CompareTo(y.digitSum);
                else return x.number.CompareTo(y.number);
            }
        }
        private int CalcDigitSum(uint number)
        {
            uint sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return (int)sum;
        }
        private struct DigitSumVal
        {
            public uint number;
            public int index, digitSum;
        }
    }
}