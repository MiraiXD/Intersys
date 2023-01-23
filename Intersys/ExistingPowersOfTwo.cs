using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intersys
{
    public class ExistingPowersOfTwo
    {
        public ExistingPowersOfTwo()
        {
            Console.WriteLine("Keep adding unsigned numbers pressing enter after each one. When you're done press enter on an empty line");            
            List<uint> numbers = new List<uint>();
            bool hasInput;
            do
            {
                string input = Console.ReadLine();
                hasInput = input != string.Empty && !string.IsNullOrWhiteSpace(input);
                if (hasInput)
                {
                    if (uint.TryParse(input, out uint n))
                        numbers.Add(n);
                    else
                        Console.WriteLine("Wrong input format");
                }
            } while (hasInput);

            if (!Utils.TryFindMaxPowerOfTwo(numbers, out uint max))
            {
                Console.WriteLine("NA");
                return;
            }

            uint p = 1;
            List<uint> powers = new List<uint>();
            while(p <= max)
            {
                powers.Add(p);
                p *= 2;
            }

            Console.WriteLine("Existing powers of two:");
            Console.WriteLine(string.Join(',', powers));
        }
    }
}