using System;

namespace _17.SumQuadraticMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumIn = 0;
            int below = 0;
            int above = 0;
            Console.WriteLine("Insert the length of the matrix: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Insert {0} element one per line:", n*n);
            //array
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int p = 0; p < n; p++)
                {
                     matrix[i, p] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("The matrix:");
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int p = 0; p < matrix.GetLength(1); p++)
                {
                    sumIn += matrix[i, p];
                    for (p = 0; p < matrix.GetLength(1); p++)
                    {
                        Console.Write(" " + matrix[i, p]);
                    }
                    Console.WriteLine();
                    //не успях да измисля методите за above и below, затова ги описах, но само за 3 числа
                    below = matrix[1, 0] + matrix[2, 0] + matrix[2, 1];
                    above = matrix[0, 1] + matrix[0, 2] + matrix[1, 2];

                }
                Console.WriteLine("The sum of elements in the diagonal: {0}",sumIn);
                Console.WriteLine("The sum of elements below the diagonal: {0}", below);
                Console.WriteLine("The sum of elements above the diagonal: {0}", above);
        }
    }
}
