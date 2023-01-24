using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;
namespace Intersys
{
    public class Utils
    {
        // public static int ReadInt(string errorMessage = "Wrong input format")
        // {
        //     int i;
        //     while (!int.TryParse(Console.ReadLine(), out i))
        //     {
        //         Console.WriteLine(errorMessage);
        //     }

        //     return i;
        // }
        public static T Read<T>(Func<string, T> parseFunc, Func<T, bool> validateFunc = null, string errorMessage = "Wrong input format")
        {
            bool success = false;
            while (!success)
            {
                try
                {
                    T val = parseFunc(Console.ReadLine());
                    if (validateFunc != null)
                    {
                        success = validateFunc(val);
                        if(success) return val;
                        else continue;
                    }
                    else return val;

                }
                catch (Exception e)
                {
                    Console.WriteLine(errorMessage);
                    success = false;
                    continue;
                }
            }
            return default(T);
        }

        public static T[] ReadTable<T>(char separator, Func<string, T> parseFunc, Func<T[], bool> validateFunc = null, string errorMessage = "Wrong input format")
        {
            bool success = false;
            while (!success)
            {
                try
                {
                    var array = Console.ReadLine()
                    .Split(separator)
                    .Select(parseFunc)
                    .ToArray();

                    if(validateFunc != null)
                    {
                        success = validateFunc(array);
                        if(success) return array;
                        else continue;
                    }                    
                    else return array;
                }
                catch (Exception e)
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
        public static bool IsPowerOfTwo(uint x)
        {
            return (x & (x - 1)) == 0;
        }
        public static bool TryFindMaxPowerOfTwo(IEnumerable<uint> array, out uint max)
        {
            bool success = false;
            max = uint.MinValue;
            foreach (uint x in array)
            {
                if (Utils.IsPowerOfTwo(x) && x > max)
                {
                    max = x;
                    success = true;
                }
            }

            return success;
        }
    }
}