using System;

namespace DCP_13_Banglawash
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[100];
            for (int i = 0; i < T; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    var line = Console.ReadLine();
                    var input = line.Split(' ');
                    int a = Convert.ToInt32(input[0]);
                    int b = Convert.ToInt32(input[1]);
                    int c = Convert.ToInt32(input[2]);
                    int d = Convert.ToInt32(input[3]);
                    a = a - c;
                    b = a + b;
                    arr[j] = b - d;
                }
                if (arr[0] > 0 && arr[1] > 0)
                {
                    Console.WriteLine("Banglawash");
                }
                else
                    Console.WriteLine("Miss");
            }
        }
    }
}
