using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Monitor
    {
        public string Name;
        public int productionDate;
        public int purchaseDate;
        public float Price;
        public int a;
        public int b;
        public Monitor(string name, int production_date, int purchase_date, float price, int h, int w)
        {
            this.Name = name;
            this.productionDate = production_date;
            this.purchaseDate = purchase_date;
            this.Price = price;
            this.a = a;
            this.b = b;
        }
        public void age(int currentYear)
        {
            Console.WriteLine($"Вік монітору:{currentYear - purchaseDate} роки");
        }
        public void enableDisplay(int ai, int bi)
        {
            if (ai <= a && bi <= b)
            {
                Console.WriteLine("Можна без масштабування");
            }
            else
            {
                Console.WriteLine("Без масштабування не можна");
            }
        }
        public void koef(int ai, int bi)
        {
            float k1 = a / ai;
            float k2 = b / bi;
            Console.WriteLine($"Коефіціенти {k1},{k2}");
        }
    }
}