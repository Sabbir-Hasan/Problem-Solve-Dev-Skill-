using System;

namespace DCP_14_Box
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());
            double[] arr = new double[100];
            for (int i = 0; i < T; i++)
            {
                var line = Console.ReadLine();
                var input = line.Split(' ');
                double a = Convert.ToDouble(input[0]);
                double b = Convert.ToDouble(input[1]);
                double c = Convert.ToDouble(input[2]);
                double sum = ((a * a) + (b * b) + (c * c));
                double result = Math.Sqrt(sum);
                Console.WriteLine("{0:F2}", result);
            }
        }
    }
}
