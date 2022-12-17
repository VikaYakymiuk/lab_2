using System;

namespace Problem_2
{
    internal class Program
    {

        static void Rotate(int[] arr,int n,int k)
        {

            for (int i = 0; i < n; i++)
            {
                if (i < k)
                {
                    Console.Write(arr[n + i - k] + " ");
                }
                else
                {
                    Console.Write(arr[i - k] + " ");
                }
            }
           
            Console.WriteLine();
        }

        
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5,6,7,8 };
            int n=arr.Length;
            int k = 4;

            Rotate(arr, n, k);
        }
    }
}
