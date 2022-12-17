using System;

namespace Problem_10
{
    internal class Program
    {
        static int Difference(int[] arr, int n, int k)
        {
            int Dif = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[i] - arr[j] == k && arr[i] - arr[j + 1]!=1 )
                    {
                        Console.WriteLine("Pairs by Difference : [{0} ]", arr[i]);
                        Dif++;
                    }
                }
            }
            return Dif;
        }

        static void Main()
        {
            int[] arr = { 0, 2, 3, 4, 7, 8 };
            int n = arr.Length;
            int k = 1;

            Console.WriteLine(Difference(arr, n, k) + " - the number of pairs with a difference");


        }


    }
}
