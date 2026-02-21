using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the sum of the purchase: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Are you a regular or vip client? Enter regular or vip: ");
            string client = Console.ReadLine().ToLower();

            Console.Write("Enter the day of the week: ");
            string dOtw = Console.ReadLine().ToLower();

            double discount = 0;

            if (price > 1000)
            {
                discount += 0.2;
            }
            else if (price >500)
            {
                discount += 0.1;
            }

            if (client == "vip")
            {
                discount += 0.05;
            }

            if (dOtw == "sunday")
            {
                discount += 0.03;
            }

            Console.WriteLine($"Your final price is {price*(1-discount)}");
        }
    }
}
