using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the baggages weight: ");
            int kgBag = int.Parse(Console.ReadLine());

            Console.WriteLine("=======================================");
            Console.Write("Enter the type of ticket (standart/business): ");
            string ticket = Console.ReadLine().ToLower();

            Console.WriteLine("=======================================");
            Console.Write("Enter the flights distance: ");
            int distance = int.Parse(Console.ReadLine());

            double ticPrice = 0;

            Console.WriteLine();
            if (kgBag < 20)
            {
                Console.WriteLine("The flight ticket is free!");
            }
            else if (kgBag>=20 && kgBag<30)
            {
                ticPrice = (kgBag - 20) * 10;
            }
            else
            {
                ticPrice = (kgBag - 30) * 25;
            }

            if (ticket == "business")
            {
                ticPrice = ticPrice * 0.3;
            }

            if (distance > 3000)
            {
                ticPrice = ticPrice * 0.2;
            }

            Console.WriteLine($"Your ticket price is {ticPrice}");
        }
    }
}
