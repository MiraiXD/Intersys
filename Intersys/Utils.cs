using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            int[] numbers = null;
            while (!success)
            {
                string? input = Console.ReadLine();
                if (input == null) { success = false; continue; }

                string[] numberStrings = input.Split(separator);
                numbers = new int[numberStrings.Length];

                int i = 0;
                foreach (string s in numberStrings)
                {
                    success = int.TryParse(s, out numbers[i++]);
                    if (!success)
                    {
                        Console.WriteLine(errorMessage);
                        break;
                    }
                }
            }
            return numbers;
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