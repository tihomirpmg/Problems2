using System;
using System.Linq;

namespace SortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type numbers to be sorted by method: ");
            //insert the array
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine("Ascending or Descending?");
            //variable for Ascending or Descending
            string type = Console.ReadLine();
            for (int i = 0; i < arr.Length - 1; i++)
                for (int j = 0; j < arr.Length - 1; j++)
                    switch (type)
                    {
                        //switch case to check if you want Ascending or Descending
                        case "Ascending":
                            if (arr[j] > arr[j + 1])
                            {
                                int swap = arr[j];
                                arr[j] = arr[j + 1];
                                arr[j + 1] = swap;
                            }
                            break;
                        case "Descending":
                            if (arr[j] < arr[j + 1])
                            {
                                int swap = arr[j];
                                arr[j] = arr[j + 1];
                                arr[j + 1] = swap;
                            }
                            break;
                    }
            //print
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}