using System;

namespace DCP_46_Hall_Of_Fames_Of_JU_Programming_Society
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
                int x2 = Convert.ToInt32(input[1]);
                Console.WriteLine(Convert.ToInt32((x1 + x2) / 2));
            }
        }
    }
}
