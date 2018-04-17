using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesPage39CSMoreOnMethods
{
    class DoSomething
    {
        public void CalculateWeeklyEarnings(int weeklyHours, int employeeWage)
        {
            int Answer1 = employeeWage * weeklyHours;

            Console.WriteLine("You earn ${0} per hour.", employeeWage);

            Console.WriteLine(" You earned ${0} this week.", Answer1);
        }
    }
}
