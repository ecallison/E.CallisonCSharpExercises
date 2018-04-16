using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesPage38MoreOnMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            WeeklyWageCalculator weeklyWageCalculator = new WeeklyWageCalculator();

            Console.WriteLine("Hello Employees of Callison Tech! Please enter the number of hours you worked this week:");
            Int32.TryParse(Console.ReadLine(), out int weeklyHours);

            Console.WriteLine("\nThank you! Please enter a number that represents the amount you make per hour. If you do not enter your wage, we will assume you earn $55/hour :)");
            bool yes = Int32.TryParse(Console.ReadLine(), out int employeeWage);
            if (yes) 
            {
                int product = weeklyWageCalculator.CalculateWeeklyEarnings(weeklyHours, employeeWage);

                Console.WriteLine("\nYou earned ${0}" + " this week!", product);
            }
            else
            {
                int product = weeklyWageCalculator.CalculateWeeklyEarnings(weeklyHours);

                Console.WriteLine("\nYou earned ${0}" + " this week!", product);

            }

            
            Console.ReadLine();
        }
    }
}
