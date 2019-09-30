using System;

namespace DCP_32_TheGrid
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
                int x1 = Convert.ToInt32(input[0]);
                int y1 = Convert.ToInt32(input[1]);
                int x2 = Convert.ToInt32(input[2]);
                int y2 = Convert.ToInt32(input[3]);
                int x = (Math.Abs(x2 - x1) + Math.Abs(y2 - y1));
                Console.WriteLine("Case {0}: {1}", i + 1, x);
            }
        }
    }
}
