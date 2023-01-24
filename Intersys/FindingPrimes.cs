using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intersys
{
    public class FindingPrimes
    {
        private struct PrimesTestCase
        {
            public int lowerBound, upperBound, N_Primes;
        }
        public FindingPrimes()
        {
            Console.WriteLine("Specify number of test cases:");
            int N_TestCases = Utils.Read<int>(int.Parse);
            PrimesTestCase[] testCases = new PrimesTestCase[N_TestCases];
            for (int i = 0; i < N_TestCases; i++)
            {
                Console.WriteLine($"Test case {i + 1}/{N_TestCases}:");
                Console.WriteLine("Specify lower and upper bounds, separated by a space and press enter");
                int[] bounds = Utils.ReadTable<int>(' ', int.Parse, (array) =>
                {
                    if (array.Length != 2)
                    {
                        Console.WriteLine("Specify 2 numbers");
                        return false;
                    }
                    else return true;
                });
                testCases[i] = new PrimesTestCase
                {
                    lowerBound = Math.Min(bounds[0], bounds[1]),
                    upperBound = Math.Max(bounds[0], bounds[1])
                };
            }
            Parallel.For(0, testCases.Length, (int i) =>
            {
                testCases[i].N_Primes = CountPrimes(testCases[i].lowerBound, testCases[i].upperBound);
            });

            foreach (var t in testCases)
            {
                Console.WriteLine($"Test case lowerbound: {t.lowerBound}, upperbound: {t.upperBound}: {t.N_Primes} prime numbers");
            }
        }
        public static int CountPrimes(int m, int n)
        {
            bool[] primes = Enumerable.Repeat(true, n - m + 1).ToArray();
            primes[0] = false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                for (int j = Math.Max(i * i, (m + i - 1) / i * i); j <= n; j += i)
                {
                    primes[j - m] = false;
                }
            }
            return primes.Count(x => x);
        }
    }
}