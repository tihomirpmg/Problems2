using System;

namespace _18.TemperaturesInTheWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 7;
            int cols = 6;
            double[,] matrix = new double[rows, cols];
            
            //Опитах се да направя по прегледна задачата, но не ми позволява понеже масива е тип инт
            //а когато го направя стринг не мога да сметна средната температура за всеки ден понеже опитвам от стринг да деля

            /*matrix[0, 0]= string.Format("Monday 00:00=");
            matrix[0, 1] = string.Format("Monday 04:00=");
            matrix[0, 2] = string.Format("Monday 08:00=");
            matrix[0, 3] = string.Format("Monday 12:00=");
            matrix[0, 4] = string.Format("Monday 16:00=");
            matrix[0, 5] = string.Format("Monday 20:00=");

            matrix[1, 0] = string.Format("Tuesday 00:00=");
            matrix[1, 1] = string.Format("Tuesday 04:00=");
            matrix[1, 2] = string.Format("Tuesday 08:00=");
            matrix[1, 3] = string.Format("Tuesday 12:00=");
            matrix[1, 4] = string.Format("Tuesday 16:00=");
            matrix[1, 5] = string.Format("Tuesday 20:00=");

            matrix[2, 0] = string.Format("Wednesday 00:00=");
            matrix[2, 1] = string.Format("Wednesday 04:00=");
            matrix[2, 2] = string.Format("Wednesday 08:00=");
            matrix[2, 3] = string.Format("Wednesday 12:00=");
            matrix[2, 4] = string.Format("Wednesday 16:00=");
            matrix[2, 5] = string.Format("Wednesday 20:00=");

            matrix[3, 0] = string.Format("Thursday 00:00=");
            matrix[3, 1] = string.Format("Thursday 04:00=");
            matrix[3, 2] = string.Format("Thursday 08:00=");
            matrix[3, 3] = string.Format("Thursday 12:00=");
            matrix[3, 4] = string.Format("Thursday 16:00=");
            matrix[3, 5] = string.Format("Thursday 20:00=");

            matrix[4, 0] = string.Format("Friday 00:00=");
            matrix[4, 1] = string.Format("Friday 04:00=");
            matrix[4, 2] = string.Format("Friday 08:00=");
            matrix[4, 3] = string.Format("Friday 12:00=");
            matrix[4, 4] = string.Format("Friday 16:00=");
            matrix[4, 5] = string.Format("Friday 20:00=");

            matrix[5, 0] = string.Format("Saturday 00:00=");
            matrix[5, 1] = string.Format("Saturday 04:00=");
            matrix[5, 2] = string.Format("Saturday 08:00=");
            matrix[5, 3] = string.Format("Saturday 12:00=");
            matrix[5, 4] = string.Format("Saturday 16:00=");
            matrix[5, 5] = string.Format("Saturday 20:00=");

            matrix[6, 0] = string.Format("Sunday 00:00=");
            matrix[6, 1] = string.Format("Sunday 04:00=");
            matrix[6, 2] = string.Format("Sunday 08:00=");
            matrix[6, 3] = string.Format("Sunday 12:00=");
            matrix[6, 4] = string.Format("Sunday 16:00=");
            matrix[6, 5] = string.Format("Sunday 20:00=");*/

            for (int row = 0; row < rows; row++)
            for (int col = 0; col < cols; col++)
            {
                for (col = 0; col < cols; col++)
                {
                        //insert temperature for each day and time
                    Console.Write("Matrix[{0},{1}] temp= ", row,col); 
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(" " + matrix[row, col]);
                }
                Console.WriteLine();
            }
            //print the temp for each day and each time
            Console.WriteLine("The average temperature for every Monday is: {0:f2}", ((matrix[0, 0] + matrix[0, 1] + matrix[0, 2] + matrix[0, 3] + matrix[0, 4] + matrix[0, 5]))/6);
            Console.WriteLine("The average temperature for every Tuesday is: {0:f2}", ((matrix[1, 0] + matrix[1, 1] + matrix[1, 2] + matrix[1, 3] + matrix[1, 4] + matrix[1, 5])) / 6);
            Console.WriteLine("The average temperature for every Wednesday is: {0:f2}", ((matrix[2, 0] + matrix[2, 1] + matrix[0, 2] + matrix[2, 3] + matrix[2, 4] + matrix[2, 5])) / 6);
            Console.WriteLine("The average temperature for every Thursday is: {0:f2}", ((matrix[3, 0] + matrix[3, 1] + matrix[3, 2] + matrix[3, 3] + matrix[3, 4] + matrix[3, 5])) / 6);
            Console.WriteLine("The average temperature for every Friday is: {0:f2}", ((matrix[4, 0] + matrix[4, 1] + matrix[4, 2] + matrix[4, 3] + matrix[4, 4] + matrix[4, 5])) / 6);
            Console.WriteLine("The average temperature for every Saturday is: {0:f2}", ((matrix[5, 0] + matrix[5, 1] + matrix[5, 2] + matrix[5, 3] + matrix[5, 4] + matrix[5, 5])) / 6);
            Console.WriteLine("The average temperature for every Friday is: {0:f2}", ((matrix[6, 0] + matrix[6, 1] + matrix[6, 2] + matrix[6, 3] + matrix[6, 4] + matrix[6, 5])) / 6);
            Console.WriteLine("The average temperature on 00:00 in the weekdays is: {0:f2}", ((matrix[0, 0] + matrix[1, 0] + matrix[2, 0] + matrix[3, 0] + matrix[4, 0] + matrix[5, 0] + matrix[6, 0])) / 7);
            Console.WriteLine("The average temperature on 04:00 in the weekdays is: {0:f2}", ((matrix[0, 1] + matrix[1, 1] + matrix[2, 1] + matrix[3, 1] + matrix[4, 1] + matrix[5, 1] + matrix[6, 1])) / 7);
            Console.WriteLine("The average temperature on 08:00 in the weekdays is: {0:f2}", ((matrix[0, 2] + matrix[1, 2] + matrix[2, 2] + matrix[3, 2] + matrix[4, 2] + matrix[5, 2] + matrix[6, 2])) / 7);
            Console.WriteLine("The average temperature on 12:00 in the weekdays is: {0:f2}", ((matrix[0, 3] + matrix[1, 3] + matrix[2, 3] + matrix[3, 3] + matrix[4, 3] + matrix[5, 3] + matrix[6, 3])) / 7);
            Console.WriteLine("The average temperature on 16:00 in the weekdays is: {0:f2}", ((matrix[0, 4] + matrix[1, 4] + matrix[2, 4] + matrix[3, 4] + matrix[4, 4] + matrix[5, 4] + matrix[6, 4])) / 7);
            Console.WriteLine("The average temperature on 20:00 in the weekdays is: {0:f2}", ((matrix[0, 5] + matrix[1, 5] + matrix[2, 5] + matrix[3, 5] + matrix[4, 5] + matrix[5, 5] + matrix[6, 5])) / 7);
        }
    }
}
