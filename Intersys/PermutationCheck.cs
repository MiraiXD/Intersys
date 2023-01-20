using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intersys
{
    public class PermutationCheck
    {
        public PermutationCheck()
        {
            Console.WriteLine("Specify first table of integers separated by a space and press enter");
            int[] t1 = Utils.ReadIntTable(' ');
            Console.WriteLine("Specify second table of integers separated by a space and press enter");
            int[] t2 = Utils.ReadIntTable(' ');

            Array.Sort(t1);
            Array.Sort(t2);
            Console.Write("Is the first table a permutation of the second table?: ");
            if (t1.SequenceEqual(t2))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}