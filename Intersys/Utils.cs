using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;
namespace Intersys
{
    public class Utils
    {
        public static int ReadInt(string errorMessage = "Wrong input format")
        {
            int i;
            while (!int.TryParse(Console.ReadLine(), out i))
            {
                Console.WriteLine(errorMessage);
            }

            return i;
        }
        public static int[] ReadIntTable(char separator, string errorMessage = "Wrong input format")
        {
            bool success = false;
            while (!success)
            {
                try
                {
                    return Console.ReadLine()
                    .Split(separator)
                    .Select(s => int.Parse(s))
                    .ToArray();
                }
                catch (FormatException e)
                {
                    Console.WriteLine(errorMessage);
                    success = false;
                    continue;
                }
            }
            return null;          
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