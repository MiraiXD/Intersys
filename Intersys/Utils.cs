using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intersys
{
    public class Utils
    {
        public static int ReadInt(string errorMessage = "It's not a number")
        {
            int i;
            while (!int.TryParse(Console.ReadLine(), out i))
            {
                Console.WriteLine(errorMessage);
            }

            return i;
        }
        public static void Reverse<T>(T[] array)
        {
            var temp = new T[array.Length];
            for (int i = 0; i < array.Length / 2; i++)
            {
                temp[i] = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp[i];
            }
        }
    }
}