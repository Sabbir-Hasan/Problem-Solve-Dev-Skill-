using System;

namespace DCP_20_BackToSchool
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
                int x1 = Convert.ToInt32(input[0]);
                int x2 = Convert.ToInt32(input[1]);
                double r = Convert.ToDouble(input[2]);
                int y1 = Convert.ToInt32(input[3]);
                int y2 = Convert.ToInt32(input[4]);
                int X = (x1 - y1);
                int Y = (x2 - y2);
                int sum = ((X * X) + (Y * Y));
                double result = Math.Sqrt(sum);
                if (result == r)
                {
                    Console.WriteLine("Case {0}: OnCircle",i+1);
                }
                else if (result > r)
                {
                    Console.WriteLine("Case {0}: Outside", i+1);
                }
                else
                {
                    Console.WriteLine("Case {0}: Inside", i+1);
                }
            }
        }
    }
}
