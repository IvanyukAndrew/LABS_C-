using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("c = ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введіть кількість елементів: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int d = 0;

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = a[i-1]*a[i-1]+2*a[i-2];
                if (a[i] > b && a[i] <= c)
                {
                    d += a[i];
                }
            }
            int S = d / 2;
            Console.Write(S);
        }
    }
}
