using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesPage38MoreOnMethods
{
    class WeeklyWageCalculator
    {
        public int CalculateWeeklyEarnings(int weeklyHours, int employeeWage = 55)
        {
            return weeklyHours * employeeWage;
        }
    }
}
