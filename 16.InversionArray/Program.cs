using System;
using System.Linq;

namespace _16.InversionArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type numbers to calculate how many inversions have the array: ");
            //insert the array on one row
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //count, for calucalate the inversions
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
                for (int j = 0; j < arr.Length; j++)
                    //case
                    if (arr[i] > arr[j])
                    {
                        count++;
                    }
            //print
            Console.WriteLine(count);
        }
    }
}
