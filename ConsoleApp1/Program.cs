using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Lengh of Massive:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int maxIndex = 0;
            int minIndex = 0;

            for (int i = 1 ; i < arr.Length; i++)
            {
                if (arr[i] > arr[maxIndex])
                    maxIndex = i;
                if (arr[i] < arr[minIndex])
                    minIndex = i;
            }
            int tmp = arr[minIndex];
            arr[minIndex] = arr[maxIndex];
            arr[maxIndex] = tmp;

            for (int i = 0; i < arr.Length; i++)
                {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
