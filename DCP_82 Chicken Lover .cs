using System;

namespace DCP_82_Chicken_Lover
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int inp = Convert.ToInt32(Console.ReadLine());
                if (inp >=120)
                {
                    Console.WriteLine("Good Boy Sifat");
                }
                else
                {
                    Console.WriteLine("Naughty Boy Sifat");
                }
            }
        }
    }
}
