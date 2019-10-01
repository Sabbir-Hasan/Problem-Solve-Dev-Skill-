using System;

namespace DCP_85_Tomorrow_is_Eid___
{
    class Program
    {
        static void Main(string[] args)
        {
            int D = Convert.ToInt32(Console.ReadLine());
            if (D == 29 || D == 30)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
