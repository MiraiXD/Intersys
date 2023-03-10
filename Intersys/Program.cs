using System;
using Intersys;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Reverse Array");
            Console.WriteLine("2. Palindrome Check");
            Console.WriteLine("3. Permutation Check");
            Console.WriteLine("4. Existing Powers Of Two");
            Console.WriteLine("5. Finding Primes");
            Console.WriteLine("6. Common Digit");
            Console.WriteLine("7. Digit Sum");
            Console.WriteLine("9. Exit");
            Console.WriteLine("Choose operation:");
            int operationID = Utils.Read<int>(int.Parse);
            if (operationID == 1) new ReverseArray();
            else if (operationID == 2) new PalindromeCheck();
            else if (operationID == 3) new PermutationCheck();
            else if(operationID == 4) new ExistingPowersOfTwo();
            else if(operationID == 5) new FindingPrimes();
            else if(operationID == 6) new CommonDigit();
            else if(operationID == 7) new DigitSum();
            else if (operationID == 9) break;

            Console.WriteLine();
            Console.WriteLine();
        }
    }

}
