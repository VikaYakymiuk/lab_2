using System;
using System.Linq;

namespace Problem_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of element: ");
            int k = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[k * 4];
            int[] middle = new int[k * 2];
            int[] start = new int[k];
            int[] end = new int[k];
            int[] result = new int[middle.Length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = array.Length - k * 3 - 1, j = 0; i >= 0; i--, j++)
            {
                start[j] = array[i];
            }

            for (int i = array.Length - k * 3, j = 0; j < middle.Length; i++, j++)
            {
                middle[j] = array[i];
            }

            for (int i = array.Length - 1, j = 0; i >= array.Length - k; i--, j++)
            {
                end[j] = array[i];
            }

            int[] startEnd = start.Concat(end).ToArray();
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = middle[i] + startEnd[i];
            }

            Console.WriteLine("Array => " + String.Join(", ", array));
            Console.WriteLine("Result => " + String.Join(", ", result));
        }
    }

}