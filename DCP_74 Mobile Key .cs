using System;

namespace DCP_74_Mobile_Key
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                var a = Convert.ToInt64(Console.ReadLine());
                Console.Write("Case #{0}: ",i+1);
                var s = a * 3;
                if (a % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2}", s, s - 1, s - 2);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", s - 2, s - 1, s);
                }
            }
        }
    }
}
