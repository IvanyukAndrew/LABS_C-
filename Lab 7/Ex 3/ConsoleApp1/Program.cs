using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a x1 = ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("a y1 = ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("b x2 = ");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("b y2 = ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            int dob = x1 * x2 + y1 * y2;

            if (dob == 0)
            {
                Console.WriteLine("Вектои є перпендикулярні");
            }
            else
            {
                Console.WriteLine("Вектои не є перпендикулярні");
            }
        }
    }
}
