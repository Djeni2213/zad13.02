using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter your years of internship: ");
            int yearOfIntern = int.Parse(Console.ReadLine());

            Console.Write("Enter your amount of violations: ");
            int violations = int.Parse(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("You don't have the rights to drive!!!");
            }
            else if (violations > 5)
            {
                Console.WriteLine("Your licence is temporarily taken!"); 
            }
            else if (yearOfIntern>10 && violations == 0)
            {
                Console.WriteLine("Professional driver");  
            }
            else if (yearOfIntern < 2)
            {
                Console.WriteLine("Beginner driver");
            }
            else
            {
                Console.WriteLine("Regular driver");
            }
        }
    }
}
