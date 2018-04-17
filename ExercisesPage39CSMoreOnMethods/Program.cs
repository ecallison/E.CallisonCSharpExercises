using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesPage39CSMoreOnMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DoSomething doSomething = new DoSomething();
            Console.WriteLine("Hello Employees of Callison Tech! Please enter the number of hours you worked this week:");
            Int32.TryParse(Console.ReadLine(), out int weeklyHours);

            Console.WriteLine("\nThank you! Please enter a number that represents the amount you make per hour:");
            Int32.TryParse(Console.ReadLine(), out int employeeWage);

            doSomething.CalculateWeeklyEarnings(weeklyHours, employeeWage);

            Console.ReadLine();
        }
    }
}
