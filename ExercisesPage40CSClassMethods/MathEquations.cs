using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesPage40CSClassMethods
{
    class MathEquations
    {
        public void DoMath(int userNumber)
        {
            int Answer1 = userNumber / 2;

            Console.WriteLine("Your number divided by 2 is {0}", Answer1);
        }

        public void Answer1DividedByTwo(out int Answer2, int userNumber)
        {
            Answer2 = (userNumber / 2) / 2;
        }

        public double DoMath(string userNumber2)
        {
            double getDouble = Convert.ToDouble(userNumber2);
            double Answer3 = Math.Pow(getDouble, 3);
            return Answer3;
        }
    }
}

