using System;

namespace _10.Sqrt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type three numbers to calculate the Sqrt: ");
            //insert the coefficients
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double x1 = 0;
            double x2 = 0;
            //discriminant formula
            double discriminant = ((b * b) - (4 * a * c));
            //case 1
            if (a != 0 && discriminant > 0)
            {
                x1 = ((-b) + Math.Sqrt(discriminant)) / (2 * a);
                x2 = ((-b) - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine(string.Format("x1={0:f2}, x2={1:f2}", x1, x2));
            }
            //case 2
            else if (a != 0 && discriminant == 0)
            {
                x1 = (-b) / 2 * a;
                Console.WriteLine(string.Format("There is only one sqrt x1={0:f2}", x1));
            }
            //case 3
            else if (a != 0 && discriminant < 0)
            {
                Console.WriteLine("There is no sqrt!");
            }
        }
    }
}
