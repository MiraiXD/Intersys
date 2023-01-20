using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intersys
{
    public class PalindromeCheck
    {
        public PalindromeCheck()
        {
            Console.WriteLine("Specify a string o characters:");
            string? input = Console.ReadLine();
            if (input == null) return;

            StringBuilder builder = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsLetter(c)) builder.Append(char.ToLower(c));
            }
            input = builder.ToString();

            Console.Write("Is Palindrome: ");
            if (input.SequenceEqual(input.Reverse()))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}