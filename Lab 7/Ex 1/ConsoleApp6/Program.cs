using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.Write("Ведіть n:");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            arr[n] = rand.Next(-10, 10);
            Console.Write(n);

        }
    }
}
