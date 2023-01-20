using System;
using Intersys;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Reverse Array");
            Console.WriteLine("9. Exit");
            Console.WriteLine("Choose operation:");
            int operationID = Utils.ReadInt();
            if (operationID == 1) new ReverseArray();
            else if (operationID == 9) break;
        }
    }

}
