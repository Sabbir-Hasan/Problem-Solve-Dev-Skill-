using System;

namespace DCP_69_Miraclaw_and_funny_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                int s = 0,c = 0;
                var line = Console.ReadLine();
                var input = line.Split(' ');
                for (int j = 0; j < x; j++)
                {
                    int v = int.Parse(input[j]);
                    s = s + v;
                    int r = v - j;
                    if (r<0)
                    {
                        r = 0;
                    }
                    c = c + r;
                }
                Console.WriteLine(s-c);
            }
        }
    }
}
