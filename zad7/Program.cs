using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the orders price: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Enter the type of delivery(standard/express): ");
            string delivery = Console.ReadLine().ToLower();

            Console.Write("Enter the distance (km): ");
            double distance = double.Parse(Console.ReadLine());

            double deliveryPrice = 0;
            if (delivery == "standard")
            {
                if (price > 100)
                {
                    deliveryPrice = 0;
                }
                else
                {
                    deliveryPrice = 5 + (distance * 0.1);
                }
            }

            if (delivery == "express")
            {
                if (price > 200)
                {
                    deliveryPrice = 0;
                }
                else
                {
                    deliveryPrice = 10 + (distance * 0.25);
                }
            }

            price = price + deliveryPrice;

            Console.WriteLine($"The final price is: {price:f2}");
        }
    }
}
