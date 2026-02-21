using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the correct answers: ");
            int corrAnsw = int.Parse(Console.ReadLine());

            Console.Write("Enter the ammount of questions: ");
            int questions = int.Parse(Console.ReadLine());

            Console.Write("Enter the bonus points: ");
            int bonPoint = int.Parse(Console.ReadLine());

            int finalPoints = 0;

            finalPoints = corrAnsw * 5;

            double percent = (double)corrAnsw / questions*100;
            if(percent > 90)
            {
                finalPoints = finalPoints + 10;
            }

            if (bonPoint > 20)
            {
                bonPoint = 20;
            }
            finalPoints = finalPoints + bonPoint;

            Console.WriteLine();
            if (finalPoints < 50)
            {
                Console.WriteLine($"Final grade: 2.00 // Points: {finalPoints}");
            }
            else if (finalPoints >= 50 && finalPoints <= 59)
            {
                Console.WriteLine($"Final grade: 3.00 // Points: {finalPoints}");
            }
            else if (finalPoints >= 60 && finalPoints <= 74)
            {
                Console.WriteLine($"Final grade: 4.00 // Points: {finalPoints}");
            }
            else if (finalPoints >= 75 && finalPoints <= 89)
            {
                Console.WriteLine($"Final grade: 5.00 // Points: {finalPoints}");
            }
            else
            {
                Console.WriteLine($"Final grade: 6.00 // Points: {finalPoints}");
            }
        }
    }
}
