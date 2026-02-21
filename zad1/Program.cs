using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the income of a member of the family: ");
            double income = double.Parse(Console.ReadLine());

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
            Console.Write("Enter the students avrage grade: ");
            double grade = double.Parse(Console.ReadLine());

            bool socScholarship = false;
            bool outsScholarship = false;

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
            Console.Write("Enter the minimum wage: ");
            double minWage = double.Parse(Console.ReadLine());

            double socTake = 0.35 * minWage;
            double outsTake = 0.25 * minWage;

            if (income < 450 && grade > 4.5)
            {
                Console.WriteLine();
                Console.WriteLine($"You can have social scholarship! -> It is {socTake}");
                socScholarship = true;
            }
            if (grade > 5.5)
            {
                Console.WriteLine();
                Console.WriteLine($"You can have the scholarship for outstanding achievements! -> It is {outsTake}");
                outsScholarship = true;
            }
            if (socScholarship == true && outsScholarship == true)
            {
                Console.WriteLine("================================================================");
                Console.WriteLine($"The scholarship you are gonna take is {socTake}");
            }
            if (socScholarship == false && outsScholarship == false)
            {
                Console.WriteLine();
                Console.WriteLine("You can't have any scholarship!!!");
            }
        }
    }
}
