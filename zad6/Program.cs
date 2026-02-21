using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your income: ");
            double income = double.Parse(Console.ReadLine());

            Console.Write("Enter your relationship(single/married): ");
            string relationship = Console.ReadLine().ToLower();

            Console.Write("Enter how many kids you have: ");
            int kids =int.Parse(Console.ReadLine());

            double tax = 0;

            if (income <= 12000)
            {
                tax += 0.1;
            }
            else if(income >12000 &&  income <= 30000)
            {
                tax += 0.15;
            }
            else
            {
                tax += 0.2;
            }

            if (relationship == "married")
            {
                tax -= 0.02;
            }

            double kidsDiscount = 0;
            if (kids <= 5 )
            {
                kidsDiscount = kids * 0.01;
                tax -= kidsDiscount;
            }
            else
            {
                kidsDiscount = 0.05;
                tax -= kidsDiscount;
            }

            if( tax < 0 )
            {
                tax = 0;
            }

            Console.WriteLine($"The final tax is {income*tax:f2}");
        }
    }
}
