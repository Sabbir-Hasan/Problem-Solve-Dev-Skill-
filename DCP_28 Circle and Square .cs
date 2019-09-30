using System;

namespace DCP_28_CircleAndSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                var line = Console.ReadLine();
                var input = line.Split(' ');
                double r = Convert.ToDouble(input[0]);
                double s = Convert.ToDouble(input[1]);
                r = r * 2;
                s = Math.Sqrt(2) * s;
                double rm = Math.Abs(s - r);
                if (r == s || rm <= 0.1)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}
