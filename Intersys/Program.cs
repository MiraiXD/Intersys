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
            Console.WriteLine("9. Exit");
            Console.WriteLine("Choose operation:");
            int operationID = Utils.ReadInt();
            if (operationID == 1) new ReverseArray();
            else if (operationID == 2) new PalindromeCheck();
            else if (operationID == 9) break;

            Console.WriteLine();
            Console.WriteLine();
        }
    }

}
