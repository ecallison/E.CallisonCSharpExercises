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





//1. Create a class. In that class, create a void method that outputs an integer.Have the method divide the data passed to it by 2.

//2. In the Main() method, instantiate that class.

//3. Have the user enter a number.Call the method on that number.Display the output to the screen. It should be the entered number, divided by two.

//4. Create a method with output parameters.

//5. Overload a method.

//6. Declare a class to be static.
