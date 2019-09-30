using System;

namespace Dev01_TheWorkIsDone
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                    var line = Console.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    var input = line.Split(' ');
                    int a = Convert.ToInt32(input[0]);
                    int b = Convert.ToInt32(input[1]);
                    int[] arr = new int[100];
                    int temp;
                    double s = 0;
                    for (int j = 0; j < b; j++)
                    {
                         temp = Convert.ToInt32(Console.ReadLine());
                         arr[j] = temp;
                         s = s + arr[j];
                    }
                    double day = a / s;
                    double result = Math.Ceiling(day); 
                    if (result == 1)
                    {
                        Console.WriteLine("Project will finish within 1 day.");
                    }
                    else
                    {
                        Console.WriteLine("Project will finish within {0} days.", result);
                    }
                
            }
        }
    }
}
