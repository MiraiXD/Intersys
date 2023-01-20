using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intersys
{
    public class ReverseArray
    {
        public ReverseArray()
        {
            Console.WriteLine("Specify size of the array and press enter:");
            int length = Utils.ReadInt();
            int[] input = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Specify element {i}/{length} of the array and press enter:");
                input[i] = Utils.ReadInt();
            }

            // Reverse the input array
            Console.WriteLine("Reverted array:");
            Utils.Reverse(input);

            // Print the reversed array
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(input[i] + " ");
            }
        }
    }
}