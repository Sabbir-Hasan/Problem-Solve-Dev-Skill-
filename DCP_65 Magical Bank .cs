using System;

namespace DCP_65_Magical_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                var x = ((Math.Sqrt(1.0 + (8 * a))) - 1.0) / 2.0;
                Console.WriteLine(Math.Ceiling(x));
            }
        }
    }
}
